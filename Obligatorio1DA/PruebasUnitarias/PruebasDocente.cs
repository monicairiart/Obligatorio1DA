using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionDocente;
using Interfaces;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasDocente
    {
        public MantenimientoDocente mantenimientoDocente { get; set; }
        public PruebasDocente()
        {
            mantenimientoDocente = new MantenimientoDocente();
        }

        [TestMethod]
        public void ProbarTipoModuloGestionDocente()
        {
            Assert.IsInstanceOfType(mantenimientoDocente, typeof(IModuloGestion));
        }
        [TestMethod]
        public void ProbarDatosTipoModuloGestionDocente()
        {
            Assert.AreEqual("Gestion Docente", mantenimientoDocente.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Docentes", mantenimientoDocente.Descripcion);
        }
        [TestMethod]
        public void ProbarTipoModuloAltaDocente()
        {
            MantenimientoDocente Docente = new GestionDocente.MantenimientoDocente();
            List<string> materias = new List<string>();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "1234", materias);
            Assert.IsInstanceOfType(docente, typeof(Docente));
        }

        [TestMethod]
        public void ProbarDatosAltaDocenteNombre()
        {
            List<string> materias = new List<string>();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "1234", materias);
            Assert.IsInstanceOfType(docente.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", docente.Nombre);
            Assert.AreEqual("Nombre del Docente", docente.Nombre);
        }
        [TestMethod]
        public void ProbarDatosAltaDocenteApellido()
        {
            List<string> materias = new List<string>();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "1234", materias);
            Assert.IsInstanceOfType(docente.Apellido, typeof(string));
            Assert.AreNotEqual("Apellido cualquiera", docente.Apellido);
            Assert.AreEqual("Apellido del Docente", docente.Apellido);
        }
        [TestMethod]
        public void ProbarDatosAltaDocenteCi()
        { 
            List<string> materias = new List<string>();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "1234", materias);
            Assert.IsInstanceOfType(docente.Ci, typeof(string));
            Assert.AreNotEqual("1111", docente.Ci);
            Assert.AreEqual("1234", docente.Ci);
        }
        [TestMethod]
        public void ProbarDatosAltaDocenteMaterias()
        {
            List<string> materias = new List<string>();
            List<string> materiasDiferentes = new List<string>();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "1234", materias);
            materiasDiferentes.Add("Ingles");
            materiasDiferentes.Add("Dibujo");
            Assert.IsInstanceOfType(docente.Materias, typeof(List<string>));
            Assert.AreNotEqual(materiasDiferentes, docente.Materias);
            Assert.AreEqual(materias, docente.Materias);
        }
    }
}
