using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Prototype
{
    public static class ProduccionImagen
    {
        public static string DIR = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\docs";
        public static Image MakeFusion(Image Imagen1, Image Imagen2, string PathImg1, string PathImg2)
        {
            Bitmap bmp1 = new Bitmap(Imagen1);
            Bitmap bmp2 = new Bitmap(Imagen2);
            int w1 = bmp1.Width;
            int h1 = bmp1.Height;
            int w2 = bmp2.Width;
            int h2 = bmp2.Height;

            int z1 = w1 * h1;
            int z2 = w2 * h2;

            Color p;
            Color p2;

            if (w1 <= w2 && h1 <= h2)
            {
                for (int y = 0; y < h1; y++)
                {
                    for (int x = 0; x < w1; x++)
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

                        bmp1.SetPixel(x, y, Color.FromArgb(avga, avgb, avgr, avgg));
                    }
                }
                Image temp = bmp1;
                string t = Path.GetFileName(PathImg1);
                temp.Save(DIR + @"\" + t);
                return temp;
            }
            else if (w1 <= w2 && h1 >= h2 && z1 < z2)
            {
                for (int y = 0; y < h2; y++)
                {
                    for (int x = 0; x < w1; x++)
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

                        bmp1.SetPixel(x, y, Color.FromArgb(avga, avgb, avgr, avgg));
                    }
                }
                Image temp = bmp1;
                string t = Path.GetFileName(PathImg1);
                temp.Save(DIR + @"\" + t);
                return temp;
            }
            else if (w1 <= w2 && h1 >= h2 && z1 > z2)
            {
                for (int y = 0; y < h2; y++)
                {
                    for (int x = 0; x < w1; x++)
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

                        bmp2.SetPixel(x, y, Color.FromArgb(avga, avgb, avgr, avgg));
                    }
                }
                Image temp = bmp2;
                string t = Path.GetFileName(PathImg1);
                temp.Save(DIR + @"\" + t);
                return temp;
            }
            else if (w1 >= w2 && h1 <= h2 && z1 < z2)
            {
                for (int y = 0; y < h1; y++)
                {
                    for (int x = 0; x < w2; x++)
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

                        bmp1.SetPixel(x, y, Color.FromArgb(avga, avgb, avgr, avgg));
                    }
                }
                Image temp = bmp1;
                string t = Path.GetFileName(PathImg1);
                temp.Save(DIR + @"\" + t);
                return temp;
            }
            else if (w1 >= w2 && h1 <= h2 && z1 > z2)
            {
                for (int y = 0; y < h1; y++)
                {
                    for (int x = 0; x < w2; x++)
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

                        bmp2.SetPixel(x, y, Color.FromArgb(avga, avgb, avgr, avgg));
                    }
                }
                Image temp = bmp2;
                string t = Path.GetFileName(PathImg1);
                temp.Save(DIR + @"\" + t);
                return temp;
            }
            else
            {
                for (int y = 0; y < h2; y++)
                {
                    for (int x = 0; x < w2; x++)
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

                        bmp2.SetPixel(x, y, Color.FromArgb(avga, avgb, avgr, avgg));
                    }
                }
                Image temp = bmp2;
                string t = Path.GetFileName(PathImg2);
                temp.Save(DIR + @"\" + t);
                return temp;
            }

        }


    }

}
