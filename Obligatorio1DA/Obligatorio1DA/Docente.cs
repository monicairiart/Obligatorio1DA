using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using RelacionDocenteMateria;

namespace GestionDocente
{
    public class Docente:IPersona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ci { get; set; }
        public virtual ICollection<DocenteMateria> DocentesMaterias { get; set; }

    }
}
