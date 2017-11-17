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
        public void PruebasDocentes()
        {
            GenerarDatos();
        }
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
            MantenimientoDocente Docente = new GestionDocente.MantenimientoDocente();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "35466661");
            Assert.IsInstanceOfType(docente, typeof(Docente));
        }

        [TestMethod]
        public void ProbarDatosAltaDocenteNombre()
        {
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "35466661");
            Assert.IsInstanceOfType(docente.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", docente.Nombre);
            Assert.AreEqual("Nombre del Docente", docente.Nombre);
        }
        [TestMethod]
        public void ProbarDatosAltaDocenteApellido()
        {
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "35466661");
            Console.WriteLine("docente apellido " + docente.Apellido);
            Assert.IsInstanceOfType(docente.Apellido, typeof(string));
            Assert.AreNotEqual("Apellido cualquiera", docente.Apellido);
            Assert.AreEqual("Apellido del Docente", docente.Apellido);
        }
        [TestMethod]
        public void ProbarDatosAltaDocenteCi()
        {
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "35466661");
            Console.WriteLine("docente ci " + docente.Ci);
            Assert.IsInstanceOfType(docente.Ci, typeof(string));
            Assert.AreNotEqual("1111", docente.Ci);
            Assert.AreEqual("35466661", docente.Ci);
        }
        [TestMethod]
        public void ProbarDatosBajaDocente()
        {
            MantenimientoDocente mantenimientoDocente = new GestionDocente.MantenimientoDocente();
            List<Docente> misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "51112145"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "35466661"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro", "Gonzalez", "42227230"));
            CollectionAssert.AreEqual(misDocentes, mantenimientoDocente.ObtenerDocentes());
            mantenimientoDocente.BajarDocente("35466661");
            CollectionAssert.AreNotEqual(misDocentes, mantenimientoDocente.ObtenerDocentes());

        }
        [TestMethod]
        public void ProbarDatosBajaDocenteNoExiste()
        {
            MantenimientoDocente mantenimientoDocente = new GestionDocente.MantenimientoDocente();
            List<Docente> misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "51112145"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "35466661"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro", "Gonzalez", "42227230"));
            CollectionAssert.AreEqual(misDocentes, mantenimientoDocente.ObtenerDocentes());
            mantenimientoDocente.BajarDocente("123466");
            CollectionAssert.AreEqual(misDocentes, mantenimientoDocente.ObtenerDocentes());
        }
        [TestMethod]
        public void ProbarModificacionDocenteNombre()
        {
            List<Docente> misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "51112145"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "35466661"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro", "Gonzalez", "42227230"));
            Docente nuevosValoresDocente = new Docente();
            nuevosValoresDocente.Nombre = "Juan Daniel";
            mantenimientoDocente.ModificarDocente("38667442", nuevosValoresDocente);
            Assert.AreEqual("Juan Daniel", misDocentes[0].Nombre);
            Console.WriteLine("nvos valor nombre " + misDocentes[0].Nombre);
        }
        [TestMethod]
        public void ProbarModificacionDocenteApellido()
        {
            List<Docente> misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "51112145"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "35466661"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro", "Gonzalez", "42227230"));
            Docente nuevosValoresDocente = new Docente();
            nuevosValoresDocente.Apellido = "Perezo";
            mantenimientoDocente.ModificarDocente("38667442", nuevosValoresDocente);
            Assert.AreEqual("Perezo", misDocentes[0].Apellido);
            Console.WriteLine("nvos valor apellido " + misDocentes[0].Apellido);
        }
        [TestMethod]
        public void ProbarModificacionDocenteCi()
        {
            List<Docente> misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "51112145"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "35466661"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro", "Gonzalez", "42227230"));
            Docente nuevosValoresDocente = new Docente();
            nuevosValoresDocente.Ci = "1212";
            mantenimientoDocente.ModificarDocente("38667442", nuevosValoresDocente);
            Assert.AreEqual("1212", misDocentes[0].Ci);
            Console.WriteLine("nvos valor ci " + misDocentes[0].Ci);
        }
        [TestMethod]
        public void ProbarDocenteExistente()
        {
            MantenimientoDocente mantenimientoDocente = new GestionDocente.MantenimientoDocente();
            List<Docente> misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            Assert.IsTrue(mantenimientoDocente.DocenteExistente("38667442"));
        }
        public void ProbarObtenerDocente()
        {
            MantenimientoDocente mantenimientoDocente = new GestionDocente.MantenimientoDocente();
            List<Docente> misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "51112145"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "35466661"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro", "Gonzalez", "42227230"));
            CollectionAssert.AreEqual(misDocentes, mantenimientoDocente.ObtenerDocentes());
        }
        [TestMethod]
        public void ProbarGenerarDatos()
        {
            List<Docente> docentesPrueba = new List<Docente>();
            MantenimientoDocente mantenimientoDocente = new GestionDocente.MantenimientoDocente();
            docentesPrueba.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            docentesPrueba.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "51112145"));
            docentesPrueba.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "35466661"));
            docentesPrueba.Add(mantenimientoDocente.AltaDatosDocente("Alejandro", "Gonzalez", "42227230"));
            mantenimientoDocente.GenerarDatos();
            CollectionAssert.AreEqual(docentesPrueba, mantenimientoDocente.ObtenerDocentes());
        }
        [TestMethod]
        public void GenerarDatos()
        {
            mantenimientoDocente = new GestionDocente.MantenimientoDocente();
            misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "51112145"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "35466661"));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro","Gonzalez", "42227230"));
            docentes = mantenimientoDocente.ObtenerDocentes();
        }
    }
}
