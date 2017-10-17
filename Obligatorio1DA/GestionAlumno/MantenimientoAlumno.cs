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
        public IContenedorModulo Contenedor { get; set; }
        public List<Alumno> GetAlumnos()
        {
            return alumnos;
        }
        public MantenimientoAlumno()
        {
            Console.WriteLine();
            Nombre = "Gestion Alumno";
            Descripcion = "Alta, Baja y Modificación de Alumnos";
        }
        public void Mostrar()
        {
            GestionAlumnoFormulario formularioPrincipal = new GestionAlumnoFormulario();
            formularioPrincipal.ShowDialog();
        }
        public Alumno AltaDatosAlumno(string nombreAlumno, string apellidoAlumno, string ciAlumno, List<string> materias)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = nombreAlumno;
            alumno.Apellido = apellidoAlumno;
            alumno.Ci = ciAlumno;
            alumno.Materias = materias;
            alumnos.Add(alumno);
            return alumno;
        }
        public void BajaAlumno(string ci)
        {
            Console.WriteLine("Cedula de Identidad a Baja de Alumno > " + ci);

            try
            {
                Alumno alumnoAEliminar = alumnos.Single(alumno => alumno.Ci == ci);
                alumnos.Remove(alumnoAEliminar);
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar alumno > " + e.ToString());
            }
        }
        public void ModificarAlumno(string ci, Alumno nuevosValores)
        {
            Console.WriteLine("Alumno a modificar > " + ci);
            try
            {
                Alumno alumnoAModificar = alumnos.Single(alumno => alumno.Ci == ci);
                int indiceDelAlumnoAModificar = alumnos.IndexOf(alumnoAModificar);

                alumnos[indiceDelAlumnoAModificar].Nombre = nuevosValores.Nombre != "" ? nuevosValores.Nombre : alumnoAModificar.Nombre;

                alumnos[indiceDelAlumnoAModificar].Apellido = nuevosValores.Apellido != "" ? nuevosValores.Apellido : alumnoAModificar.Apellido;
                alumnos[indiceDelAlumnoAModificar].Ci = nuevosValores.Ci != "" ? nuevosValores.Ci : alumnoAModificar.Ci;

                alumnos[indiceDelAlumnoAModificar].Materias = nuevosValores.Materias[0] != "" ? nuevosValores.Materias : alumnoAModificar.Materias;

            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar alumno > " + e.ToString());
            }
        }
    }
}
