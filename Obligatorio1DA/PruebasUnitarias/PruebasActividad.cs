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

        public PruebasActividad()
        {
            mantenimientoActividad = new MantenimientoActividad();
//            mantenimientoActividad.GenerarDatos();
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
            MantenimientoActividad Actividad = new GestionActividad.MantenimientoActividad();
            List<string> alumnos = new List<string>();
            Actividad actividad = mantenimientoActividad.AltaDatosActividad("1", "Nombre de la Actividad", new DateTime(2017, 01, 22), 100, alumnos);
            Assert.IsInstanceOfType(actividad, typeof(Actividad));
        }
        [TestMethod]
        public void ProbarDatosAltaActividadNombre()
        {
            List<string> alumnos = new List<string>();
            Actividad actividad = mantenimientoActividad.AltaDatosActividad("1", "Nombre de la Actividad",new DateTime(2017, 01, 22), 100, alumnos);
            Assert.IsInstanceOfType(actividad.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", actividad.Nombre);
            Assert.AreEqual("Nombre de la Actividad", actividad.Nombre);
        }
        [TestMethod]
        public void ProbarDatosAltaActividadCodigo()
        {
            List<string> alumnos = new List<string>();
            Actividad actividad = mantenimientoActividad.AltaDatosActividad("1", "Nombre de la Actividad", new DateTime(2017, 01, 22), 100, alumnos);
            Assert.IsInstanceOfType(actividad.Nombre, typeof(string));
            Assert.AreNotEqual("2", actividad.CodigoActividad);
            Assert.AreEqual("1", actividad.CodigoActividad);
        }
        [TestMethod]
        public void ProbarDatosAltaActividadAlumnos()
        {
            List<string> alumnosDiferentes = new List<string>();
            List<string> alumnos = new List<string>();
            Actividad actividad = mantenimientoActividad.AltaDatosActividad("1", "Nombre de la Actividad", new DateTime(2017, 01, 22), 100, alumnos);
            alumnos.Add("50001002");
            alumnos.Add("49912233");
            alumnosDiferentes.Add("38824456");
            Assert.IsInstanceOfType(actividad.Alumnos, typeof(List<string>));
            Assert.AreNotEqual(alumnosDiferentes, actividad.Alumnos);
            Assert.AreEqual(alumnos, actividad.Alumnos);
        }
        public void ProbarDatosBajaActividad()
        {
            MantenimientoActividad mantenimientoActividad = new GestionActividad.MantenimientoActividad();
            List<Actividad> misActividades = new List<Actividad>();
            misActividades.Add(mantenimientoActividad.AltaDatosActividad("1","Cine", new DateTime(2017, 01, 22), 100, new List<string>()));
            /*misMaterias.Add(mantenimientoMateria.AltaDatosMateria("222","Lógica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("333","Etica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("444", "Algebra", new List<string>(), new List<string>()));
            */
            Console.WriteLine("count de obtener actividades " + mantenimientoActividad.ObtenerActividades().Count);
            CollectionAssert.AreEqual(misActividades, mantenimientoActividad.ObtenerActividades());
            mantenimientoActividad.BajarActividad("1");
            CollectionAssert.AreNotEqual(misActividades, mantenimientoActividad.ObtenerActividades());
        }
    }
}
