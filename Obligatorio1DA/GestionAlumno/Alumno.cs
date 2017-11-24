using Interfaces;
using RelacionAlumnoMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlumno
{
    public class Alumno : IPersona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ci { get; set; }
        //public Tuple<double, double> Ubicacion { get; set; }
        public double UbicacionX { get; set; }
        public double UbicacionY { get; set; }
        public virtual ICollection<AlumnoMateria> AlumnosMaterias { get; set; }


    }
}
