using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static Dickbutt2.PaintControl;

namespace Dickbutt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(0, 0);

            Stage.openMSPaint();
            PaintControl.changeTool(Tools.STIFT);
            Thread.Sleep(100);
            //PaintControl.setBrushSize(1);

            DrawImage di = new DrawImage("C:/Users/Patrick/Desktop/test1.png");
            di.drawImage();

            Environment.Exit(0);
        }
    }
}
