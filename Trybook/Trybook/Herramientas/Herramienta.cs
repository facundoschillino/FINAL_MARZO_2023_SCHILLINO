using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trybook
{
    public abstract class Herramienta
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Premium { get; set; }
        public bool Beta { get; set; }

        public virtual string RetornarPropiedades()
        {
            return (this.Codigo.ToString() + " " + this.Nombre + " " + this.Premium.ToString());
        }
    }
}
