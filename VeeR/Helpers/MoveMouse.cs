using System.Runtime.InteropServices;

namespace VeeR
{
    public static class MoveMouse
    {

        
            
            [DllImport("user32.dll")]
            static extern bool SetCursorPos(int x, int y);

            public static void SetCursorPosition(int x, int y)
            {
                //TODO: add randomizer : X== 100-600, Y== 100-600
                SetCursorPos(x, y);
            }
            
        
        
    }
}
