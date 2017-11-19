using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionAlumno;
using Interfaces;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasAlumno
    {
        public MantenimientoAlumno mantenimientoAlumno { get; set; }
        public List<Alumno> alumnos { get; set; }
        public List<Alumno> misAlumnos { get; set; }
        public PruebasAlumno()
        {
            mantenimientoAlumno = new MantenimientoAlumno();
            GenerarDatos();
        }
        [TestMethod]
        public void ProbarTipoModuloGestionAlumno()
        {
            Assert.IsInstanceOfType(mantenimientoAlumno, typeof(IModuloGestion));
        }
        [TestMethod]
        public void ProbarDatosTipoModuloGestionAlumno()
        {
            Assert.AreEqual("Gestion Alumno", mantenimientoAlumno.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Alumnos", mantenimientoAlumno.Descripcion);
        }
        [TestMethod]
        public void ProbarTipoModuloAltaAlumno()
        {
            MantenimientoAlumno Alumno = new GestionAlumno.MantenimientoAlumno();
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Docente", "Apellido del Docente", "35466661", Tuple.Create(1.0, 2.0));
            Assert.IsInstanceOfType(alumno, typeof(Alumno));
        }
        [TestMethod]
        public void ProbarAltaAlumno()
        {
            // En esta clase crear un alumno, comparar nombre, apellido y ci
            // y despues de realizadas las pruebas, eliminar el alumno recien creado
            // para mantener los datos estables

            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Miguel", "Sosa", "111", Tuple.Create(1.0, 2.0));
            Assert.IsInstanceOfType(alumno, typeof(Alumno));
            Assert.AreEqual("Miguel", alumno.Nombre);
            Assert.AreEqual("Sosa", alumno.Apellido);
            Assert.AreEqual("111", alumno.Ci);
            mantenimientoAlumno.BajarAlumno("111");
            //Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "50001002");
            //Assert.IsInstanceOfType(alumno, typeof(Alumno));
        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoNombre()
        {
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "50001003", Tuple.Create(1.0, 2.0));
            Console.WriteLine("alumno nombre " + alumno.Nombre);
            Assert.IsInstanceOfType(alumno.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", alumno.Nombre);
            Assert.AreEqual("Nombre del Alumno", alumno.Nombre);
            mantenimientoAlumno.BajarAlumno("50001003");
        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoApellido()
        {
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "50001004", Tuple.Create(1.0, 2.0));
            Assert.IsInstanceOfType(alumno.Apellido, typeof(string));
            Assert.AreNotEqual("Apellido cualquiera", alumno.Apellido);
            Assert.AreEqual("Apellido del Alumno", alumno.Apellido);
            mantenimientoAlumno.BajarAlumno("50001004");

        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoCi()
        {
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "50001005", Tuple.Create(1.0, 2.0));
            Assert.IsInstanceOfType(alumno.Ci, typeof(string));
            Assert.AreNotEqual("50001001", alumno.Ci);
            Assert.AreEqual("50001005", alumno.Ci);
            mantenimientoAlumno.BajarAlumno("50001005");
        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoUbicacion()
        {
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "50001006", Tuple.Create(1.0, 2.0));
            Assert.IsInstanceOfType(alumno.Ubicacion, typeof(Tuple<double, double>));
            Console.WriteLine("ubicacion " + alumno.Ubicacion);
            Assert.AreEqual(Tuple.Create(1.0, 2.0), alumno.Ubicacion);
            mantenimientoAlumno.BajarAlumno("50001006");
        }
        [TestMethod]
        public void ProbarDatosBajaAlumno()
        {
                       alumnos = mantenimientoAlumno.ObtenerAlumnos();

            //           Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "50001007", Tuple.Create(1.0, 2.0));
            List<Alumno> misAlumnos = new List<Alumno>();
            misAlumnos = mantenimientoAlumno.ObtenerAlumnos();
            Console.WriteLine("mis alumnos count " + misAlumnos.Count);
            Console.WriteLine("mantenimiento count " + mantenimientoAlumno.ObtenerAlumnos().Count);
            foreach (Alumno a in misAlumnos)
            {
                Console.WriteLine("Alumno: " + a.Nombre + " " + a.Apellido + " " + a.Ci);
            }
            foreach (Alumno a in mantenimientoAlumno.ObtenerAlumnos())
            {
                Console.WriteLine("Alumno: " + a.Nombre + " " + a.Apellido + " " + a.Ci);
            }
            CollectionAssert.AreEqual(misAlumnos, mantenimientoAlumno.ObtenerAlumnos());
            mantenimientoAlumno.BajarAlumno("50001002");
            CollectionAssert.AreNotEqual(misAlumnos, mantenimientoAlumno.ObtenerAlumnos());

            /*MantenimientoAlumno mantenimientoAlumno = new GestionAlumno.MantenimientoAlumno();
            
            List<Alumno> misAlumnos = new List<Alumno>();
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "50001002", Tuple.Create(1.0, 2.0)));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "49912233", Tuple.Create(1.0, 3.0)));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "38824456", Tuple.Create(1.0, 4.0)));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "39937650", Tuple.Create(1.0, 5.0)));
            
            CollectionAssert.AreEqual(misAlumnos, mantenimientoAlumno.ObtenerAlumnos());
            mantenimientoAlumno.BajarAlumno("50001002");
            CollectionAssert.AreNotEqual(misAlumnos, mantenimientoAlumno.ObtenerAlumnos());
            */
        }
        [TestMethod]
        public void ProbarDatosBajaAlumnoNoExiste()
        {
            //MantenimientoAlumno mantenimientoAlumno = new GestionAlumno.MantenimientoAlumno();
            //List<Alumno> misAlumnos = new List<Alumno>();
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "50001002"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "49912233"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "38824456"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "39937650"));
            CollectionAssert.AreEqual(misAlumnos, mantenimientoAlumno.ObtenerAlumnos());
            mantenimientoAlumno.BajarAlumno("55550005");
            CollectionAssert.AreEqual(misAlumnos, mantenimientoAlumno.ObtenerAlumnos());
        }
        [TestMethod]
        public void ProbarModificacionAlumnoNombre()
        {
            //List<Alumno> misAlumnos = new List<Alumno>();
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "50001002"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "49912233"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "38824456"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "39937650"));
            Alumno nuevosValoresAlumno = new Alumno();
            nuevosValoresAlumno.Nombre = "Juanita";
            mantenimientoAlumno.ModificarAlumno("50001002", nuevosValoresAlumno);
            Assert.AreEqual("Juanita", misAlumnos[0].Nombre);
            Console.WriteLine("nvos valor nombre " + misAlumnos[0].Nombre);
        }
        [TestMethod]
        public void ProbarModificacionAlumnoApellido()
        {
            //List<Alumno> misAlumnos = new List<Alumno>();
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "50001002"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "49912233"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "38824456"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "39937650"));
            Alumno nuevosValoresAlumno = new Alumno();
            nuevosValoresAlumno.Apellido = "Sosar";
            mantenimientoAlumno.ModificarAlumno("50001002", nuevosValoresAlumno);
            Assert.AreEqual("Sosar", misAlumnos[0].Nombre);
            Console.WriteLine("nvos valor apellido " + misAlumnos[0].Apellido);
        }
        [TestMethod]
        public void ProbarModificacionAlumnoCi()
        {
            //List<Alumno> misAlumnos = new List<Alumno>();
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "50001002"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "49912233"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "38824456"));
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "39937650"));
            Alumno nuevosValoresAlumno = new Alumno();
            nuevosValoresAlumno.Ci = "11111111";
            mantenimientoAlumno.ModificarAlumno("11111111", nuevosValoresAlumno);
            Assert.AreEqual("11111111", misAlumnos[0].Ci);
            Console.WriteLine("nvos valor ci " + misAlumnos[0].Ci);
        }
        [TestMethod]
        public void ProbarAlumnoExistente()
        {
            //MantenimientoAlumno mantenimientoAlumno = new GestionAlumno.MantenimientoAlumno();
            //List<Alumno> misAlumnos = new List<Alumno>();
            //misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "50001002"));
            Assert.IsTrue(mantenimientoAlumno.AlumnoExistente("50001002"));
        }
        [TestMethod]
        public void ProbarObtenerAlumno()
        {
            /*            List<Alumno> misAlumnos = new List<Alumno>();
                        misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "50001002"));
                        misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "49912233"));
                        misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "38824456"));
                        misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "39937650"));
             */
            Console.WriteLine("Mis alumnos " + misAlumnos.Count);
            foreach (Alumno a in misAlumnos) {
                Console.WriteLine("Alumno: " + a.Nombre + " " + a.Apellido + " " + a.Ci);
            }
            Console.WriteLine("Mantenimiento alumnos " + mantenimientoAlumno.ObtenerAlumnos().Count);
            foreach (Alumno am in mantenimientoAlumno.ObtenerAlumnos()) {
                Console.WriteLine("Alumno: " + am.Nombre + " " + am.Apellido + " " + am.Ci);
            }
            CollectionAssert.AreEqual(misAlumnos, mantenimientoAlumno.ObtenerAlumnos());
        }
 /*       [TestMethod]
        public void ProbarGenerarDatos()
        {
            List<Alumno> alumnosPrueba = new List<Alumno>();
            MantenimientoAlumno mantenimientoAlumno = new GestionAlumno.MantenimientoAlumno();
            alumnosPrueba.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "50001002"));
            alumnosPrueba.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "49912233"));
            alumnosPrueba.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "38824456"));
            alumnosPrueba.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "39937650"));
            mantenimientoAlumno.GenerarDatos(); 
            CollectionAssert.AreEqual(alumnosPrueba, mantenimientoAlumno.ObtenerAlumnos());
        }*/

        public void GenerarDatos()
        {
            misAlumnos = new List<Alumno>();
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "50001002", Tuple.Create(1.0, 2.0)));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "49912233", Tuple.Create(1.0, 3.0)));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "38824456", Tuple.Create(1.0, 4.0)));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "39937650", Tuple.Create(1.0, 5.0)));
            alumnos = mantenimientoAlumno.ObtenerAlumnos();
        }
    }
}

