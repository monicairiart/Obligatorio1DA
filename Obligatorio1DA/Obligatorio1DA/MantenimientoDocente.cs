using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace GestionDocente
{
    public class MantenimientoDocente : IModuloGestion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public MantenimientoDocente()
        { 
            Console.WriteLine();
            Nombre = "Gestion Docente";
            Descripcion = "Alta, Baja y Modificación de Docentes";
        }
    }
}
