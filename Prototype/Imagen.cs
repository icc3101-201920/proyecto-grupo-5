using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Prototype
{
    class Imagen:Archivo
    {
        private Image image;
        private int id, ranking;
        private List<tag> tags, personas;
        private string fecha, camara, resolucion, saturacion, relacionaspecto, genero;
        private bool favorito;

        public Imagen(string nombre,string direccionmemoria, int id, int ranking, List<tag> tags, List<tag> personas, string fecha, string camara, string resolucion, string saturacion, string relacionaspecto, string genero, bool favorito):base(nombre, direccionmemoria)
        {
            this.id = id;
            this.ranking = ranking;
            this.tags = tags;
            this.personas = personas;
            this.fecha = fecha;
            this.camara = camara;
            this.resolucion = resolucion;
            this.saturacion = saturacion;
            this.relacionaspecto = relacionaspecto;
            this.genero = genero;
            this.favorito = favorito;
        }
        public Imagen(string nombre, string direccionmemoria):base(nombre, direccionmemoria)
        {

        }

        public Image Image { get => image; set => image = value; }

        public List<tag> Tags { get => tags; set => tags = value; }
        public List<tag> Personas { get => personas; set => personas = value; }
        public int Raning { get => ranking; set => ranking = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Camara { get => camara; set => camara = value; }
        public string Resolucion { get => resolucion; set => resolucion = value; }
        public string Saturacion { get => saturacion; set => saturacion = value; }
        public string Realcionaspecto{ get => relacionaspecto; set => relacionaspecto = value; }
        public string Genero { get => genero; set => genero = value; }
        public bool Favorito { get => favorito; set => favorito = value; }
    }
}
