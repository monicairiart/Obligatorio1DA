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
        public void ProbarDatosTipoModuloGestionDocente()
        {
            // Test si abm tiene nombre y descripción
            MantenimientoDocente mantenimientoDocente = new MantenimientoDocente();
            Assert.AreEqual("Gestion Docente", mantenimientoDocente.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Docentes", mantenimientoDocente.Descripcion);
        }
    }
}
