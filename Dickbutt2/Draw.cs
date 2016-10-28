using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dickbutt2
{
    class Draw
    {

        private static readonly int S_POS_X = 5;
        private static readonly int S_POS_Y = 144;

        public static void goToStart()
        {
            Win32.SetCursorPos(S_POS_X, S_POS_Y);
        }

        public static void goToPaintPos(int x, int y)
        {
            x += S_POS_X;
            y += S_POS_Y;

            Win32.SetCursorPos(x, y);
        }

        public static void line(int x, int y, int x2, int y2)
        {
            goToPaintPos(x, y);
            Win32.LeftHold();
            Win32.SetCursorPos(x2+S_POS_X, y2+S_POS_Y);
            Win32.LeftRelease();
        }

        public static void dot(int x, int y)
        {
            Win32.LeftClick(x+S_POS_X,y+S_POS_Y);
        }

        public static void moveX(int x)
        {
            x += S_POS_X;

            Win32.POINT p;
            Win32.GetCursorPos(out p);

            //x += p.X;

            while (p.X > x+1)
            {
                Win32.GetCursorPos(out p);
                Win32.SetCursorPos(p.X - 1, p.Y);
                Thread.Sleep(2);
            }

            while (p.X < x -1)
            {
                Win32.GetCursorPos(out p);
                Win32.SetCursorPos(p.X + 1, p.Y);
                Thread.Sleep(2);
            }

        }

        public static void moveY(int y)
        {
            y += S_POS_Y;

            Win32.POINT p;
            Win32.GetCursorPos(out p);

            //y += p.Y;

            while (p.Y > y + 1)
            {
                Win32.GetCursorPos(out p);
                Win32.SetCursorPos(p.X, p.Y - 649);
                //Thread.Sleep(0);
            }

            while (p.Y < y - 1)
            {
                Win32.GetCursorPos(out p);
                Win32.SetCursorPos(p.X, p.Y + 649);
                //Thread.Sleep(0);
            }

        }


    }
}
