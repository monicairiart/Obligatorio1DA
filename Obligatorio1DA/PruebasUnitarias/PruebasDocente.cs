using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasDocente
    {
        [TestMethod]

        public void ProbarTipoModuloGestionDocente()
        {
            mantenimientoDocente = new GestionDocente.MantenimientoDocente();
            Assert.IsInstanceOfType(mantenimientoDocente, typeof(IModulo));
        }
}
