using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Buscador
    {
        private List<Filtros> filtros;

        public List<Filtros> Filtros { get => filtros; set => filtros = value; }
    }
}
