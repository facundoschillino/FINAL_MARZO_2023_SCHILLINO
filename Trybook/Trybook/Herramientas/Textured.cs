using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trybook
{
    public class Textured : Herramienta
    {
        public TiposTexturas tipotexturas { get; set; }
        public List<int> Tamaños { get; set; }

        public Textured () { }

        public override string RetornarPropiedades()
        {
            return base.RetornarPropiedades() + "N/A   " + this.Tamaños.ToString() + " N/A " + this.tipotexturas.ToString() + "N/A"; 
        }
    }
}
