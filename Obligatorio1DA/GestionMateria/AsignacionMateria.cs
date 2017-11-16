using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMateria
{
    public static class AsignacionMateria
    {
        public static List<Materia> AsignarDocenteAMateria(List<Materia> materias, string ciDocente, string codigoMateria)
        {
            foreach (Materia materia in materias)
            {
                if (materia.CodigoMateria == codigoMateria)
                {
                    materia.Docentes.Add(ciDocente);
                    break;
                }
            }
            return materias;
        }
        public static List<Materia> AsignarAlumnoAMateria(List<Materia> materias, string ciAlumno, string codigoMateria)
        {
            foreach (Materia materia in materias)
            {
                if (materia.CodigoMateria == codigoMateria)
                {
                    materia.Alumnos.Add(ciAlumno);
                    break;
                }
            }
            return materias;
        }
    }
}
