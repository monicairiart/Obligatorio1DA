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
        public PruebasCamioneta()
        {
            mantenimientoCamioneta = new MantenimientoCamioneta();
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
            List<string> viajes = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("Matrícula de la Camioneta", 50, "Estado", viajes);
            Assert.IsInstanceOfType(camioneta, typeof(Camioneta));
        }
        [TestMethod]
        public void ProbarDatosAltaCamionetaMatricula()
        {
            List<string> viajes = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("Matricula de la Camioneta", 50, "Disponible", viajes);
            Assert.IsInstanceOfType(camioneta.Matricula, typeof(string));
            Assert.AreNotEqual("Matricula cualquiera", camioneta.Matricula);
            Assert.AreEqual("Matricula de la Camioneta", camioneta.Matricula);
        }
        [TestMethod]
        public void ProbarDatosAltaCamionetaCapacidad()
        {
            List<string> viajes = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("Matricula de la Camioneta", 50, "Disponible", viajes);
            Assert.IsInstanceOfType(camioneta.Matricula, typeof(string));
            Assert.AreNotEqual(40, camioneta.Capacidad);
            Assert.AreEqual(50, camioneta.Capacidad);
        }
        [TestMethod]
        public void ProbarDatosAltaCamionetaEstado()
        {
            List<string> viajes = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("Matricula de la Camioneta", 50, "Disponible", viajes);
            Assert.IsInstanceOfType(camioneta.Estado, typeof(string));
            Assert.AreNotEqual("Estado cualquiera", camioneta.Estado);
            Assert.AreEqual("Disponible", camioneta.Estado);
        }
        //[TestMethod]
        /*public void ProbarDatosAltaCamionetasViajes()
        {
            List<string> viajes = new List<string>();
            List<string> viajesDiferentes = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("SAF3670", 50, "Disponible", viajes);
            viajes.Add("1R", "0,1", "Alumno1");
            viajes.Add("1R", "1,2", "Alumno2");
            viajes.Add("1R", "2,2", "Alumno3");
            viajesDiferentes.Add("1R", "2,3", "Alumno1");
            viajesDiferentes.Add("1R", "3,3", "Alumno1");
            viajesDiferentes.Add("2R", "1,2", "Alumno2");
            Assert.IsInstanceOfType(camioneta.Viajes, typeof(List<string>));
            Assert.AreNotEqual(viajesDiferentes, camioneta.Viajes);
            Assert.AreEqual(viajes, camioneta.Viajes);
        }*/
    }
}

