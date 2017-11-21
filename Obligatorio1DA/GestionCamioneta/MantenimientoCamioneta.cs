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
        private static List<Camioneta> camionetas = new List<Camioneta>();
        private static Boolean datosGenerados = false;
        public List<Camioneta> camionetasPrueba = new List<Camioneta>();

        public List<Camioneta> ObtenerCamionetas()
        {
            return camionetas;
        }
        public MantenimientoCamioneta()
        {
            Console.WriteLine();
            Nombre = "Gestion Camioneta";
            Descripcion = "Alta, Baja y Modificación de Camionetas";
            //GenerarDatos();
        }
        public Camioneta AltaDatosCamioneta(string matriculaCamioneta, int capacidadCamioneta, string estadoCamioneta, List<string> alumnos)
        {
            Camioneta camioneta = new Camioneta();
            if (!CamionetaExistente(matriculaCamioneta))
            {
                camioneta.Matricula = matriculaCamioneta;
                camioneta.Capacidad = capacidadCamioneta;
                camioneta.Estado = estadoCamioneta;
                camioneta.Alumnos = alumnos;
                camionetas.Add(camioneta);
            }
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
                camionetas[indiceDelaCamionetaAModificar].Alumnos = nuevosValores.Alumnos[0] != "" ? nuevosValores.Alumnos : camionetaAModificar.Alumnos;
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar materia > " + e.ToString());
            }
        }
        public void BajarCamioneta(string matricula)
        {
            try
            {
                Camioneta camionetaAEliminar = camionetas.Single(camioneta => camioneta.Matricula == matricula);
                camionetas.Remove(camionetaAEliminar);
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar materia > " + e.ToString());
            }
        }

        public Camioneta ObtenerCamionetaPorMatricula(string matricula)
        {
            Camioneta camionetaARetornar = camionetas.Single(camioneta => camioneta.Matricula == matricula);
            return camionetaARetornar;
        }
        public Boolean CamionetaExistente(string matricula)
        {
            Boolean camionetaExistente = camionetas.Exists(camionetaEncontrada => camionetaEncontrada.Matricula == matricula);
            return camionetaExistente;
        }
        public void GenerarDatos()
        {
            if (!datosGenerados)
            {
                camionetasPrueba.Add(AltaDatosCamioneta("SAF3685", 40, "Disponible", new List<string>()));
                camionetasPrueba.Add(AltaDatosCamioneta("SAF3688", 30, "No Disponible", new List<string>()));
                camionetasPrueba.Add(AltaDatosCamioneta("SAA3600", 20, "Disponible", new List<string>()));
                camionetas = ObtenerCamionetas();
                camionetas = AsignacionCamioneta.AsignarAlumnoACamioneta(camionetas, "50001002", "SAF3685");
                camionetas = AsignacionCamioneta.AsignarAlumnoACamioneta(camionetas, "49912233", "SAF3688");
                datosGenerados = true;
            }
        }
    }
}
