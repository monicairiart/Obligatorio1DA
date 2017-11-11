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
        public List<Camioneta> GetCamionetas()
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
    }
}
