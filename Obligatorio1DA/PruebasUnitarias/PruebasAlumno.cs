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
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "111", 1, 2);
            Assert.IsInstanceOfType(alumno, typeof(Alumno));
            mantenimientoAlumno.BajarAlumno("111");
        }
        [TestMethod]
        public void ProbarAltaAlumno()
        {
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Miguel", "Sosa", "111", 1, 2);
            Assert.IsInstanceOfType(alumno, typeof(Alumno));
            Assert.AreEqual("Miguel", alumno.Nombre);
            Assert.AreEqual("Sosa", alumno.Apellido);
            Assert.AreEqual("111", alumno.Ci);
            mantenimientoAlumno.BajarAlumno("111");
        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoNombre()
        {
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "50001003", 1, 2);
            Assert.IsInstanceOfType(alumno.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", alumno.Nombre);
            Assert.AreEqual("Nombre del Alumno", alumno.Nombre);
            mantenimientoAlumno.BajarAlumno("50001003");
        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoApellido()
        {
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "50001004", 1, 2);
            Assert.IsInstanceOfType(alumno.Apellido, typeof(string));
            Assert.AreNotEqual("Apellido cualquiera", alumno.Apellido);
            Assert.AreEqual("Apellido del Alumno", alumno.Apellido);
            mantenimientoAlumno.BajarAlumno("50001004");

        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoCi()
        {
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "50001005", 1, 2);
            Assert.IsInstanceOfType(alumno.Ci, typeof(string));
            Assert.AreNotEqual("50001001", alumno.Ci);
            Assert.AreEqual("50001005", alumno.Ci);
            mantenimientoAlumno.BajarAlumno("50001005");
        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoUbicacion()
        {
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "50001006", 1, 2);
            Assert.AreEqual(1, alumno.UbicacionX);
            Assert.AreEqual(2, alumno.UbicacionY);
            mantenimientoAlumno.BajarAlumno("50001006");
        }
        [TestMethod]
        public void ProbarDatosBajaAlumno()
        {
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Miguel", "Sosa", "111", 1, 2));
            CollectionAssert.AreNotEqual(misAlumnos, alumnos);
            mantenimientoAlumno.BajarAlumno("111");
            CollectionAssert.AreEqual(mantenimientoAlumno.ObtenerAlumnos(), alumnos);
        }
        [TestMethod]
        public void ProbarDatosBajaAlumnoNoExiste()
        {
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Miguel", "Sosa", "111", 1, 2));
            CollectionAssert.AreNotEqual(misAlumnos, alumnos);
            mantenimientoAlumno.BajarAlumno("11111");
            CollectionAssert.AreEqual(mantenimientoAlumno.ObtenerAlumnos(), alumnos);
        }
        [TestMethod]
        public void ProbarModificacionAlumnoNombre()
        {
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Miguel", "Sosa", "111", 1, 2));
            Alumno nuevosValoresAlumno = new Alumno();
            nuevosValoresAlumno.Nombre = "Juan Daniel";
            nuevosValoresAlumno.Apellido = "Sosa";
            nuevosValoresAlumno.Ci = "111";
            nuevosValoresAlumno.UbicacionX = 1;
            nuevosValoresAlumno.UbicacionY = 2;
            mantenimientoAlumno.ModificarAlumno("111", nuevosValoresAlumno);
            Assert.AreEqual("Juan Daniel", mantenimientoAlumno.ObtenerAlumnoPorCi("111").Nombre);
            mantenimientoAlumno.BajarAlumno("111");
        }
        [TestMethod]
        public void ProbarModificacionAlumnoApellido()
        {
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Miguel", "Sosa", "111", 1, 2));
            Alumno nuevosValoresAlumno = new Alumno();
            nuevosValoresAlumno.Nombre = "Miguel";
            nuevosValoresAlumno.Apellido = "Gutierrez";
            nuevosValoresAlumno.Ci = "111";
            nuevosValoresAlumno.UbicacionX = 1;
            nuevosValoresAlumno.UbicacionY = 2;
            mantenimientoAlumno.ModificarAlumno("111", nuevosValoresAlumno);
            Assert.AreEqual("Gutierrez", mantenimientoAlumno.ObtenerAlumnoPorCi("111").Apellido);
            mantenimientoAlumno.BajarAlumno("111");
        }
        [TestMethod]
        public void ProbarModificacionAlumnoCi()
        {
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Miguel", "Sosa", "111", 1, 2));
            Alumno nuevosValoresAlumno = new Alumno();
            nuevosValoresAlumno.Nombre = "Miguel";
            nuevosValoresAlumno.Apellido = "Sosa";
            nuevosValoresAlumno.Ci = "11122223";
            nuevosValoresAlumno.UbicacionX = 1;
            nuevosValoresAlumno.UbicacionY = 2;
            mantenimientoAlumno.ModificarAlumno("111", nuevosValoresAlumno);
            Assert.AreEqual("11122223", mantenimientoAlumno.ObtenerAlumnoPorCi("11122223").Ci);
            mantenimientoAlumno.BajarAlumno("11122223");
            }
        [TestMethod]
        public void ProbarAlumnoExistente()
        {
           Assert.IsTrue(mantenimientoAlumno.AlumnoExistente("50001002"));
        }
        [TestMethod]
        public void ProbarObtenerAlumno()
        {
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Miguel", "Sosa", "111", 1, 2));
            Assert.AreEqual("111", mantenimientoAlumno.ObtenerAlumnoPorCi("111").Ci);
            mantenimientoAlumno.BajarAlumno("111");
        }
        [TestMethod]
        public void ProbarGenerarDatos()
       {
            List<Alumno> alumnosPrueba = new List<Alumno>();
            alumnosPrueba = mantenimientoAlumno.ObtenerAlumnos();
            mantenimientoAlumno.GenerarDatos();
            CollectionAssert.AreEqual(alumnosPrueba, mantenimientoAlumno.ObtenerAlumnos());
        }
        public void GenerarDatos()
        {
            misAlumnos = new List<Alumno>();
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "50001002", 1, 2));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "49912233", 1, 3));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "38824456", 1, 4));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "39937650", 1, 5));
            alumnos = mantenimientoAlumno.ObtenerAlumnos();
        }
    }
}