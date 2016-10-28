using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dickbutt2
{
    class DrawImage
    {
        private string PathToImage = "";
        private Bitmap image;

        public DrawImage(string path)
        {
            this.PathToImage = path;
            loadImage();
        }

        private void loadImage()
        {
            image = new Bitmap(PathToImage);
        }

        public void drawImage()
        {
            int x_max = image.Width;
            int y_max = image.Height;
            Color pixel_c, prev_c = pixel_c = image.GetPixel(0,0);

            for (int i = 0; i < y_max; i++)
            {
                for (int j = 0; j < x_max; j++)
                {
                    pixel_c = image.GetPixel(j, i);

                    if(!(pixel_c.R == 255 && pixel_c.B == 255 && pixel_c.G == 255))
                    {
                        if (!pixel_c.Equals(prev_c))
                        {
                            PaintControl.changeColor(pixel_c.R, pixel_c.G, pixel_c.B);
                        }
                        Draw.dot(j, i);
                        Thread.Sleep(1);
                        prev_c = pixel_c;
                    }
                    else
                    {
                        //Thread.Sleep(100);
                    }

                    
                }
            }
        }

    }
}
