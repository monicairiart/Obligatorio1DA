using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasMateria
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void ProbarTipoModuloGestionMateria()
        {
            Assert.IsInstanceOfType(mantenimientoMateria, typeof(IModuloGestion));
        }
    }
}
