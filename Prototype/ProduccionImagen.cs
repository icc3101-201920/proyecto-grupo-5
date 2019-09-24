using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class ProduccionImagen
    {
        private List<Imagen> imagenes;
        private string color;

        public ProduccionImagen(List<Imagen> imagenes, string color)
        {
            this.imagenes = imagenes;
            this.color = color;
        }

        public List<Imagen> Imagenes { get => imagenes; set => imagenes= value; }
        public string Color { get => color; set => color = value; }

    }
}
