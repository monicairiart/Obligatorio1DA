using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interfaces;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasActividad
    {
        public MantenimientoActividad  mantenimientoActividad { get; set; }

        public void PruebasActividad()
        {
            mantenimientoActividad = new MantenimientoActividad();
//            mantenimientoActividad.GenerarDatos();
        }
        [TestMethod]
        public void ProbarTipoModuloGestionMateria()
        {
            Assert.IsInstanceOfType(mantenimientoMateria, typeof(IModuloGestion));
        }
    }
}
