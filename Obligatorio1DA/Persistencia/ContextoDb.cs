using GestionAlumno;
using GestionDocente;
using GestionMateria;
using RelacionAlumnoMateria;
using RelacionDocenteMateria;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ContextoDb:DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<DocenteMateria> DocentesMaterias { get; set; }
        public DbSet<AlumnoMateria> AlumnosMaterias { get; set; }
    }
}
