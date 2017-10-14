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
        private List<Docente> docentes = new List<Docente>();
        public MantenimientoDocente()
        { 
            Console.WriteLine();
            Nombre = "Gestion Docente";
            Descripcion = "Alta, Baja y Modificación de Docentes";
        }
        public Docente AltaDatosDocente(string nombreDocente, string ciDocente, List<string> materias)
        {
            Docente docente = new Docente();
            docente.Nombre = nombreDocente;
            docente.Ci = ciDocente;
            docente.Materias = materias;
            docentes.Add(docente);
            return docente;
        }
    }
}
