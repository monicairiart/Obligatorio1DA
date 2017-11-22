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
        private static Boolean datosGenerados = false;
        public List<Actividad> actividadesPrueba = new List<Actividad>();
        public List<Actividad> ObtenerActividades()
        {
            return actividades;
        }
        public MantenimientoActividad()
        {
            Nombre = "Gestion Actividad";
            Descripcion = "Alta, Baja y Modificación de Actividades";
        }
        public Actividad AltaDatosActividad(string codigoActividad, string nombreActividad, DateTime fechaActividad, int costoActividad, List<string> alumnos)
        {
            Actividad actividad = new Actividad();
            actividad.CodigoActividad = codigoActividad;
            actividad.Nombre = nombreActividad;
            actividad.Fecha = fechaActividad;
            actividad.Costo = costoActividad;
            actividad.Alumnos = alumnos;
            actividades.Add(actividad);
            return actividad;
        }
        public void BajarActividad(string codigoActividad)
        {
            Console.WriteLine("entra a bajar actividad");
            try
            {
                Actividad actividadAEliminar = actividades.Single(actividad => actividad.CodigoActividad == codigoActividad);
                actividades.Remove(actividadAEliminar);
                Console.WriteLine("actividad a eliminar " + actividadAEliminar.CodigoActividad);
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar actividad > " + e.ToString());
            }
        }
        public void ModificarActividad(string codigoActividad, Actividad nuevosValores)
        {
            try
            {
                Actividad actividadAModificar = actividades.Single(actividad => actividad.CodigoActividad == codigoActividad);
                int indiceDelaActividadAModificar = actividades.IndexOf(actividadAModificar);
                actividades[indiceDelaActividadAModificar].Nombre = nuevosValores.Nombre != "" ? nuevosValores.Nombre : actividadAModificar.Nombre;
                actividades[indiceDelaActividadAModificar].Alumnos = nuevosValores.Alumnos[0] != "" ? nuevosValores.Alumnos : actividadAModificar.Alumnos;
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar actividad > " + e.ToString());
            }
        }
        public Actividad ObtenerActividadPorCodigo(string codigoActividad)
        {
            Actividad actividadARetornar = actividades.Single(actividad => actividad.CodigoActividad == codigoActividad);
            return actividadARetornar;
        }
        public Boolean ActividadExistente(string codigoActividad)
        {
            Boolean actividadExistente = actividades.Exists(actividadEncontrada => actividadEncontrada.CodigoActividad == codigoActividad);
            return actividadExistente;
        }
        public void GenerarDatos()
        {
            if (!datosGenerados)
            {
                AltaDatosActividad("1", "Cine", new DateTime(2017, 01, 22), 100, new List<string>());
                AltaDatosActividad("2", "Teatro", new DateTime(2017, 10, 21), 150, new List<string>());
                AltaDatosActividad("3", "Campus", new DateTime(2017, 11, 10), 200, new List<string>());
                AltaDatosActividad("4", "Ajedrez", new DateTime(2017, 05, 23), 300, new List<string>());
                actividades = ObtenerActividades();
                actividades = AsignacionActividad.AsignarAlumnoAActividad(actividades, "50001002", "1");
                actividades = AsignacionActividad.AsignarAlumnoAActividad(actividades, "49912233", "2");
                actividades = AsignacionActividad.AsignarAlumnoAActividad(actividades, "50001002", "3");
                actividades = AsignacionActividad.AsignarAlumnoAActividad(actividades, "50001002", "2");
                actividades = AsignacionActividad.AsignarAlumnoAActividad(actividades, "38824456", "4");
                datosGenerados = true;
            }
        }
    }
}
