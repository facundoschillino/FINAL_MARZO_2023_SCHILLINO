using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trybook
{
    public class Proyecto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public Plantillas plantilla { get; set; }
        public List<Herramienta> HistorialHerramientas { get; set; }

        public Proyecto() { }
    }
}
