using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Retoque
    {
        private Imagen edicion;

        public Retoque (Imagen edicion)
        {
            this.edicion = edicion;
        }

        public Imagen Edicion { get => edicion; set => edicion = value; }

    }
}
