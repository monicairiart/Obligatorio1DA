using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace GestionCamioneta
{
    public class Camioneta
    {
        public string Matricula { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }
        public List<string> Viajes { get; set; }
    }
}
