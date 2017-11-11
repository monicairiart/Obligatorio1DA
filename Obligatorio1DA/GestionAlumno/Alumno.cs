<<<<<<< HEAD
﻿using System;
=======
﻿using Interfaces;
using System;
>>>>>>> 4be53b10208b4a61328b3ba062a68b1afe7ec930
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using Interfaces;

namespace GestionAlumno
{
    public class Alumno:IPersona
=======

namespace GestionAlumno
{
    public class Alumno : IPersona
>>>>>>> 4be53b10208b4a61328b3ba062a68b1afe7ec930
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ci { get; set; }
        public List<string> Materias { get; set; }
        public override string ToString()
        {
            return "Nombre: " + Nombre;
        }
    }
}
