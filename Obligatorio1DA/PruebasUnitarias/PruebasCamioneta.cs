using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionCamioneta;
using Interfaces;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasCamioneta
    {
        public MantenimientoCamioneta mantenimientoCamioneta { get; set; }
        public List<Camioneta> camionetas { get; set; }
        public List<Camioneta> misCamionetas { get; set; }
        public PruebasCamioneta()
        {
            mantenimientoCamioneta = new MantenimientoCamioneta();
            GenerarDatos();
        }
        [TestMethod]
        public void ProbarTipoModuloGestionCamioneta()
        {
            Assert.IsInstanceOfType(mantenimientoCamioneta, typeof(IModuloGestion));
        }
        [TestMethod]
        public void ProbarDatosTipoModuloGestionCamioneta()
        {
            Assert.AreEqual("Gestion Camioneta", mantenimientoCamioneta.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Camionetas", mantenimientoCamioneta.Descripcion);
        }
        [TestMethod]
        public void ProbarTipoModuloAltaCamioneta()
        {
            MantenimientoCamioneta Camioneta = new GestionCamioneta.MantenimientoCamioneta();
            List<string> alumnos = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Estado", alumnos);
            Assert.IsInstanceOfType(camioneta, typeof(Camioneta));
            mantenimientoCamioneta.BajarCamioneta("SAF3685");
        }
        [TestMethod]
        public void ProbarDatosAltaCamionetaMatricula()
        {
            List<string> alumnos = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("SAF9999", 50, "Disponible", alumnos);
            Assert.IsInstanceOfType(camioneta.Matricula, typeof(string));
            Assert.AreNotEqual("SAF0000", camioneta.Matricula);
            Assert.AreEqual("SAF9999", camioneta.Matricula);
            mantenimientoCamioneta.BajarCamioneta("SAF9999");
        }
        [TestMethod]
        public void ProbarDatosAltaCamionetaCapacidad()
        {
            List<string> alumnos = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("SAF9999", 50, "Disponible", alumnos);
            Assert.IsInstanceOfType(camioneta.Matricula, typeof(string));
            Assert.AreNotEqual(40, camioneta.Capacidad);
            Assert.AreEqual(50, camioneta.Capacidad);
            mantenimientoCamioneta.BajarCamioneta("SAF9999");
        }
        [TestMethod]
        public void ProbarDatosAltaCamionetaEstado()
        {
            List<string> alumnos = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("SAF9999", 50, "Disponible", new List<string>());
            Assert.IsInstanceOfType(camioneta.Matricula, typeof(string));
            Assert.AreNotEqual("No Disponible", camioneta.Estado);
            Assert.AreEqual("Disponible", camioneta.Estado);
            mantenimientoCamioneta.BajarCamioneta("SAF9999");
        }
        [TestMethod]
        public void ProbarDatosModificacionCamionetaMatricula()
        {
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF0000", 50, "Disponible", new List<string>()));
            Camioneta nuevosValoresCamioneta = new Camioneta();
            nuevosValoresCamioneta.Matricula = "SAF1111";
            mantenimientoCamioneta.ModificarCamioneta("SAF0000", nuevosValoresCamioneta);
            Assert.AreEqual("SAF1111", mantenimientoCamioneta.ObtenerCamionetaPorMatricula("SAF1111").Matricula);
            mantenimientoCamioneta.BajarCamioneta("SAF1111");
        }
        [TestMethod]
        public void ProbarDatosModificacionCamionetaCapacidad()
        {
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF0001", 50, "Disponible", new List<string>()));
            Camioneta nuevosValoresCamioneta = new Camioneta();
            nuevosValoresCamioneta.Matricula = "SAF0001";
            nuevosValoresCamioneta.Capacidad = 51;
            mantenimientoCamioneta.ModificarCamioneta("SAF0001", nuevosValoresCamioneta);
            Assert.AreEqual(51, mantenimientoCamioneta.ObtenerCamionetaPorMatricula("SAF0001").Capacidad);
            mantenimientoCamioneta.BajarCamioneta("SAF0001");
        }
        [TestMethod]
        public void ProbarDatosModificacionCamionetaEstado()
        {
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF0002", 50, "Disponible", new List<string>()));
            Camioneta nuevosValoresCamioneta = new Camioneta();
            nuevosValoresCamioneta.Matricula = "SAF0002";
            nuevosValoresCamioneta.Estado = "No Disponible";
            mantenimientoCamioneta.ModificarCamioneta("SAF0002", nuevosValoresCamioneta);
            Assert.AreEqual("No Disponible", mantenimientoCamioneta.ObtenerCamionetaPorMatricula("SAF0002").Estado);
            mantenimientoCamioneta.BajarCamioneta("SAF0002");
        }
        [TestMethod]
        public void ProbarDatosBajaCamioneta()
        {
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3680", 50, "Disponible", new List<string>()));
            CollectionAssert.AreNotEqual(misCamionetas, camionetas);
            mantenimientoCamioneta.BajarCamioneta("SAF3680");
            CollectionAssert.AreEqual(mantenimientoCamioneta.ObtenerCamionetas(), camionetas);
        }
        [TestMethod]
        public void ProbarDatosBajaCamionetaNoExiste()
        {
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3681", 50, "Disponible", new List<string>()));
            CollectionAssert.AreNotEqual(misCamionetas,camionetas);
            mantenimientoCamioneta.BajarCamioneta("999");
            CollectionAssert.AreEqual(mantenimientoCamioneta.ObtenerCamionetas(), camionetas);
        }
        [TestMethod]
        public void ProbarCamionetaExistente()
        {
            MantenimientoCamioneta mantenimientoCamioneta = new GestionCamioneta.MantenimientoCamioneta();
            List<Camioneta> misCamionetas = new List<Camioneta>();
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Disponible", new List<string>()));
            Assert.IsTrue(mantenimientoCamioneta.CamionetaExistente("SAF3685"));
        }
        [TestMethod]
        public void ProbarAsignarAlumnoACamioneta()
        {
            camionetas = mantenimientoCamioneta.ObtenerCamionetas();
            string ciAlumno = "50001002";
            string matricula = "SAA3600";
            camionetas = AsignacionCamioneta.AsignarAlumnoACamioneta(camionetas, ciAlumno, matricula);
            Camioneta camioneta = mantenimientoCamioneta.ObtenerCamionetaPorMatricula(matricula);
            string ciAlumnoEncontrado = camioneta.Alumnos.Find(ci => ci == ciAlumno);
            Assert.AreEqual(ciAlumno, ciAlumnoEncontrado);
        }
        public void GenerarDatos()
        {
            misCamionetas = new List<Camioneta>();
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 40, "Disponible", new List<string>()));
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3688", 30, "No Disponible", new List<string>()));
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAA3600", 20, "Disponible", new List<string>()));
            camionetas = mantenimientoCamioneta.ObtenerCamionetas();
        }
    }
}

