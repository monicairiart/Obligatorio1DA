using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionAlumno;
using Interfaces;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasAlumno
    {
        public MantenimientoAlumno mantenimientoAlumno { get; set; }
        [TestMethod]
        public void ProbarTipoModuloGestionAlumno()
        {
            Assert.IsInstanceOfType(mantenimientoAlumno, typeof(IModuloGestion));
        }
    }
}
