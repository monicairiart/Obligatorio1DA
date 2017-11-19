using Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionActividad
{
    public class MantenimientoActividad : IModuloGestion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public object Menu { get; set; }
        public IList Acciones { get; set; }
        private static List<Actividad> actividades = new List<Actividad>();

        public MantenimientoActividad()
        {
            Nombre = "Gestion Actividad";
            Descripcion = "Alta, Baja y Modificación de Actividades";
        }
        public Actividad AltaDatosActividad(string codigoActividad, string nombreActividad, DateTime fechaActividad, int costoActividad, List<string> alumnos)
        {
            Actividad actividad = new Actividad();

            return actividad;
        }
    }
}
