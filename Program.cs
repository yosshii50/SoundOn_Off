using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoundOn_Off
{
    class Program
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        const int WM_APPCOMMAND = 0x319;

        const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        //const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        //const int APPCOMMAND_VOLUME_UP = 0xA0000;

        static void Main(string[] args)
        {
            IntPtr hWnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            SendMessage(hWnd, WM_APPCOMMAND, IntPtr.Zero, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }
    }
}
