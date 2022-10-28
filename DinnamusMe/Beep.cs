using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DinnamusMe
{
    class Beep
    {
        [DllImport("CoreDll.dll")]
        public static extern void MessageBeep(int code);
        public static void MessageBeep() 
        { 
            MessageBeep(-1);
        }
    }
}
