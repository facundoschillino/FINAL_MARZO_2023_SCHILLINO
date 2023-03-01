using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trybook
{ 
    public class Usuario
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public List<Proyecto> ProyectosUsuario  { get; set; }
        public bool VIP { get; set; }

    }
}
