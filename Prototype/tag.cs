using System;
using System.Collections.Generic;
using System.Text;



namespace Prototype
{
    public class tag
    {
        private string name;

        public tag(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

    }
    
}

