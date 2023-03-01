using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trybook
{
    public class Logica
    {
        public List<Usuario> Usuarios = new List<Usuario>();
        public List<Herramienta> Herramientas = new List<Herramienta>();

        public void CrearProyecto(int NumeroUsuario, string Nombre, Plantillas Plantilla)
        {
            Proyecto proyecto = new Proyecto();
            proyecto.Nombre = Nombre;
            proyecto.plantilla = Plantilla;

            int index = Usuarios.FindIndex(x => x.Codigo == NumeroUsuario);
            proyecto.Codigo = Usuarios[index].ProyectosUsuario.Count() + 1;
            Usuarios[index].ProyectosUsuario.Add(proyecto);
            

        }
        public List<ReturnHerramientas> HerramientasDiponibles(int NroUsuario)
        {
            List<ReturnHerramientas> Lista = new List<ReturnHerramientas>();
            int index = Usuarios.FindIndex(x => x.Codigo == NroUsuario);
            if (index > 0)
            {
                if (Usuarios[index].VIP)
                {

                    foreach (Herramienta herramienta1 in Herramientas)
                    {
                        ReturnHerramientas herramientanueva = new ReturnHerramientas();
                        herramientanueva.Codigo = herramienta1.Codigo.ToString();
                        herramientanueva.Nombre = herramienta1.Nombre;
                        herramientanueva.Habilitada = "Si";
                        herramientanueva.TextoAdicional = null;
                        Lista.Add(herramientanueva);
                    }
                }
                else
                {
                    foreach (Herramienta herramienta1 in Herramientas)
                    {
                        ReturnHerramientas herramientanueva = new ReturnHerramientas();
                        herramientanueva.Codigo = herramienta1.Codigo.ToString();
                        herramientanueva.Nombre = herramienta1.Nombre;
                        if (herramienta1.Premium)
                        {
                            herramientanueva.Habilitada = "No";
                            herramientanueva.TextoAdicional = "Si ud desea usar esta herramienta debe adquirir Trybook premium";
                        }
                        else
                        {
                            herramientanueva.Habilitada = "Si";
                        }
                        Lista.Add(herramientanueva);
                    }
                }
            }
            return Lista;
        }
        public ReturnBoolString HabilitacionHerramienta(int CodigoHerramienta, int NroUsuario, int NroProyecto)
        {
            int indexuser = Usuarios.FindIndex(x => x.Codigo == NroUsuario);
            int indexherramienta = Herramientas.FindIndex(x => x.Codigo == CodigoHerramienta);
            if (Usuarios[indexuser].VIP)
            {              
                int indiceProyectos = Usuarios[indexuser].ProyectosUsuario.FindIndex(x => x.Codigo == NroProyecto);
                Usuarios[indexuser].ProyectosUsuario[indiceProyectos].HistorialHerramientas.Add(Herramientas[indexherramienta]);
                ReturnBoolString retorno = new ReturnBoolString(true, "Realizado");
                return retorno;

            }
            else if (Herramientas[indexherramienta].Premium)
            {
                ReturnBoolString retorno = new ReturnBoolString(false, "No se pudo cargar la herramienta ya que el usuario no es premium");
                return retorno;
            }
            else
            {
                int indiceProyectos = Usuarios[indexuser].ProyectosUsuario.FindIndex(x => x.Codigo == NroProyecto);
                Usuarios[indexuser].ProyectosUsuario[indiceProyectos].HistorialHerramientas.Add(Herramientas[indexherramienta]);
                ReturnBoolString retorno = new ReturnBoolString(true, "Realizado");
                return retorno;
            }
            
        }
        public List<string> GenerarDescripcionesHerramientas()
        {
            List<string> retorno = new List<string>();
            foreach (Legacy legacy in Herramientas)
            {
                retorno.Add(legacy.RetornarPropiedades());
            }
            foreach (Synthetic synthetic in Herramientas)
            {
                retorno.Add(synthetic.RetornarPropiedades());
            }
            foreach ( Basic basic in Herramientas)
            {
                retorno.Add(basic.RetornarPropiedades());
            }
            foreach (Textured textures in Herramientas)
            {
                retorno.Add(textures.RetornarPropiedades());
            }
            return retorno;
        }
        
        
        

    }
}
