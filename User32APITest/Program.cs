using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using ImageLink.Helper;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;

namespace User32APITest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            while (true) 
            {
                //Thread.sl
                Clipboard.SetText("Hello, clipboard");
            }
        }
    }
}
