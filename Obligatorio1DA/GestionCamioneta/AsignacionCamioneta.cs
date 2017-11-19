using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCamioneta
{
    public static class AsignacionCamioneta
    {
        public static List<Camioneta> AsignarAlumnoACamioneta(List<Camioneta> camionetas, string ciAlumno, string matricula)
        {
            foreach (Camioneta camioneta in camionetas)
            {
                if (camioneta.Matricula == matricula)
                {
                    camioneta.Alumnos.Add(ciAlumno);
                    break; 
                }
            }
            return camionetas;
        }
    }
}
