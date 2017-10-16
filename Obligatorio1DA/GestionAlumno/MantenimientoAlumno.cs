using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace GestionAlumno
{
    public class MantenimientoAlumno
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public MantenimientoAlumno()
        {
            Console.WriteLine();
            Nombre = "Gestion Alumno";
            Descripcion = "Alta, Baja y Modificación de Alumnos";
        }
    }
}
