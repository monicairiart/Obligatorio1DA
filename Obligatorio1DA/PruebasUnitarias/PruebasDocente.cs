using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionDocente;
using Interfaces;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasDocente
    {
        public MantenimientoDocente mantenimientoDocente { get; set; }
        public List<Docente> docentes { get; set; }
        public List<Docente> misDocentes { get; set; }
        public PruebasDocente()
        {
            mantenimientoDocente = new MantenimientoDocente();
            GenerarDatos();
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
            MantenimientoDocente Docente = new GestionDocente.MantenimientoDocente();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "35466661");
            Assert.IsInstanceOfType(docente, typeof(Docente));
        }
        [TestMethod]
        public void ProbarAltaDocente()
        {
            Docente docente = mantenimientoDocente.AltaDatosDocente("Miguel", "Sosa", "111");
            Assert.IsInstanceOfType(docente, typeof(Docente));
            Assert.AreEqual("Miguel", docente.Nombre);
            Assert.AreEqual("Sosa", docente.Apellido);
            Assert.AreEqual("111", docente.Ci);
            mantenimientoDocente.BajarDocente("111");
        }
        [TestMethod]
        public void ProbarDatosAltaDocenteNombre()
        {
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "11111111");
            Console.WriteLine("nombre del docente " + docente.Nombre);
            Assert.IsInstanceOfType(docente.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", docente.Nombre);
            Assert.AreEqual("Nombre del Docente", docente.Nombre);
            mantenimientoDocente.BajarDocente("11111111");
        }
        [TestMethod]
        public void ProbarDatosAltaDocenteApellido()
        {
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "11111111");
            Assert.IsInstanceOfType(docente.Apellido, typeof(string));
            Assert.AreNotEqual("Apellido cualquiera", docente.Apellido);
            Assert.AreEqual("Apellido del Docente", docente.Apellido);
            mantenimientoDocente.BajarDocente("11111111");
        }
        [TestMethod]
        public void ProbarDatosAltaDocenteCi()
        {
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "11111111");
            Assert.IsInstanceOfType(docente.Ci, typeof(string));
            Assert.AreNotEqual("1111", docente.Ci);
            Assert.AreEqual("11111111", docente.Ci);
            mantenimientoDocente.BajarDocente("11111111");
        }
        [TestMethod]
        public void ProbarDatosBajaDocente()
        {
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Jose", "Lugano", "11111111"));
            CollectionAssert.AreNotEqual(misDocentes, docentes);
            mantenimientoDocente.BajarDocente("11111111");
            CollectionAssert.AreEqual(mantenimientoDocente.ObtenerDocentes(), docentes);
        }
        [TestMethod]
        public void ProbarDatosBajaDocenteNoExiste()
        {
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Jose", "Lugano", "11111111"));
            CollectionAssert.AreNotEqual(misDocentes, docentes);
            mantenimientoDocente.BajarDocente("123466");
            CollectionAssert.AreEqual(mantenimientoDocente.ObtenerDocentes(), docentes);
        }
        [TestMethod]
        public void ProbarModificacionDocenteNombre()
        {
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Jose", "Lugano", "11111111"));
            Docente nuevosValoresDocente = new Docente();
            nuevosValoresDocente.Nombre = "Juan Daniel";
            nuevosValoresDocente.Apellido = "Lugano";
            nuevosValoresDocente.Ci = "11111111";
            mantenimientoDocente.ModificarDocente("11111111", nuevosValoresDocente);
            Assert.AreEqual("Juan Daniel", mantenimientoDocente.ObtenerDocentePorCi("11111111").Nombre);
            mantenimientoDocente.BajarDocente("11111111");
        }
        [TestMethod]
        public void ProbarModificacionDocenteApellido()
        {
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Jose", "Lugano", "11111111"));
            Docente nuevosValoresDocente = new Docente();
            nuevosValoresDocente.Nombre = "Juan Jose";
            nuevosValoresDocente.Apellido = "Perezo";
            nuevosValoresDocente.Ci = "11111111";
            mantenimientoDocente.ModificarDocente("11111111", nuevosValoresDocente);
            Assert.AreEqual("Perezo", mantenimientoDocente.ObtenerDocentePorCi("11111111").Apellido);
            Console.WriteLine("nvos valor apellido " + misDocentes[0].Apellido);
            mantenimientoDocente.BajarDocente("11111111");
        }
        [TestMethod]
        public void ProbarModificacionDocenteCi()
        {
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Jose", "Lugano", "11111111"));
            Docente nuevosValoresDocente = new Docente();
            nuevosValoresDocente.Ci = "1212";
            nuevosValoresDocente.Nombre = "Juan Jose";
            nuevosValoresDocente.Apellido = "Lugano";
            mantenimientoDocente.ModificarDocente("11111111", nuevosValoresDocente);
            Assert.AreEqual("1212", mantenimientoDocente.ObtenerDocentePorCi("1212").Ci);
            Console.WriteLine("nvos valor ci " + misDocentes[0].Ci);
            mantenimientoDocente.BajarDocente("1212");
        }
        [TestMethod]
        public void ProbarDocenteExistente()
        {
            MantenimientoDocente mantenimientoDocente = new GestionDocente.MantenimientoDocente();
            List<Docente> misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            Assert.IsTrue(mantenimientoDocente.DocenteExistente("38667442"));
        }
        [TestMethod]
        public void ProbarObtenerDocente()
        {
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Jose", "Lugano", "11111111"));
            Assert.AreEqual("11111111", mantenimientoDocente.ObtenerDocentePorCi("11111111").Ci);
            mantenimientoDocente.BajarDocente("11111111");
        }
        [TestMethod]
        public void ProbarGenerarDatos()
        {
            List<Docente> docentesPrueba = new List<Docente>();
            docentesPrueba = mantenimientoDocente.ObtenerDocentes();
            mantenimientoDocente.GenerarDatos();
            CollectionAssert.AreEqual(docentesPrueba, mantenimientoDocente.ObtenerDocentes());
        }
        public void GenerarDatos()
        {
            misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "51112145"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "35466661"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro","Gonzalez", "42227230"));
            docentes = mantenimientoDocente.ObtenerDocentes();
        }
    }
}