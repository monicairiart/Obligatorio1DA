using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interfaces;
using GestionActividad;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasActividad
    {
        public MantenimientoActividad  mantenimientoActividad { get; set; }
        public List<Actividad> actividades { get; set; }
        public List<Actividad> misActividades { get; set; }
        public PruebasActividad()
        {
            mantenimientoActividad = new MantenimientoActividad();
            GenerarDatos();
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
            List<string> alumnos = new List<string>();
            Actividad actividad = mantenimientoActividad.AltaDatosActividad("1", "Nombre de la Actividad", new DateTime(2017, 01, 22), 100, alumnos);
            Assert.IsInstanceOfType(actividad, typeof(Actividad));
        }
        [TestMethod]
        public void ProbarDatosAltaActividadNombre()
        {
            List<string> alumnos = new List<string>();
            Actividad actividad = mantenimientoActividad.AltaDatosActividad("10", "Nombre de la Actividad",new DateTime(2017, 01, 22), 100, alumnos);
            Assert.IsInstanceOfType(actividad.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", actividad.Nombre);
            Assert.AreEqual("Nombre de la Actividad", actividad.Nombre);
        }
        [TestMethod]
        public void ProbarDatosAltaActividadCodigo()
        {
            List<string> alumnos = new List<string>();
            Actividad actividad = mantenimientoActividad.AltaDatosActividad("11", "Nombre de la Actividad", new DateTime(2017, 01, 22), 100, alumnos);
            Assert.IsInstanceOfType(actividad.Nombre, typeof(string));
            Assert.AreNotEqual("22", actividad.CodigoActividad);
            Assert.AreEqual("11", actividad.CodigoActividad);
        }
        [TestMethod]
        public void ProbarDatosAltaActividadAlumnos()
        {
            List<string> alumnosDiferentes = new List<string>();
            List<string> alumnos = new List<string>();
            Actividad actividad = mantenimientoActividad.AltaDatosActividad("13", "Nombre de la Actividad", new DateTime(2017, 01, 22), 100, alumnos);
            alumnos.Add("50001002");
            alumnos.Add("49912233");
            alumnosDiferentes.Add("38824456");
            Assert.IsInstanceOfType(actividad.Alumnos, typeof(List<string>));
            Assert.AreNotEqual(alumnosDiferentes, actividad.Alumnos);
            Assert.AreEqual(alumnos, actividad.Alumnos);
            mantenimientoActividad.BajarActividad("13");
        }
        [TestMethod]
        public void ProbarDatosBajaActividad()
        {
            misActividades.Add(mantenimientoActividad.AltaDatosActividad("14","Cine1", new DateTime(2017, 01, 22), 100, new List<string>()));
            CollectionAssert.AreNotEqual(misActividades, actividades);
            mantenimientoActividad.BajarActividad("14");
            CollectionAssert.AreEqual(mantenimientoActividad.ObtenerActividades(), actividades);
        }
        [TestMethod]
        public void ProbarDatosBajaActividadNoExiste()
        {
            misActividades.Add(mantenimientoActividad.AltaDatosActividad("15", "Cine2", new DateTime(2017, 01, 22), 100, new List<string>()));
            CollectionAssert.AreNotEqual(misActividades, actividades);
            mantenimientoActividad.BajarActividad("16");
            CollectionAssert.AreNotEqual(misActividades, actividades);
            mantenimientoActividad.BajarActividad("15");
        }
        [TestMethod]
        public void ProbarModificacionActividadNombre()
        {
            misActividades.Add(mantenimientoActividad.AltaDatosActividad("14", "Cine", new DateTime(2017, 01, 22), 100, new List<string>()));
            Actividad nuevosValoresActividad = new Actividad();
            nuevosValoresActividad.Nombre = "Manualidades";
            nuevosValoresActividad.CodigoActividad = "14";
            mantenimientoActividad.ModificarActividad("14", nuevosValoresActividad);
            Assert.AreEqual("Manualidades", mantenimientoActividad.ObtenerActividadPorCodigo("14").Nombre);
            mantenimientoActividad.BajarActividad("14");
        }
        [TestMethod]
        public void ProbarAsignarAlumnoAActividad()
        {
            actividades = mantenimientoActividad.ObtenerActividades();
            string ciAlumno = "39937650";
            string codigoActividad = "4";
            actividades = AsignacionActividad.AsignarAlumnoAActividad(actividades, ciAlumno, codigoActividad);
            Actividad actividad = mantenimientoActividad.ObtenerActividadPorCodigo(codigoActividad);
            string ciAlumnoEncontrado = actividad.Alumnos.Find(ci => ci == ciAlumno);
            Assert.AreEqual(ciAlumno, ciAlumnoEncontrado);
        }
        public void GenerarDatos()
        {
            misActividades = new List<Actividad>();
            Actividad actividad;
            actividad = new Actividad() { CodigoActividad = "1", Nombre = "Cine", Fecha = new DateTime(2017, 01, 02), Costo = 100, Alumnos = new List<string>() };
            misActividades.Add(actividad);
            mantenimientoActividad.AltaDatosActividad(actividad.CodigoActividad, actividad.Nombre, actividad.Fecha, actividad.Costo, actividad.Alumnos);
            actividad = new Actividad() { CodigoActividad = "2", Nombre = "Teatro", Fecha = new DateTime(2017, 10, 21), Costo = 150, Alumnos = new List<string>() };
            misActividades.Add(actividad);
            mantenimientoActividad.AltaDatosActividad(actividad.CodigoActividad, actividad.Nombre, actividad.Fecha, actividad.Costo, actividad.Alumnos);
            actividad = new Actividad() { CodigoActividad = "3", Nombre = "Campus", Fecha = new DateTime(2017, 11, 10), Costo = 200, Alumnos = new List<string>() };
            misActividades.Add(actividad);
            mantenimientoActividad.AltaDatosActividad(actividad.CodigoActividad, actividad.Nombre, actividad.Fecha, actividad.Costo, actividad.Alumnos);
            actividad = new Actividad() { CodigoActividad = "3", Nombre = "Ajedrez", Fecha = new DateTime(2017, 05, 23), Costo = 300, Alumnos = new List<string>() };
            misActividades.Add(actividad);
            mantenimientoActividad.AltaDatosActividad(actividad.CodigoActividad, actividad.Nombre, actividad.Fecha, actividad.Costo, actividad.Alumnos);
            actividades = mantenimientoActividad.ObtenerActividades();
        }
    }
}
