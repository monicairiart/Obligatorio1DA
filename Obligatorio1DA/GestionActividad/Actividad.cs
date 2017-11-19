using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionActividad
{
    public class Actividad
    {
        public string CodigoActividad {get; set;}
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Costo { get; set; }
        public List<string> Alumnos { get; set; }

    }
}
