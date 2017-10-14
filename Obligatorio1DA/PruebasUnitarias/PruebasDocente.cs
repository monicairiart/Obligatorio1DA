using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionDocente;
using Interfaces;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasDocente
    {
        public MantenimientoDocente mantenimientoDocente { get; set; }


        public PruebasDocente()
        {
            mantenimientoDocente = new MantenimientoDocente();
        }

        [TestMethod]
        public void ProbarTipoModuloGestionDocente()
        {
            Assert.IsInstanceOfType(mantenimientoDocente, typeof(IModuloGestion));
        }
        [TestMethod]
        public void ProbarDatosTipoModuloGestionDocente()
        {
            Assert.AreEqual("Gestion Docente", mantenimientoDocente.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Docentes", mantenimientoDocente.Descripcion);
        }
        [TestMethod]
        public void ProbarTipoModuloAltaDocente()
        {
            // Creamos el abmDocente para gestionar docentes
            MantenimientoDocente Docente = new GestionDocente.MantenimientoDocente();
            // Creamos un docente utilizando el abmDocente.AltaDatosDocente
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "1234", materias);

            // Validamos si el docente creado es del tipo Docente
            Assert.IsInstanceOfType(docente, typeof(Docente));
        }
    }
}
