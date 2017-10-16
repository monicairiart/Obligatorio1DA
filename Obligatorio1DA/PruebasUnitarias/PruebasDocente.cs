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
            // Creamos el abmDocente para gestionar docentes
            MantenimientoDocente mantenimientoDocente = new GestionDocente.MantenimientoDocente();

            // Creamos una lista de docentes para realizar las validaciones
            List<Docente> misDocentes = new List<Docente>();
            // Agrego Docentes con AltaDatosDocente para tener una lista
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Juan Pablo", "Perez", "111", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Pedro", "Malan", "1231", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Horacio", "Gabriel", "1234", new List<string>()));
            misDocentes.Add(mantenimientoDocente.AltaDatosDocente("Alejandro", "Gonzalez", "333", new List<string>()));

            Console.WriteLine("Docentes Creados > " + mantenimientoDocente.GetDocentes().Count);
            Console.WriteLine("Docentes en misDocentes > " + misDocentes.Count);
            Console.WriteLine("Docentes del ABM-mantenimientoDocente > " + mantenimientoDocente.GetDocentes().ToString());
            Console.WriteLine("Docentes mi lista > " + misDocentes.ToString());

            // Valido que antes de eliminar un docente, ambas listas son iguales
            CollectionAssert.AreEqual(misDocentes, mantenimientoDocente.GetDocentes());
            
            // Damos de baja al docente con CI 123466 que no existe
            mantenimientoDocente.BajaDocente("123466");
            Console.WriteLine("Docentes actuales > " + mantenimientoDocente.GetDocentes().Count);
            // Validamos que las listas ahora son diferentes
            CollectionAssert.AreEqual(misDocentes, mantenimientoDocente.GetDocentes());
            
            // Damos de baja al docente con CI 1234
            mantenimientoDocente.BajaDocente("1234");
            Console.WriteLine("Docentes actuales > " + mantenimientoDocente.GetDocentes().Count);
            // Validamos que las listas ahora son diferentes
            CollectionAssert.AreNotEqual(misDocentes, mantenimientoDocente.GetDocentes());

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
