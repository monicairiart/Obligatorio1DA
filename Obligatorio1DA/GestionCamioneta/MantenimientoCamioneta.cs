using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Collections;

namespace GestionCamioneta
{
    public class MantenimientoCamioneta : IModuloGestion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public object Menu { get; set; }
        public IList Acciones { get; set; }
        private List<Camioneta> camionetas = new List<Camioneta>();
        public List<Camioneta> ObtenerCamionetas()
        {
            return camionetas;
        }
        public MantenimientoCamioneta()
        {
            Console.WriteLine();
            Nombre = "Gestion Camioneta";
            Descripcion = "Alta, Baja y Modificación de Camionetas";
        }
        public Camioneta AltaDatosCamioneta(string matriculaCamioneta, int capacidadCamioneta, string estadoCamioneta, List<string> viajes)
        {
            Camioneta camioneta = new Camioneta();
            camioneta.Matricula = matriculaCamioneta;
            camioneta.Capacidad = capacidadCamioneta;
            camioneta.Estado = estadoCamioneta;
            camionetas.Add(camioneta);
            return camioneta;
        }
        public void ModificarCamioneta(string matricula, Camioneta nuevosValores)
        {
            try
            {
                Camioneta camionetaAModificar = camionetas.Single(camioneta => camioneta.Matricula == matricula);
                int indiceDelaCamionetaAModificar = camionetas.IndexOf(camionetaAModificar);
                camionetas[indiceDelaCamionetaAModificar].Matricula = nuevosValores.Matricula != "" ? nuevosValores.Matricula : camionetaAModificar.Matricula;
                camionetas[indiceDelaCamionetaAModificar].Capacidad = nuevosValores.Capacidad != 0 ? nuevosValores.Capacidad : camionetaAModificar.Capacidad;
                camionetas[indiceDelaCamionetaAModificar].Estado = nuevosValores.Estado != "" ? nuevosValores.Estado : camionetaAModificar.Estado;
                camionetas[indiceDelaCamionetaAModificar].Viajes = nuevosValores.Viajes[0] != "" ? nuevosValores.Viajes : camionetaAModificar.Viajes;
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar materia > " + e.ToString());
            }
        }
    }
}
