using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePDI
{
    class Program
    {
        static void Main(string[] args)
        {
          Bitmap b = new Bitmap(@"C:\Users\eriks\Documents\GitHub Projects\Computacao-Grafica\TestePDI\TestePDI\img\geraldo.jpg");
          Bitmap b2 = new Bitmap(@"C:\Users\eriks\Documents\GitHub Projects\Computacao-Grafica\TestePDI\TestePDI\img\geraldo.jpg");
          Bitmap b3 = new Bitmap(@"C:\Users\eriks\Documents\GitHub Projects\Computacao-Grafica\TestePDI\TestePDI\img\geraldo.jpg");
            //captura pixel
            Color c = b.GetPixel(0, 0);

            //imprimindo o valor RGB das cores
            Console.WriteLine(c.R);
            Console.WriteLine(c.G);
            Console.WriteLine(c.B);

            

            //set com vermelho nos pixels da diagonal
            for (int i = 0; i < b.Width; i++)
            {
                for(int j = 0; j < b.Height; j++)
                {
                    if(i == j)
                        b.SetPixel(j, i, Color.Red);    
                }
            }

            //salva nova imagem com os pixels em vermelho
            b.Save(@"C:\Users\eriks\Documents\GitHub Projects\Computacao-Grafica\TestePDI\TestePDI\img\geraldo2.jpg");

            //Deixa em Scala de Cinza
            for (int i = 0; i < b2.Width; i++)
            {
                for (int j = 0; j < b2.Height; j++)
                {
                    Color corOriginal = b2.GetPixel(i, j);

                    int scalaCinza = (int)((corOriginal.R * 0.3) + (corOriginal.G * 0.59) + (corOriginal.B * 0.11));

                    Color corScalar = Color.FromArgb(scalaCinza, scalaCinza, scalaCinza);

                    b2.SetPixel(i, j, corScalar);
                }
            }

            b2.Save(@"C:\Users\eriks\Documents\GitHub Projects\Computacao-Grafica\TestePDI\TestePDI\img\geraldo3.jpg");

            //Deixa em Scala de Cinza
            for (int i = 0; i < b3.Width; i++)
            {
                for (int j = 0; j < b3.Height; j++)
                {
                    Color corOriginal = b3.GetPixel(i, j);


                    Color CorEmNegativo = Color.FromArgb(255-corOriginal.R,255-corOriginal.G,255-corOriginal.B);

                    b2.SetPixel(i, j, CorEmNegativo);
                }
            }

            b2.Save(@"C:\Users\eriks\Documents\GitHub Projects\Computacao-Grafica\TestePDI\TestePDI\img\geraldo4.jpg");

            Console.WriteLine("Fim do Processamento");
            Console.ReadKey();
        }
    }
}
