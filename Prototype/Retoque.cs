using System;
using System.Collections.Generic;
using System.Drawing;
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


    }
}
