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
        public MantenimientoAlumno()
        {
            Console.WriteLine();
            Nombre = "Gestion Alumno";
            Descripcion = "Alta, Baja y Modificación de Alumnos";
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
    }
}
