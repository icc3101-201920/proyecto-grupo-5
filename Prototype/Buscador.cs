using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Drawing;

namespace Prototype
{
    class Buscador
    {
        private List<Filtros> filtros;
        private int id;
        private string searchterm;


        public List<Filtros> Filtros { get => filtros; set => filtros = value; }
        public int Id { get => id; set => id = value; }
        public string Searchterm { get => searchterm; set => searchterm = value; }

        public void QueryTags(int position, tag score, List<Imagen> imagep )
        {
            var taggi = from Imagen in imagep
                             where Imagen.Tags[position] == score
                             select new { dir = Imagen.Direccionmemoria };

            foreach (var item in taggi)
            {
                Console.WriteLine($"{item.dir}");
            }
        }
    }
}
