using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dickbutt2
{
    class Stage
    {
        public static void openMSPaint()
        {
            System.Diagnostics.Process.Start("mspaint.exe");
            Thread.Sleep(500);
        }

    }
}
