using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trybook
{
    public class Synthetic : Herramienta
    {
        public List<int> TamañosPinceles { get; set; }
        public List<string> PaletaColores { get; set; }

        public Synthetic() { }

        public override string RetornarPropiedades()
        {
            return base.RetornarPropiedades() + " " + this.TamañosPinceles.ToString() + " " + this.PaletaColores.ToString() + "N/A" + "N/A";
        }
    }
}
