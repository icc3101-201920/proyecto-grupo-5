using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace Prototype
{
    public static class  Retoque
    {
        
        public static void AddTag (Imagen img, string text)
        {
            tag tagg = new tag();
            tagg.Name = text;
            img.Tags.Add(tagg);
        }
        public static string DIR = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\docs";
        public static Image AddText (Imagen img, string text, int X, int Y)
        {
            PointF ubicacion = new PointF(X, Y);
            string imagePath = img.Direccionmemoria;
            Bitmap bitmap = (Bitmap)Image.FromFile(imagePath);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont = new Font("Arial", 5))
                {
                    graphics.DrawString(text, arialFont, Brushes.Blue, ubicacion);

                }

                Image temp = bitmap;
                string t = Path.GetFileName(imagePath);
                temp.Save(DIR + @"\" + t);
                return temp;
            }
        }
        public static void AddRanking (Imagen img, int grade)
        {
            img.Ranking = grade;
        }

        //Creates a blank memory Bitmap having the same size dimensions as the source image
        private static Bitmap GetArgbCopy(Image sourceImage)
        {
            Bitmap bmpNew = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format32bppArgb);


            using (Graphics graphics = Graphics.FromImage(bmpNew))
            {
                graphics.DrawImage(sourceImage, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }


            return bmpNew;
        }

        // Agrega a nueva copia la matriz de color
        private static Bitmap ApplyColorMatrix(Image imag, ColorMatrix colorMatrix)
        {
            Bitmap bmp32BppSource = GetArgbCopy(imag);
            Bitmap bmp32BppDest = new Bitmap(bmp32BppSource.Width, bmp32BppSource.Height, PixelFormat.Format32bppArgb);


            using (Graphics graphics = Graphics.FromImage(bmp32BppDest))
            {
                ImageAttributes bmpAttributes = new ImageAttributes();
                bmpAttributes.SetColorMatrix(colorMatrix);

                graphics.DrawImage(bmp32BppSource, new Rectangle(0, 0, bmp32BppSource.Width, bmp32BppSource.Height),
                                    0, 0, bmp32BppSource.Width, bmp32BppSource.Height, GraphicsUnit.Pixel, bmpAttributes);


            }

            bmp32BppSource.Dispose();
            return bmp32BppDest;
        }
        public static Bitmap Trasparente(this Image imag)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
                new float[]{1, 0, 0, 0, 0},
                new float[]{0, 1, 0, 0, 0},
                new float[]{0, 0, 1, 0, 0},
                new float[]{0, 0, 0, 0.3f, 0},
                new float[]{0, 0, 0, 0, 1}
            });

            return ApplyColorMatrix(imag, colorMatrix);
        }

        public static Bitmap BW (this Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                                {
                            new float[]{.3f, .3f, .3f, 0, 0},
                            new float[]{.59f, .59f, .59f, 0, 0},
                            new float[]{.11f, .11f, .11f, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{0, 0, 0, 0, 1}
                                });


            return ApplyColorMatrix(sourceImage, colorMatrix);
        }

        public static Image AddFilter(Image img, string imgPath, int decition)
        {
            switch (decition)
            {
                case 0:
                    Bitmap bitmap = Trasparente(img);
                    Image temp = bitmap;
                    string t = Path.GetFileName(imgPath);
                    temp.Save(DIR + @"\" + t);
                    return temp;
                    break;

                case 1:
                    Bitmap bitmap1 = BW(img);
                    Image temp1 = bitmap1;
                    string t1 = Path.GetFileName(imgPath);
                    temp1.Save(DIR + @"\" + t1);
                    return temp1;
                    break;
                    
            }
        }

    }
}
