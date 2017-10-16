using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace GestionDocente
{
    public class Docente:IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ci { get; set; }
        public List<string> Materias { get; set; }
        public override string ToString()
        {
            return "Nombre: " + Nombre;
        }
    }
}
