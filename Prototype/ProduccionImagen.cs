using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Prototype
{
    public static class ProduccionImagen
    {
        //private List<Imagen> imagenes;//
        //private string color;//

        /*public ProduccionImagen(List<Imagen> imagenes, string color)
        {
            this.imagenes = imagenes;
            this.color = color;
        }*/

        //public List<Imagen> Imagenes { get => imagenes; set => imagenes = value; }//
        //public string Color { get => color; set => color = value; }//

       

        public static Image fusion(Image Imagen1,Image Imagen2)
        {
            Bitmap bmp1 = new Bitmap(Imagen1);
            Bitmap bmp2 = new Bitmap(Imagen2);
            
            int with1 = bmp1.Width;
            int height1 = bmp1.Height;
            int with2 = bmp2.Width;
            int height2 = bmp2.Height;
            Color p;
            Color p2;

            for (int y = 0; y < height1; y++)
            {
                for (int x = 0; x < with1; x++)
                {
                    p = bmp1.GetPixel(x, y);
                    p2 = bmp2.GetPixel(x, y);

                    int a = p.A;
                    int b = p.B;
                    int r = p.R;
                    int g = p.G;

                    int a2 = p2.A;
                    int b2 = p2.B;
                    int r2 = p2.R;
                    int g2 = p2.G;

                    int avga = (a + a2) / 2;
                    int avgb = (b + b2) / 2;
                    int avgr = (r + r2) / 2;
                    int avgg = (g + g2) / 2;
                    Color Result = Color.FromArgb(avga, avgb, avgr, avgg);
                    bmp1.SetPixel(x, y,Result);
                }
            }
            Image bmpT = bmp1;
            return bmpT;

           

        }

    }

}
