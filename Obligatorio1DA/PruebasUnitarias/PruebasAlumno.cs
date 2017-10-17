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
        public PruebasAlumno()
        {
            mantenimientoAlumno = new MantenimientoAlumno();
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
            List<string> materias = new List<string>();
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "1000", materias);
            Assert.IsInstanceOfType(alumno, typeof(Alumno));
        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoNombre()
        {
            List<string> materias = new List<string>();
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "1000", materias);
            Assert.IsInstanceOfType(alumno.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", alumno.Nombre);
            Assert.AreEqual("Nombre del Alumno", alumno.Nombre);
        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoApellido()
        {
            List<string> materias = new List<string>();
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "1000", materias);
            Assert.IsInstanceOfType(alumno.Apellido, typeof(string));
            Assert.AreNotEqual("Apellido cualquiera", alumno.Apellido);
            Assert.AreEqual("Apellido del Alumno", alumno.Apellido);
        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoCi()
        {
            List<string> materias = new List<string>();
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "1000", materias);
            Assert.IsInstanceOfType(alumno.Ci, typeof(string));
            Assert.AreNotEqual("1111", alumno.Ci);
            Assert.AreEqual("1000", alumno.Ci);
        }
        [TestMethod]
        public void ProbarDatosAltaAlumnoMaterias()
        {
            List<string> materias = new List<string>();
            List<string> materiasDiferentes = new List<string>();
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "1000", materias);
            materias.Add("Aritmetica");
            materias.Add("Sistemas informaticos");
            materiasDiferentes.Add("Ingles");
            materiasDiferentes.Add("Dibujo");
            Assert.IsInstanceOfType(alumno.Materias, typeof(List<string>));
            Assert.AreNotEqual(materiasDiferentes, alumno.Materias);
            Assert.AreEqual(materias, alumno.Materias);
        }
        [TestMethod]
        public void ProbarDatosBajaAlumno()
        {
            MantenimientoAlumno mantenimientoAlumno = new GestionAlumno.MantenimientoAlumno();
            List<Alumno> misAlumnos = new List<Alumno>();
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "1000", new List<string>()));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "1001", new List<string>()));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "1002", new List<string>()));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "1003", new List<string>()));
            CollectionAssert.AreEqual(misAlumnos, mantenimientoAlumno.GetAlumnos());
            mantenimientoAlumno.BajaAlumno("1000");
            CollectionAssert.AreNotEqual(misAlumnos, mantenimientoAlumno.GetAlumnos());

        }
        [TestMethod]
        public void ProbarDatosBajaDocenteNoExiste()
        {
            MantenimientoAlumno mantenimientoAlumno = new GestionAlumno.MantenimientoAlumno();
            List<Alumno> misAlumnos = new List<Alumno>();
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "1000", new List<string>()));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "1001", new List<string>()));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "1002", new List<string>()));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "1003", new List<string>()));
            CollectionAssert.AreEqual(misAlumnos, mantenimientoAlumno.GetAlumnos());
            mantenimientoAlumno.BajaAlumno("123466");
            CollectionAssert.AreEqual(misAlumnos, mantenimientoAlumno.GetAlumnos());
        }
        [TestMethod]
        public void ProbarModificacionAlumnoNombre()
        {
            // Creamos una lista de docentes para realizar las validaciones
            List<Alumno> misAlumnos = new List<Alumno>();

            // Agrego Alumnos con AltaDatosAlumno para tener una lista
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Juana", "Sosa", "1000", new List<string>()));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Paola", "Bianco", "1001", new List<string>()));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Hugo", "Cabral", "1002", new List<string>()));
            misAlumnos.Add(mantenimientoAlumno.AltaDatosAlumno("Alejandra", "Suarez", "1003", new List<string>()));

   
            // Creamos un nuevo alumno para modificar
            Alumno nuevosValoresAlumno = new Alumno();
            nuevosValoresAlumno.Nombre = "Juanita";
            mantenimientoAlumno.ModificarAlumno("1000", nuevosValoresAlumno);
            Assert.AreEqual("Juanita", misAlumnos[0].Nombre);
            Console.WriteLine("nvos valor nombre " + misAlumnos[0].Nombre);
        }
    }
}
