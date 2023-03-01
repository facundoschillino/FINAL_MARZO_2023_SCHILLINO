using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trybook
{
    public class Legacy:Herramienta
    {
        public List<int> Tamaños { get; set; }
        public string RecomendacionUso { get; set; }
        public  string CrearDescripcion()
        {       
            return "Recomendado para Ilustracion de fotos";
        }
        

        public Legacy() { }
        public override string RetornarPropiedades()
        {
            return (base.RetornarPropiedades() + this.Tamaños.ToString() + "N/A " + "N/A "+ this.RecomendacionUso);
        }
    }
}
