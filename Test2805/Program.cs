using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Runtime.InteropServices;

namespace Test2805
{
    internal class Program
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
        static async Task Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Witajcie!", "Okno WinApi", 0);
        }
    }
}
