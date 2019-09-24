using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class NormalTag:tag
    {
        private Persona[] personas;
        private Archivo foto;

        public NormalTag(Persona[] personas,Archivo foto,string name) : base(name)
        {
            this.personas = personas;
            this.foto = foto;
            
        }
        
        
    }
}
