using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Filtros
    {
        private List<string> caracteristicas;
        private List<Persona> personas;
        private List<tag> tags;
        private List<Imagen> fotos;


        public Filtros(List<string> caracteristicas, List<Persona> personas, List<tag> tags, List<Imagen> fotos)
        {
            this.caracteristicas = caracteristicas;
            this.personas = personas;
            this.tags = tags;
            this.fotos = fotos;
        }

        public List<string> Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public List<Persona> Personas { get => personas; set => personas = value; }
        public List<tag> Tags { get => tags; set => tags = value; }
        public List<Imagen> Fotos { get => fotos; set => fotos = value; }




        public Imagen agregarBusqueda(Imagen foto, List<Imagen> busqueda)
        {
            foreach (Imagen im in busqueda)
            {
                if (im == foto)
                {
                    return im;
                }
                else
                {
                    Console.WriteLine("No se pudo encontrar la imagen");
                }
            }
            return null;
        }
    }
}
