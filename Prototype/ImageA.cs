using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Prototype
{
    public class ImageA 
    {
        private Image images;
        private List<tag> tags;


        
        public ImageA()
        {

        }
        

        public List<tag> Tags { get => tags; set => tags = value; }
        public Image Images { get => images; set => images = value; }
    }
}
