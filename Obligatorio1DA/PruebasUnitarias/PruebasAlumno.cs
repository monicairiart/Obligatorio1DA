using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasAlumno
    {
        [TestMethod]
        public void ProbarTipoModuloGestionAlumno()
        {
            Assert.IsInstanceOfType(mantenimientoAlumno, typeof(IModuloGestion));
        }
    }
}
