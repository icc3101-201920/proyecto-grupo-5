using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class File
    {
        private string nombre;
        private string direccionmemoria;

        public File(string nombre,string direccionmemoria)
        {
            this.direccionmemoria = direccionmemoria;
            this.nombre = nombre;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccionmemoria { get => direccionmemoria; set => direccionmemoria = value; }


    }
}
