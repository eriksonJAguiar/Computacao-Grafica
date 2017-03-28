using ImUENP.UI.Filters;
using System;
using System.Collections.Generic;
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

                    if (m >= 0 && m <= 63)
                    {
                        image.SetPixel(i, j, new RGB(51, 255, 51));
                    }
                    if (m >= 64 && m <= 127)
                    {
                        image.SetPixel(i, j, new RGB(0, 0, 255));
                    }
                    if (m >= 127 && m <= 191)
                    {
                        image.SetPixel(i, j, new RGB(238, 255, 50));
                    }
                    if (m >= 192 && m <= 255)
                    {
                        image.SetPixel(i, j, new RGB(102, 0, 102));
                    }

                }
            }
            return image;
        }
    }
}

