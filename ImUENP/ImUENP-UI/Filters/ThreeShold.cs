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

            var pixVal = image.Height / 3;


            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    var p = image.GetPixel(i, j);
                    
                    if (i < pixVal)
                    {
                        var r = (int)p.R * 0.09;
                        var g = (int)p.G * 0.8;
                        var b = (int)p.B * 0.11;
                        image.SetPixel(i, j, new RGB((byte)r,(byte)g,(byte)b));
                    }
                    else if(i < (pixVal * 3)){

                        var r = (int)p.R * 0.8;
                        var g = (int)p.G * 0.09;
                        var b = (int)p.B * 0.11;
                        image.SetPixel(i, j, new RGB((byte)r, (byte)g, (byte)b));

                    }
                    else if (i < ((pixVal * 3)*3))
                    {
                        var r = (int)p.R * 0.11;
                        var g = (int)p.G * 0.09;
                        var b = (int)p.B * 0.8;
                        image.SetPixel(i, j, new RGB((byte)r, (byte)g, (byte)b));
                    }
                    

                }
            }
            return image;
        }
    }
}

