﻿using System;
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
    }
}
