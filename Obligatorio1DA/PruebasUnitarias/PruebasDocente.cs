using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionDocente;
using Interfaces;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasDocente
    {
        [TestMethod]

        public void ProbarTipoModuloGestionDocente()
        {
            // Creamos el ambDocente para gestionar los docentes
            MantenimientoDocente mantenimientoDocente = new MantenimientoDocente();
            Assert.IsInstanceOfType(mantenimientoDocente, typeof(IModuloGestion));
        }
    }
}
