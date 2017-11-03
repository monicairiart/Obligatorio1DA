using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionMateria;
using Interfaces;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasMateria
    {
        public MantenimientoMateria mantenimientoMateria { get; set; }
        public List<Materia> materias { get; set; }
        public List<Materia> misMaterias { get; set; }
        public void PruebasMaterias()
        {
            GenerarDatos();
        }
        public PruebasMateria()
        {
            mantenimientoMateria = new MantenimientoMateria();
        }
        [TestMethod]
        public void ProbarTipoModuloGestionMateria()
        {

            Assert.IsInstanceOfType(mantenimientoMateria, typeof(IModuloGestion));
        }
        public void ProbarDatosTipoModuloGestionMateria()
        {
            Assert.AreEqual("Gestion Materia", mantenimientoMateria.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Materias", mantenimientoMateria.Descripcion);
        }
        [TestMethod]
        public void ProbarTipoModuloAltaMateria()
        {
            MantenimientoMateria Materia = new GestionMateria.MantenimientoMateria();
            List<string> docentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria(11, "Nombre de la Materia", docentes, alumnos);
            Assert.IsInstanceOfType(materia, typeof(Materia));
        }
        [TestMethod]
        public void ProbarDatosAltaMateriaNombre()
        {
            List<string> docentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria(111, "Nombre de la Materia", docentes, alumnos);
            Assert.IsInstanceOfType(materia.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", materia.Nombre);
            Assert.AreEqual("Nombre de la Materia", materia.Nombre);
        }
        [TestMethod]
        public void ProbarDatosAltaMateriaCodigo()
        {
            List<string> docentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria(111, "Nombre de la Materia", docentes, alumnos);
            Assert.IsInstanceOfType(materia.Nombre, typeof(string));
            Assert.AreNotEqual(222, materia.CodigoMateria);
            Assert.AreEqual(111, materia.CodigoMateria);
        }
        [TestMethod]
        public void ProbarDatosAltaMateriaDocentes()
        {
            List<string> docentes = new List<string>();
            List<string> docentesDiferentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria(111,"Nombre de la Materia", docentes, alumnos);
            docentes.Add("Diego Medina");
            docentes.Add("Gustavo Laguna");
            docentesDiferentes.Add("Pablo Fernandez");
            docentesDiferentes.Add("Ana Gutierrez");
            alumnos.Add("Julio Sosa");
            Assert.IsInstanceOfType(materia.Docentes, typeof(List<string>));
            Assert.AreNotEqual(docentesDiferentes, materia.Docentes);
            Assert.AreEqual(docentes, materia.Docentes);
        }
        [TestMethod]
        public void ProbarDatosAltaMateriaAlumnos()
        {
            List<string> docentes = new List<string>();
            List<string> alumnosDiferentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria(111, "Nombre de la Materia", docentes, alumnos);
            docentes.Add("Diego Medina");
            docentes.Add("Gustavo Laguna");
            alumnos.Add("Julio Sosa");
            alumnos.Add("Pepe Cruz");
            alumnosDiferentes.Add("Rosa Fuentes");
            Assert.IsInstanceOfType(materia.Alumnos, typeof(List<string>));
            Assert.AreNotEqual(alumnosDiferentes, materia.Alumnos);
            Assert.AreEqual(alumnos, materia.Alumnos);
        }
        [TestMethod]
        public void ProbarDatosBajaMateria()
        {
            MantenimientoMateria mantenimientoMateria = new GestionMateria.MantenimientoMateria();
            List<Materia> misMaterias = new List<Materia>();
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(111,"Matematicas", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(222,"Lógica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(333,"Etica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(444, "Algebra", new List<string>(), new List<string>()));
            CollectionAssert.AreEqual(misMaterias, mantenimientoMateria.GetMaterias());
            mantenimientoMateria.BajaMateria(111);
            CollectionAssert.AreNotEqual(misMaterias, mantenimientoMateria.GetMaterias());

        }
        [TestMethod]
        public void ProbarDatosBajaMateriaNoExiste()
        {
            MantenimientoMateria mantenimientoMateria = new GestionMateria.MantenimientoMateria();
            List<Materia> misMaterias = new List<Materia>();
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(111, "Matematicas", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(222, "Lógica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(333, "Etica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(444, "Algebra", new List<string>(), new List<string>()));
            CollectionAssert.AreEqual(misMaterias, mantenimientoMateria.GetMaterias());
            mantenimientoMateria.BajaMateria(999);
        }
        [TestMethod]
        public void ProbarModificacionMateriaNombre()
        {
            // Creamos una lista de docentes para realizar las validaciones
            List<Materia> misMaterias = new List<Materia>();

            // Agrego Materias con AltaDatosMateria para tener una lista
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(111, "Matematicas", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(222, "Lógica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(333, "Etica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(444, "Algebra", new List<string>(), new List<string>()));
            // Creamos una nueva materia para modificar
            Materia nuevosValoresMateria = new Materia();
            nuevosValoresMateria.Nombre = "Geografía";
            mantenimientoMateria.ModificarMateria(111, nuevosValoresMateria);
            Assert.AreEqual("Geografía", misMaterias[0].Nombre);
            Console.WriteLine("nvos valor nombre " + misMaterias[0].Nombre);
        }
        [TestMethod]



        public void GenerarDatos()
        {
            // Creamos el abmDocente para gestionar docentes
            mantenimientoMateria = new GestionMateria.MantenimientoMateria();

            // Creamos una lista de docentes para realizar las validaciones
            misMaterias = new List<Materia>();

            // Agrego Docentes con AltaDatosDocente para tener una lista
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(111, "Matematicas", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(222, "Lógica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(333, "Etica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria(444, "Algebra", new List<string>(), new List<string>()));
            materias = mantenimientoMateria.GetMaterias();
        }
    }
}
