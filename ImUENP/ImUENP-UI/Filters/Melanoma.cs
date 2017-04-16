using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using ImUENP.UI.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Filters
{
    class Melanoma
    {
        public Bitmap ProcessMelanoma(Bitmap img)
        {
            Bitmap imagem = (Bitmap)img.Clone();

            //var img1 = hslFiltering(imagem);
            var img2 = grayScale(imagem);
            var img3 = binary(img2);
            var img4 = openingFilter(img3);
            var img5 = noiseFilter(img4);

            return img5;

        }
        /*public Bitmap hslFiltering(Bitmap img)
        {
            var imagem = RGBImage.FromImage(img);
            
            for(int i = 0; i < imagem.Width; i++)
            {
                for(int j = 0; j < imagem.Height; i++)
                {
                    var im = imagem.GetPixel(i, j);

                    AForge.Imaging.RGB rgb = new AForge.Imaging.RGB(im.R, im.G, im.B);
                    
                }
            }


        }*/
        public Bitmap grayScale(Bitmap img)
        {
            Bitmap imagem = (Bitmap)img.Clone();

            var gray =  Grayscale.CommonAlgorithms.Y.Apply(imagem);
           
            return gray;
        }
        public Bitmap binary(Bitmap img)
        {
            Bitmap imagem = (Bitmap)img.Clone();
            Threshold t = new Threshold();
            var binary =  t.Apply(imagem);

            return binary;
        }
        public Bitmap openingFilter(Bitmap img)
        {
            Bitmap imagem = (Bitmap)img.Clone();

            Opening filtro = new Opening();
            filtro.ApplyInPlace(imagem, new Rectangle(0,0,imagem.Width,imagem.Height));

            return imagem;
        }
        public Bitmap noiseFilter(Bitmap img)
        {
            Bitmap imagem = (Bitmap)img.Clone();

            AdditiveNoise addN = new AdditiveNoise();
            var noise = addN.Apply(imagem);

            return noise;
        }
    }
}
