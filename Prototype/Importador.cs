using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;


namespace Prototype
{
    public static class Importador
    {
        public static string DIR= Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\image";
        public static Image import(string Paths)
        {
            
            Image temp = Image.FromFile(Paths);
            string t = Path.GetFileName(Paths);
            temp.Save(DIR + @"\" + t);
            return temp;

        }
        public static Imagen Tagger(Image ima)
        {
            List<tag> tagg = new List<tag>();
            tag tagger = new tag();
            tagger.Name = "Importado a " + DIR;
            //Console.WriteLine(tagger.Name);//
            Imagen temp = new Imagen();
            temp.Image = ima;
            tagg.Add(tagger);
            temp.Tags = tagg;
            IOUser.ConsoleOutput("imported image has been tagged");
            return temp;
        }

    }
}
