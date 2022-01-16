using System.ComponentModel;

namespace VeeR
{
    partial class VeeRCb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeeRCb));
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.DisplayTimeCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.selectTimeInterval = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxShwoingTimeRunning = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(313, 470);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(67, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Start";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // DisplayTimeCheckBox
            // 
            this.DisplayTimeCheckBox.AutoSize = true;
            this.DisplayTimeCheckBox.Depth = 0;
            this.DisplayTimeCheckBox.Location = new System.Drawing.Point(23, 108);
            this.DisplayTimeCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayTimeCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DisplayTimeCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.DisplayTimeCheckBox.Name = "DisplayTimeCheckBox";
            this.DisplayTimeCheckBox.ReadOnly = false;
            this.DisplayTimeCheckBox.Ripple = true;
            this.DisplayTimeCheckBox.Size = new System.Drawing.Size(178, 37);
            this.DisplayTimeCheckBox.TabIndex = 3;
            this.DisplayTimeCheckBox.Text = "Show Time Running";
            this.DisplayTimeCheckBox.UseVisualStyleBackColor = true;
            this.DisplayTimeCheckBox.CheckedChanged += new System.EventHandler(this.DisplayTimeCheckBox_CheckedChanged);
            // 
            // selectTimeInterval
            // 
            this.selectTimeInterval.AutoResize = false;
            this.selectTimeInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectTimeInterval.Depth = 0;
            this.selectTimeInterval.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.selectTimeInterval.DropDownHeight = 174;
            this.selectTimeInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTimeInterval.DropDownWidth = 121;
            this.selectTimeInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.selectTimeInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectTimeInterval.FormattingEnabled = true;
            this.selectTimeInterval.IntegralHeight = false;
            this.selectTimeInterval.ItemHeight = 43;
            this.selectTimeInterval.Items.AddRange(new object[] { "10 sec", "30 sec", "1 Min", "3 Min", "5 Min", "10 Min" });
            this.selectTimeInterval.Location = new System.Drawing.Point(289, 190);
            this.selectTimeInterval.MaxDropDownItems = 4;
            this.selectTimeInterval.MouseState = MaterialSkin.MouseState.OUT;
            this.selectTimeInterval.Name = "selectTimeInterval";
            this.selectTimeInterval.Size = new System.Drawing.Size(253, 49);
            this.selectTimeInterval.StartIndex = 0;
            this.selectTimeInterval.TabIndex = 4;
            this.selectTimeInterval.SelectedIndexChanged += new System.EventHandler(this.selectTimeInterval_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(100, 412);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(186, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Time Running in Minutes :";
            // 
            // TextBoxShwoingTimeRunning
            // 
            this.TextBoxShwoingTimeRunning.AnimateReadOnly = false;
            this.TextBoxShwoingTimeRunning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxShwoingTimeRunning.Depth = 0;
            this.TextBoxShwoingTimeRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxShwoingTimeRunning.LeadingIcon = null;
            this.TextBoxShwoingTimeRunning.Location = new System.Drawing.Point(346, 381);
            this.TextBoxShwoingTimeRunning.MaxLength = 50;
            this.TextBoxShwoingTimeRunning.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxShwoingTimeRunning.Multiline = false;
            this.TextBoxShwoingTimeRunning.Name = "TextBoxShwoingTimeRunning";
            this.TextBoxShwoingTimeRunning.ReadOnly = true;
            this.TextBoxShwoingTimeRunning.Size = new System.Drawing.Size(292, 50);
            this.TextBoxShwoingTimeRunning.TabIndex = 6;
            this.TextBoxShwoingTimeRunning.Text = "";
            this.TextBoxShwoingTimeRunning.TrailingIcon = null;
            // this.TextBoxShwoingTimeRunning.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(23, 220);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(158, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Mouse Toggle interval";
            // 
            // VeeR_CB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.TextBoxShwoingTimeRunning);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.selectTimeInterval);
            this.Controls.Add(this.DisplayTimeCheckBox);
            this.Controls.Add(this.materialButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VeeRCb";
            this.Sizable = false;
            this.Text = "VeeR";
            this.Load += new System.EventHandler(this.VeeR_CB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MaterialSkin.Controls.MaterialLabel materialLabel2;

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox TextBoxShwoingTimeRunning;

        private MaterialSkin.Controls.MaterialComboBox selectTimeInterval;

        private MaterialSkin.Controls.MaterialCheckbox DisplayTimeCheckBox;

        private MaterialSkin.Controls.MaterialButton materialButton1;

        #endregion

    }
}

