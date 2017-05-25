using ImUENP.UI.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Filters
{
    class ThreeShold
    {
        public RGBImage Process(RGBImage img)
        {
            RGBImage image = (RGBImage)img.Clone();
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var p = image.GetPixel(i, j);
                    if (p.R <= 127)
                    {
                        image.SetPixel(i, j, new RGB(0, 0, 0));
                    }
                    else
                    {
                        image.SetPixel(i, j, new RGB(255, 255, 255));
                    }

                }
            }
            return image;
        }
        public RGBImage Process2(RGBImage img)
        {
            RGBImage image = (RGBImage)img.Clone();
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var p = image.GetPixel(i, j);
                    if (p.R <= 127 || p.G <= 127 || p.B <= 127)
                    {
                        image.SetPixel(i, j, new RGB(0, 0, 0));
                    }
                    else
                    {
                        image.SetPixel(i, j, new RGB(255, 255, 255));
                    }

                }
            }
            return image;
        }
        public RGBImage ProcessMulti(RGBImage img)
        {
            RGBImage image = (RGBImage)img.Clone();

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var p = image.GetPixel(i, j);

                    int m = (int)(p.R + p.G + p.B) / 3;

                    if (m >= 0 && m <= 84)
                    {
                        image.SetPixel(i, j, new RGB(0,0,0));
                    }
                    if (m >= 85 && m <= 169)
                    {
                        image.SetPixel(i, j, new RGB(255, 255, 50));
                    }
                    if (m >= 170 && m <= 255)
                    {
                        image.SetPixel(i, j, new RGB(255,255,255));
                    }
                    

                }
            }
            return image;
        }
    }
}

