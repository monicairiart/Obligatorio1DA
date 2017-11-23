using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionDocenteMateria
{
    public class DocenteMateria
    {
        public int Id { get; set; }
        public int DocenteId { get; set; }
        public int MateriaId { get; set; }
    }
}
