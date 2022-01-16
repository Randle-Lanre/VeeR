using System;
using System.Timers;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Timer = System.Timers.Timer;

namespace VeeR
{
    public partial class VeeRCb : MaterialForm
    {
        private Timer _sTime;

        private int _hrs, _mns, _sec;

        //
        private static readonly Random RandomNumber = new Random();
        
        private static readonly System.Windows.Forms.Timer WinFormsTimer = new System.Windows.Forms.Timer();
        private static readonly bool ExitFlag = false;

        public VeeRCb()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue200, Primary.LightBlue300,
                Primary.LightBlue400, Accent.LightBlue200, TextShade.BLACK);


        }

        private void VeeR_CB_Load(object sender, EventArgs e)
        {
            _sTime = new Timer();
            _sTime.Interval = 1000;
            _sTime.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                _sec += 1;
                if (_sec == 60)
                {
                    _sec = 0;
                    _mns += 1;
                }

                if (_mns == 60)
                {
                    _mns = 0;
                    _hrs += 1;
                }

                TextBoxShwoingTimeRunning.Text = string.Format($"{_hrs.ToString()}: {_mns.ToString()}:{_sec.ToString()}");


            }));
        }

        //Start button
        private void materialButton1_Click(object sender, EventArgs e)
        {
            //TODO: use the timer function in winforms class 
            var interruptAt = selectTimeInterval.SelectedIndex;
            materialButton1.Enabled = false;

            FireTriggersForMouse(interruptAt);
            
        }

        private static int FireTriggersForMouse(int interuptAt = 8)
        {
            /**
             *  10 sec - Idx 0
             *  30 sec - Idx 1
             *  1 min -  Idx 2
             *  3 min - Idx 3
             *  5 min - Idx 4
             *  10min - IDx 5
             */

            int[] value = { 10000, 30000, 60000, 180000, 300000, 1800000 };
            WinFormsTimer.Tick += SkipTime;

            WinFormsTimer.Interval = (int)(interuptAt == 8 ? 5000 : value.GetValue(interuptAt));
            WinFormsTimer.Start();

            while (ExitFlag == false)
                Application.DoEvents();

            return 0;



        }


        // used for elapsed time event args
        private static void SkipTime(object sender, EventArgs e)
        {

            WinFormsTimer.Stop();
            WinFormsTimer.Enabled = true;
            MoveMouse.SetCursorPosition(RandomNumber.Next(100, 600), RandomNumber.Next(200, 700));

            
        }

        //should time running be shown
        private void DisplayTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {


            _sTime.Start();
            DisplayTimeCheckBox.Enabled = false;


            //TODO: just testing the cursor movement 
            //MoveMouse.SetCursorPosition(125, 400);

            /**
             *  10 sec - Idx 0
             *  30 sec - Idx 1
             *  1 min -  Idx 2
             *  3 min - Idx 3
             *  5 min - Idx 4
             *  10min - IDx 5
             * 
             */

        }




        //interval to toggle
        private void selectTimeInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
            var selectedValue = selectTimeInterval.SelectedIndex;
            Console.WriteLine(selectedValue);
        }

        private void VeeR_CB_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            _sTime.Stop();
            _sTime.Dispose();
            Application.DoEvents();

        }

    }
}
