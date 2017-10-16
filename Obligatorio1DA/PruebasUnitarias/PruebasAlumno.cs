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
        [TestMethod]
        public void ProbarDatosTipoModuloGestionAlumno()
        {
            Assert.AreEqual("Gestion Alumno", mantenimientoAlumno.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Alumnos", mantenimientoAlumno.Descripcion);
        }
        [TestMethod]
        public void ProbarTipoModuloAltaAlumno()
        {
            MantenimientoAlumno Alumno = new GestionAlumno.MantenimientoAlumno();
            List<string> materias = new List<string>();
            Alumno alumno = mantenimientoAlumno.AltaDatosAlumno("Nombre del Alumno", "Apellido del Alumno", "1000", materias);
            Assert.IsInstanceOfType(alumno, typeof(Alumno));
        }
    }
}
