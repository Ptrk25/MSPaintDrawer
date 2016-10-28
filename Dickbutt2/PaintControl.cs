using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dickbutt2
{
    public class PaintControl
    {

        public enum Tools { STIFT, EIMER, PINSEL, BLEISTIFT};

        public static void setBrushSize(ushort size)
        {
            Win32.LeftClick(740, 72);
            Thread.Sleep(100);

            switch(size)
            {
                case 1:
                    Win32.LeftClick(740, 138);
                    break;
                case 2:
                    Win32.LeftClick(740, 178);
                    break;
                case 3:
                    Win32.LeftClick(740, 218);
                    break;
                case 4:
                    Win32.LeftClick(740, 258);
                    break;
            }
            
        }

        public static void changeTool(Tools tool)
        {
            switch(tool)
            {
                case Tools.STIFT:
                    Win32.LeftClick(348, 71);
                    break;
                case Tools.EIMER:
                    Win32.LeftClick(372, 71);
                    break;
                case Tools.PINSEL:
                    Win32.LeftClick(436, 102);
                    Thread.Sleep(100);
                    Win32.LeftClick(438, 139);
                    break;
                case Tools.BLEISTIFT:
                    Win32.LeftClick(436, 102);
                    Thread.Sleep(100);
                    Win32.LeftClick(559, 180);
                    break;

            }
        }

        public static void changeColor(ushort red, ushort green, ushort blue)
        {
            // Open Colorchanger
            Win32.LeftClick(1120, 75);
            Thread.Sleep(100);

            // Select Palette
            Win32.LeftClick(755, 589);
            Thread.Sleep(3);

            // ROT
            Win32.LeftClick(1162, 597);
            Thread.Sleep(3);
            SendKeys.Send("{BS}{BS}{BS}" + red);

            // GRÜN
            Thread.Sleep(1);
            Win32.LeftClick(1162, 619);
            Thread.Sleep(3);
            SendKeys.Send("{BS}{BS}{BS}" + green);

            // BLAU
            Thread.Sleep(3);
            Win32.LeftClick(1162, 642);
            Thread.Sleep(3);
            SendKeys.Send("{BS}{BS}{BS}" + blue);

            // Close Tool
            Win32.LeftClick(773, 666);
            Thread.Sleep(3);
        }

        

    }
}
