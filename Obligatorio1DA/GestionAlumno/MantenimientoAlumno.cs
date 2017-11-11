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
        private List<Alumno> alumnos = new List<Alumno>();
        public List<Alumno> alumnosPrueba = new List<Alumno>();
        public List<Alumno> ObtenerAlumnos()
        {
            return alumnos;
        }
        public MantenimientoAlumno()
        {
            Console.WriteLine();
            Nombre = "Gestion Alumno";
            Descripcion = "Alta, Baja y Modificación de Alumnos";
        }
        public Alumno AltaDatosAlumno(string nombreAlumno, string apellidoAlumno, string ciAlumno)
        {
            Alumno alumno = new Alumno();
            if (!AlumnoExistente(ciAlumno))
            {
                alumno.Nombre = nombreAlumno;
                alumno.Apellido = apellidoAlumno;
                alumno.Ci = ciAlumno;
                alumnos.Add(alumno);
                return alumno;
            }
            return alumno;
        }

        public void BajarAlumno(string ci)
        {
            try
            {
                if (AlumnoExistente(ci))
                {
                    Alumno alumnoAEliminar = alumnos.Single(alumno => alumno.Ci == ci);
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
        public Boolean AlumnoExistente(string ci)
        {
            Boolean alumnoExistente = alumnos.Exists(alumnoEncontrado => alumnoEncontrado.Ci == ci);
            return alumnoExistente;
        }

        public void GenerarDatos()
        {
            alumnosPrueba.Add(AltaDatosAlumno("Juana", "Sosa", "50001002"));
            alumnosPrueba.Add(AltaDatosAlumno("Paola", "Bianco", "49912233"));
            alumnosPrueba.Add(AltaDatosAlumno("Hugo", "Cabral", "38824456"));
            alumnosPrueba.Add(AltaDatosAlumno("Alejandra", "Suarez", "39937650"));
            alumnos = ObtenerAlumnos();
        }
    }
}
