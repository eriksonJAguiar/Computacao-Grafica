using ImUENP.UI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Filters
{

    public struct RGBMM
    {
        public List<int> R;
        public List<int> G;
        public List<int> B;

        public void constructor()
        {
            R = new List<int>();
            G = new List<int>();
            B = new List<int>();
        }

        public void getRGB(int r, int g, int b)
        {
            R.Add(r);
            G.Add(g);
            B.Add(b);
        }
    }
    class MediaMediana
    {
        public RGBImage media(RGBImage img)
        {
            RGBImage image = (RGBImage)img.Clone();


            for (int i = 1; i < image.Width-1; i++)
            {
                for (int j = 1; j < image.Height-1; j++)
                {

                    RGBMM rgb = new RGBMM();
                    rgb.constructor();

                    rgb.getRGB(image.GetPixel(i, j).R, image.GetPixel(i, j).G, image.GetPixel(i, j).B);
                    rgb.getRGB(image.GetPixel(i + 1, j).R, image.GetPixel(i + 1, j).G, image.GetPixel(i + 1, j).B);
                    rgb.getRGB(image.GetPixel(i - 1, j).R, image.GetPixel(i - 1, j).G, image.GetPixel(i - 1, j).B);
                    rgb.getRGB(image.GetPixel(i, j + 1).R, image.GetPixel(i, j + 1).G, image.GetPixel(i, j + 1).B);
                    rgb.getRGB(image.GetPixel(i, j - 1).R, image.GetPixel(i, j - 1).G, image.GetPixel(i, j - 1).B);
                    rgb.getRGB(image.GetPixel(i, j - 1).R, image.GetPixel(i, j - 1).G, image.GetPixel(i, j - 1).B);
                    rgb.getRGB(image.GetPixel(i - 1, j - 1).R, image.GetPixel(i - 1, j - 1).G, image.GetPixel(i - 1, j - 1).B);
                    rgb.getRGB(image.GetPixel(i + 1, j + 1).R, image.GetPixel(i + 1, j + 1).G, image.GetPixel(i + 1, j + 1).B);
                    rgb.getRGB(image.GetPixel(i + 1, j - 1).R, image.GetPixel(i + 1, j - 1).G, image.GetPixel(i + 1, j - 1).B);



                    int medR = (int)rgb.R.Average();
                    int medG = (int)rgb.G.Average();
                    int medB = (int)rgb.B.Average();

                    image.SetPixel(i, j, new RGB((byte)medR, (byte)medG, (byte)medB));
                }
            }
            return image;
        }
        public RGBImage mediana(RGBImage img)
        {
            RGBImage image = (RGBImage)img.Clone();


            for (int i = 1; i < image.Width-1; i++)
            {
                for (int j = 1; j < image.Height-1; j++)
                {

                    RGBMM rgb = new RGBMM();
                    rgb.constructor();

                    rgb.getRGB(image.GetPixel(i, j).R, image.GetPixel(i, j).G, image.GetPixel(i, j).B);
                    rgb.getRGB(image.GetPixel(i + 1, j).R, image.GetPixel(i + 1, j).G, image.GetPixel(i + 1, j).B);
                    rgb.getRGB(image.GetPixel(i - 1, j).R, image.GetPixel(i - 1, j).G, image.GetPixel(i - 1, j).B);
                    rgb.getRGB(image.GetPixel(i, j + 1).R, image.GetPixel(i, j + 1).G, image.GetPixel(i, j + 1).B);
                    rgb.getRGB(image.GetPixel(i, j - 1).R, image.GetPixel(i, j - 1).G, image.GetPixel(i, j - 1).B);
                    rgb.getRGB(image.GetPixel(i, j - 1).R, image.GetPixel(i, j - 1).G, image.GetPixel(i, j - 1).B);
                    rgb.getRGB(image.GetPixel(i - 1, j - 1).R, image.GetPixel(i - 1, j - 1).G, image.GetPixel(i - 1, j - 1).B);
                    rgb.getRGB(image.GetPixel(i + 1, j + 1).R, image.GetPixel(i + 1, j + 1).G, image.GetPixel(i + 1, j + 1).B);
                    rgb.getRGB(image.GetPixel(i + 1, j - 1).R, image.GetPixel(i + 1, j - 1).G, image.GetPixel(i + 1, j - 1).B);


                    int par = rgb.R.Count;
                    int val = (int)par / 2;
                    rgb.R.Sort();
                    rgb.G.Sort();
                    rgb.B.Sort();

                    int medianR;
                    int medianG;
                    int medianB;

                    if ((par%2) == 0)
                    {
                        medianR = (rgb.R[val] + rgb.R[val + 1]) / 2;
                        medianG = (rgb.G[val] + rgb.G[val + 1]) / 2;
                        medianB = (rgb.B[val] + rgb.B[val + 1]) / 2;
                    }
                    else
                    {
                        medianR = rgb.R[val];
                        medianG = rgb.G[val];
                        medianB = rgb.B[val];
                    }

                    

                    image.SetPixel(i, j, new RGB((byte)medianR, (byte)medianG, (byte)medianB));

                }
            }
            return image;
        }
    }
}
