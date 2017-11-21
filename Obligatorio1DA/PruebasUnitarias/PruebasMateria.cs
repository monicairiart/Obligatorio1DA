using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionMateria;
using Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasMateria
    {
        public MantenimientoMateria mantenimientoMateria { get; set; }
        public List<Materia> materias { get; set; }
        public List<Materia> misMaterias { get; set; }
        public List<Materia> materiasPrueba { get; set; }
        public PruebasMateria()
        {
            mantenimientoMateria = new MantenimientoMateria();
            GenerarDatos();
        }
        [TestMethod]
        public void ProbarTipoModuloGestionMateria()
        {
            Assert.IsInstanceOfType(mantenimientoMateria, typeof(IModuloGestion));
        }
        [TestMethod]
        public void ProbarDatosTipoModuloGestionMateria()
        {
            Assert.AreEqual("Gestion Materia", mantenimientoMateria.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Materias", mantenimientoMateria.Descripcion);
        }
        [TestMethod]
        public void ProbarTipoModuloAltaMateria()
        {
            List<string> docentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria("111", "Nombre de la Materia", docentes, alumnos);
            Assert.IsInstanceOfType(materia, typeof(Materia));
            mantenimientoMateria.BajarMateria("111");
        }
        [TestMethod]
        public void ProbarDatosAltaMateriaNombre()
        {
            List<string> docentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria("1112", "Nombre de la Materia", docentes, alumnos);
            Assert.IsInstanceOfType(materia.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", materia.Nombre);
            Assert.AreEqual("Nombre de la Materia", materia.Nombre);
            mantenimientoMateria.BajarMateria("1112");
        }
        [TestMethod]
        public void ProbarDatosAltaMateriaCodigo()
        {
            List<string> docentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria("1113", "Nombre de la Materia", docentes, alumnos);
            Assert.IsInstanceOfType(materia.Nombre, typeof(string));
            Assert.AreNotEqual("222", materia.CodigoMateria);
            Assert.AreEqual("1113", materia.CodigoMateria);
            mantenimientoMateria.BajarMateria("1113");
        }
        [TestMethod]
        public void ProbarDatosAltaMateriaDocentes()
        {
            List<string> docentes = new List<string>();
            List<string> docentesDiferentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria("1114","Nombre de la Materia", docentes, alumnos);
            docentes.Add("38667442");
            docentes.Add("51112145");
            docentesDiferentes.Add("35466661");
            docentesDiferentes.Add("42227230");
            alumnos.Add("50001002");
            Assert.IsInstanceOfType(materia.Docentes, typeof(List<string>));
            Assert.AreNotEqual(docentesDiferentes, materia.Docentes);
            Assert.AreEqual(docentes, materia.Docentes);
            mantenimientoMateria.BajarMateria("1114");
        }
        [TestMethod]
        public void ProbarDatosAltaMateriaAlumnos()
        {
            List<string> docentes = new List<string>();
            List<string> alumnosDiferentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria("1115", "Nombre de la Materia", docentes, alumnos);
            docentes.Add("38667442");
            docentes.Add("51112145");
            alumnos.Add("50001002");
            alumnos.Add("49912233");
            alumnosDiferentes.Add("38824456");
            Assert.IsInstanceOfType(materia.Alumnos, typeof(List<string>));
            Assert.AreNotEqual(alumnosDiferentes, materia.Alumnos);
            Assert.AreEqual(alumnos, materia.Alumnos);
            mantenimientoMateria.BajarMateria("1115");
        }
        [TestMethod]
        public void ProbarDatosBajaMateria()
        {
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("1111", "Musica", new List<string>(), new List<string>()));
            CollectionAssert.AreNotEqual(misMaterias, materias);
            mantenimientoMateria.BajarMateria("1111");
            misMaterias.OrderBy((m) => m);
            CollectionAssert.AreEqual(mantenimientoMateria.ObtenerMaterias(), materias);
       }
        [TestMethod]
        public void ProbarDatosBajaMateriaNoExiste()
        {
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("1111", "Musica", new List<string>(), new List<string>()));
            CollectionAssert.AreNotEqual(misMaterias, materias);
            mantenimientoMateria.BajarMateria("111122");
            CollectionAssert.AreEqual(mantenimientoMateria.ObtenerMaterias(), materias);
        }
        [TestMethod]
        public void ProbarModificacionMateriaNombre()
        {
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("1114", "Arte", new List<string>(), new List<string>()));
            Materia nuevosValoresMateria = new Materia();
            nuevosValoresMateria.Nombre = "Geografía";
            nuevosValoresMateria.CodigoMateria = "1114";
            mantenimientoMateria.ModificarMateria("1114", nuevosValoresMateria);
            Assert.AreEqual("Geografía", mantenimientoMateria.ObtenerMateriaPorCodigo("1114").Nombre);
            mantenimientoMateria.BajarMateria("1114");
        }
        [TestMethod]
        public void ProbarAsignarDocenteAMateria()
        {
            mantenimientoMateria.AltaDatosMateria("555", "Arte", new List<string>(), new List<string>());
            materias = mantenimientoMateria.ObtenerMaterias();
            string ciDocente = "38667442";
            string codigoMateria = "555";
            materias = AsignacionMateria.AsignarDocenteAMateria(materias, ciDocente, codigoMateria);
            Materia materia = mantenimientoMateria.ObtenerMateriaPorCodigo(codigoMateria);
            string ciDocenteEncontrado = materia.Docentes.Find(ci => ci == ciDocente);
            Assert.AreEqual(ciDocente, ciDocenteEncontrado);
            mantenimientoMateria.BajarMateria("555");
        }
        [TestMethod]
        public void ProbarAsignarAlumnoAMateria()
        {
            materias = mantenimientoMateria.ObtenerMaterias();
            string ciAlumno = "50001002";
            string codigoMateria = "111";
            materias = AsignacionMateria.AsignarAlumnoAMateria(materias, ciAlumno, codigoMateria);
            Materia materia = mantenimientoMateria.ObtenerMateriaPorCodigo(codigoMateria);
            string ciAlumnoEncontrado = materia.Alumnos.Find(ci => ci == ciAlumno);
            Assert.AreEqual(ciAlumno, ciAlumnoEncontrado);
        }
        [TestMethod]
        public void ProbarMateriaExistente()
        {
            Assert.IsTrue(mantenimientoMateria.MateriaExistente("111"));
        }
        [TestMethod]
        public void ProbarObtenerMateriasPorAlumno()
        {
            materias = mantenimientoMateria.ObtenerMaterias();
            string ciAlumno = "50001002";
            string codigoMateria = "444";
            materias = AsignacionMateria.AsignarAlumnoAMateria(materias, ciAlumno, codigoMateria);
            Materia materia = mantenimientoMateria.ObtenerMateriaPorCodigo(codigoMateria);
            Assert.AreEqual(mantenimientoMateria.ObtenerMateriasPorAlumno(ciAlumno)[0].CodigoMateria, codigoMateria);
        }

        public void GenerarDatos()
        {
            misMaterias = new List<Materia>();
            Materia materia;
            materia = new Materia() { CodigoMateria = "111", Nombre = "Matematicas", Alumnos = new List<string>(), Docentes = new List<string>() };
            misMaterias.Add(materia);
            mantenimientoMateria.AltaDatosMateria(materia.CodigoMateria, materia.Nombre, materia.Alumnos, materia.Docentes);
            materia = new Materia() { CodigoMateria = "444", Nombre = "Algebra", Alumnos = new List<string>(), Docentes = new List<string>() };
            misMaterias.Add(materia);
            mantenimientoMateria.AltaDatosMateria(materia.CodigoMateria, materia.Nombre, materia.Alumnos, materia.Docentes);
            materia = new Materia() { CodigoMateria = "333", Nombre = "Etica", Alumnos = new List<string>(), Docentes = new List<string>() };
            misMaterias.Add(materia);
            mantenimientoMateria.AltaDatosMateria(materia.CodigoMateria, materia.Nombre, materia.Alumnos, materia.Docentes);
            materia = new Materia() { CodigoMateria = "222", Nombre = "Logica", Alumnos = new List<string>(), Docentes = new List<string>() };
            misMaterias.Add(materia);
            mantenimientoMateria.AltaDatosMateria(materia.CodigoMateria, materia.Nombre, materia.Alumnos, materia.Docentes);
            materias = mantenimientoMateria.ObtenerMaterias();
        }
    }
}
