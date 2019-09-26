using System;
using System.Collections.Generic;
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


    }
}
