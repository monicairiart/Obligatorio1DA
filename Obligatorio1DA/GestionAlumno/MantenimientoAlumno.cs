using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Collections;

namespace GestionAlumno
{
    public class MantenimientoAlumno : IModuloGestion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public object Menu { get; set; }
        public IList Acciones { get; set; }
        private static List<Alumno> alumnos = new List<Alumno>();
        public List<Alumno> alumnosPrueba = new List<Alumno>();
        public List<Alumno> ObtenerAlumnos()
        {
            return alumnos;
        }
        public MantenimientoAlumno()
        {
            Nombre = "Gestion Alumno";
            Descripcion = "Alta, Baja y Modificación de Alumnos";
        }
        public Alumno AltaDatosAlumno(string nombreAlumno, string apellidoAlumno, string ciAlumno, double ubicacion)
        {
            Console.WriteLine("entra a alta datos alumno");
            Alumno alumno = new Alumno();
            Console.WriteLine("luego de new alumno");
            if (!AlumnoExistente(ciAlumno))
            {
                alumno.Nombre = nombreAlumno;
                alumno.Apellido = apellidoAlumno;
                alumno.Ci = ciAlumno;
                alumno.Ubicacion = ubicacion;
                alumnos.Add(alumno);
                return alumno;
            }
            return alumno;
        }

        public void BajarAlumno(string ci)
        {
            Console.WriteLine("entra a bajar alumo" + ci);
            try
            {
                if (AlumnoExistente(ci))
                {
                    Console.WriteLine("entra a if borrar ");
                    Alumno alumnoAEliminar = alumnos.Single(alumno => alumno.Ci == ci);
                    Console.WriteLine("a borrar ci " + alumnoAEliminar.Ci);
                    alumnos.Remove(alumnoAEliminar);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar alumno > " + e.ToString());
            }
        }
        public void ModificarAlumno(string ci, Alumno nuevosValores)
        {
            try
            {
                Alumno alumnoAModificar = alumnos.Single(alumno => alumno.Ci == ci);
                int indiceDelAlumnoAModificar = alumnos.IndexOf(alumnoAModificar);
                alumnos[indiceDelAlumnoAModificar].Nombre = nuevosValores.Nombre != "" ? nuevosValores.Nombre : alumnoAModificar.Nombre;
                alumnos[indiceDelAlumnoAModificar].Apellido = nuevosValores.Apellido != "" ? nuevosValores.Apellido : alumnoAModificar.Apellido;
                alumnos[indiceDelAlumnoAModificar].Ci = nuevosValores.Ci != "" ? nuevosValores.Ci : alumnoAModificar.Ci;
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar alumno > " + e.ToString());
            }
        }
        public Alumno ObtenerAlumnoPorCi(string ciAlumno)
        {
            Alumno alumnoARetornar = alumnos.Find(alumno => alumno.Ci == ciAlumno);
            return alumnoARetornar;
        }
        public Boolean AlumnoExistente(string ci)
        {
            Boolean alumnoExistente = alumnos.Exists(alumnoEncontrado => alumnoEncontrado.Ci == ci);
            Console.WriteLine("alumno existente " + alumnoExistente);
            return alumnoExistente;
        }

        public void GenerarDatos()
        {
            alumnosPrueba.Add(AltaDatosAlumno("Juana", "Sosa", "50001002", 1.2));
            alumnosPrueba.Add(AltaDatosAlumno("Paola", "Bianco", "49912233", 1.3));
            alumnosPrueba.Add(AltaDatosAlumno("Hugo", "Cabral", "38824456", 1.4));
            alumnosPrueba.Add(AltaDatosAlumno("Alejandra", "Suarez", "39937650", 1.5));
            alumnos = ObtenerAlumnos();
        }
    }
}
