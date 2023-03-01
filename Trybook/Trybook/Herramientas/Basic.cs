using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trybook
{
    public class Basic:Herramienta
    {
        public List<string> PaletaColores { get; set; }
        public List<int> Tamaños { get; set; }
        public TiposHerramientas Tipo { get; set; }

        public Basic() { }
        public override string RetornarPropiedades()
        {
            return base.RetornarPropiedades() + " " + this.Tamaños.ToString() + " " + this.PaletaColores.ToString() + " N/A" + "N/A";
        }
    }
}
