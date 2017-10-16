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
            List<string> materias = new List<string>();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "1234", materias);
            Assert.IsInstanceOfType(docente, typeof(Docente));
        }

        [TestMethod]
        public void ProbarDatosAltaDocenteNombre()
        {
            List<string> materias = new List<string>();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "1234", materias);
            Assert.IsInstanceOfType(docente.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", docente.Nombre);
            Assert.AreEqual("Nombre del Docente", docente.Nombre);
        }
        [TestMethod]
        public void ProbarDatosAltaDocenteApellido()
        {
            List<string> materias = new List<string>();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "1234", materias);
            Assert.IsInstanceOfType(docente.Apellido, typeof(string));
            Assert.AreNotEqual("Apellido cualquiera", docente.Apellido);
            Assert.AreEqual("Apellido del Docente", docente.Apellido);
        }
        [TestMethod]
        public void ProbarDatosAltaDocenteCi()
        { 
            List<string> materias = new List<string>();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "1234", materias);
            Assert.IsInstanceOfType(docente.Ci, typeof(string));
            Assert.AreNotEqual("1111", docente.Ci);
            Assert.AreEqual("1234", docente.Ci);
        }
        [TestMethod]
        public void ProbarDatosAltaDocenteMaterias()
        {
            List<string> materias = new List<string>();
            List<string> materiasDiferentes = new List<string>();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "Apellido del Docente", "1234", materias);
            materias.Add("Aritmetica");
            materias.Add("Sistemas informaticos");
            materiasDiferentes.Add("Ingles");
            materiasDiferentes.Add("Dibujo");
            Assert.IsInstanceOfType(docente.Materias, typeof(List<string>));
            Assert.AreNotEqual(materiasDiferentes, docente.Materias);
            Assert.AreEqual(materias, docente.Materias);
        }
        [TestMethod]
        public void ProbarDatosBajaDocente()
        {
            MantenimientoDocente mantenimientoDocente = new GestionDocente.MantenimientoDocente();
            List<Docente> misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "111", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "1231", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "1234", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro", "Gonzalez", "333", new List<string>()));
            CollectionAssert.AreEqual(misDocentes, mantenimientoDocente.GetDocentes());
            mantenimientoDocente.BajaDocente("1234");
            CollectionAssert.AreNotEqual(misDocentes, mantenimientoDocente.GetDocentes());

        }
        [TestMethod]
        public void ProbarDatosBajaDocenteNoExiste()
        {
            MantenimientoDocente mantenimientoDocente = new GestionDocente.MantenimientoDocente();
            List<Docente> misDocentes = new List<Docente>();
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "111", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "1231", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "1234", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro", "Gonzalez", "333", new List<string>()));
            CollectionAssert.AreEqual(misDocentes, mantenimientoDocente.GetDocentes());
            mantenimientoDocente.BajaDocente("123466");
            CollectionAssert.AreEqual(misDocentes, mantenimientoDocente.GetDocentes());
        }
        [TestMethod]
        public void TestModificacionDocente()
        {

            // Creamos un nuevo docente para modificar
            Docente nuevosValoresDocente = new Docente();
            nuevosValoresDocente.Nombre = "Juan Daniel";
            nuevosValoresDocente.Apellido = "Perez";
            nuevosValoresDocente.Ci = "111";
            nuevosValoresDocente.Materias[0] = "Matematicas";
            nuevosValoresDocente.Materias[1] = "Informatica";
            // Modificamos el docente con CI 111 (docentes[0]) con los nuevos valores del docente
            mantenimientoDocente.ModificarDocente("111", nuevosValoresDocente);

            // Validamos que el nombre del docente modificado es igual al nuevo nombre asignado
            Assert.AreEqual("Juan Daniel", docentes[0].Nombre);
        }
        public void GenerarDatos()
        {
            // Creamos el abmDocente para gestionar docentes
            mantenimientoDocente = new GestionDocente.MantenimientoDocente();

            // Creamos una lista de docentes para realizar las validaciones
            misDocentes = new List<Docente>();

            // Agrego Docentes con AltaDatosDocente para tener una lista
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "111", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "1231", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "1234", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro","Gonzalez", "333", new List<string>()));

            docentes = mantenimientoDocente.GetDocentes();
        }
    }
}
