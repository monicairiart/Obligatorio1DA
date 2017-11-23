using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using RelacionDocenteMateria;
using RelacionAlumnoMateria;

namespace GestionMateria
{
    public class Materia
    {
        public int Id { get; set; }
        public string CodigoMateria { get; set; }
        public string Nombre { get; set; }
        public List<string> Docentes { get; set; }
        public List<string> Alumnos { get; set; }
        public virtual ICollection<DocenteMateria> DocentesMaterias { get; set; }
        public virtual ICollection<AlumnoMateria> AlumnosMaterias { get; set; }

        public Boolean GetCiDocente(string ciDocente)
        {
            Boolean existe = Docentes.ToList().Contains(ciDocente);
            return existe;
        }
        public Boolean GetCiAlumno(string ciAlumno)
        {
            Boolean existe = Alumnos.ToList().Contains(ciAlumno);
            return existe;
        }
    }
}
