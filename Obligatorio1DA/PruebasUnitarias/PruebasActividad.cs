using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interfaces;
using GestionActividad;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasActividad
    {
        public MantenimientoActividad  mantenimientoActividad { get; set; }

        public PruebasActividad()
        {
            mantenimientoActividad = new MantenimientoActividad();
//            mantenimientoActividad.GenerarDatos();
        }
        [TestMethod]
        public void ProbarTipoModuloGestionActividad()
        {
            Assert.IsInstanceOfType(mantenimientoActividad, typeof(IModuloGestion));
        }
        [TestMethod]
        public void ProbarDatosTipoModuloGestionActividad()
        {
            Assert.AreEqual("Gestion Actividad", mantenimientoActividad.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Actividades", mantenimientoActividad.Descripcion);
        }
        [TestMethod]
        public void ProbarTipoModuloAltaActividad()
        {
            MantenimientoActividad Actividad = new GestionActividad.MantenimientoActividad();
            List<string> alumnos = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosActividad("1", "Nombre de la Actividad", "22/01/2017", 100, alumnos);
            Assert.IsInstanceOfType(camioneta, typeof(Camioneta));
        }
    }
}
