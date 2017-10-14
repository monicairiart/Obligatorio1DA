using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDocente
{
    public class Docente
    {
        public string Nombre { get; set; }
        public string Ci { get; set; }
        public List<string> Materias { get; set; }
    }
}
