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
        public List<Materia> materiasPrueba { get; set; }
        public PruebasMateria()
        {
            mantenimientoMateria = new MantenimientoMateria();
            mantenimientoMateria.GenerarDatos();
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
            Materia materia = mantenimientoMateria.AltaDatosMateria("111", "Nombre de la Materia", docentes, alumnos);
            Assert.IsInstanceOfType(materia, typeof(Materia));
        }
        [TestMethod]
        public void ProbarDatosAltaMateriaNombre()
        {
            List<string> docentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria("111", "Nombre de la Materia", docentes, alumnos);
            Assert.IsInstanceOfType(materia.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", materia.Nombre);
            Assert.AreEqual("Nombre de la Materia", materia.Nombre);
        }
        [TestMethod]
        public void ProbarDatosAltaMateriaCodigo()
        {
            List<string> docentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria("111", "Nombre de la Materia", docentes, alumnos);
            Assert.IsInstanceOfType(materia.Nombre, typeof(string));
            Assert.AreNotEqual("222", materia.CodigoMateria);
            Assert.AreEqual("111", materia.CodigoMateria);
        }
        [TestMethod]
        public void ProbarDatosAltaMateriaDocentes()
        {
            List<string> docentes = new List<string>();
            List<string> docentesDiferentes = new List<string>();
            List<string> alumnos = new List<string>();
            Materia materia = mantenimientoMateria.AltaDatosMateria("111","Nombre de la Materia", docentes, alumnos);
            docentes.Add("38667442");
            docentes.Add("51112145");
            docentesDiferentes.Add("35466661");
            docentesDiferentes.Add("42227230");
            alumnos.Add("50001002");
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
            Materia materia = mantenimientoMateria.AltaDatosMateria("111", "Nombre de la Materia", docentes, alumnos);
            docentes.Add("38667442");
            docentes.Add("51112145");
            alumnos.Add("50001002");
            alumnos.Add("49912233");
            alumnosDiferentes.Add("38824456");
            Assert.IsInstanceOfType(materia.Alumnos, typeof(List<string>));
            Assert.AreNotEqual(alumnosDiferentes, materia.Alumnos);
            Assert.AreEqual(alumnos, materia.Alumnos);
        }
        [TestMethod]
        public void ProbarDatosBajaMateria()
        {
            MantenimientoMateria mantenimientoMateria = new GestionMateria.MantenimientoMateria();
            /*List<Materia> misMaterias = new List<Materia>();
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("111","Matematicas", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("222","Lógica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("333","Etica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("444", "Algebra", new List<string>(), new List<string>()));
            */
            Console.WriteLine("count de obtener materias " + mantenimientoMateria.ObtenerMaterias().Count);
            CollectionAssert.AreEqual(misMaterias, mantenimientoMateria.ObtenerMaterias());
            mantenimientoMateria.BajarMateria("111");
            CollectionAssert.AreNotEqual(misMaterias, mantenimientoMateria.ObtenerMaterias());
        }
        [TestMethod]
        public void ProbarDatosBajaMateriaNoExiste()
        {
            MantenimientoMateria mantenimientoMateria = new GestionMateria.MantenimientoMateria();
            /*List<Materia> misMaterias = new List<Materia>();
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("111", "Matematicas", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("222", "Lógica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("333", "Etica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("444", "Algebra", new List<string>(), new List<string>()));
            */
            Console.WriteLine("count mismaterias " + mantenimientoMateria.ObtenerMaterias().Count);
            CollectionAssert.AreEqual(misMaterias, mantenimientoMateria.ObtenerMaterias());
            mantenimientoMateria.BajarMateria("999");
            CollectionAssert.AreNotEqual(misMaterias, mantenimientoMateria.ObtenerMaterias());

        }
        [TestMethod]
        public void ProbarModificacionMateriaNombre()
        {
            // Creamos una lista de docentes para realizar las validaciones
            List<Materia> misMaterias = mantenimientoMateria.ObtenerMaterias();
            Materia nuevosValoresMateria = new Materia();
            nuevosValoresMateria.Nombre = "Geografía";
            mantenimientoMateria.ModificarMateria("111", nuevosValoresMateria);
            Assert.AreEqual("Geografía", misMaterias[0].Nombre);
            Console.WriteLine("nvos valor nombre " + misMaterias[0].Nombre);
        }
        [TestMethod]
        public void ProbarAsignarDocenteAMateria()
        {
            materias = mantenimientoMateria.ObtenerMaterias();
            string ciDocente = "38667442";
            string codigoMateria = "111";
            materias = AsignacionMateria.AsignarDocenteAMateria(materias, ciDocente, codigoMateria);
            Materia materia = mantenimientoMateria.ObtenerMateriaPorCodigo(codigoMateria);
            string ciDocenteEncontrado = materia.Docentes.Find(ci => ci == ciDocente);
            Assert.AreEqual(ciDocente, ciDocenteEncontrado);
        }
        [TestMethod]
        public void ProbarAsignarAlumnoAMateria()
        {
            materias = mantenimientoMateria.ObtenerMaterias();
            string ciAlumno = "50001002";
            string codigoMateria = "111";
            Console.WriteLine("entra a asignar alumno materia ");
            materias = AsignacionMateria.AsignarAlumnoAMateria(materias, ciAlumno, codigoMateria);
            Console.WriteLine("cant materias " + materias.Count);
            Materia materia = mantenimientoMateria.ObtenerMateriaPorCodigo(codigoMateria);
            string ciAlumnoEncontrado = materia.Alumnos.Find(ci => ci == ciAlumno);
            Console.WriteLine("alumno de la materia " + materia.Alumnos.ToString());
            Assert.AreEqual(ciAlumno, ciAlumnoEncontrado);
        }
        [TestMethod]
        public void ProbarObtenerMateriasPorAlumno()
        {
            materias = mantenimientoMateria.ObtenerMaterias();
            string ciAlumno = "50001002";
            string codigoMateria = "111";
            materias = AsignacionMateria.AsignarAlumnoAMateria(materias, ciAlumno, codigoMateria);
            Console.WriteLine("cant materias materiasxalumno " + materias.Count);

            Materia materia = mantenimientoMateria.ObtenerMateriaPorCodigo(codigoMateria);
            /*
             string ciAlumnoEncontrado = materia.Alumnos.Find(ci => ci == ciAlumno);
             Console.WriteLine("alumno de la materia " + materia.Alumnos.ToString());
             Assert.AreEqual(ciAlumno, ciAlumnoEncontrado);
             */
            Assert.AreEqual(mantenimientoMateria.ObtenerMateriasPorAlumno(ciAlumno), ciAlumno);
        }
        [TestMethod]
        public void ProbarGenerarDatos()
        {
            List<Materia> misMaterias = new List<Materia>();
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("111", "Matematicas", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("222", "Lógica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("333", "Etica", new List<string>(), new List<string>()));
            misMaterias.Add(mantenimientoMateria.AltaDatosMateria("444", "Algebra", new List<string>(), new List<string>()));
            CollectionAssert.AreEqual(misMaterias, mantenimientoMateria.ObtenerMaterias());
            materias = mantenimientoMateria.ObtenerMaterias();
            materias = AsignacionMateria.AsignarDocenteAMateria(materias, "38667442", "111");
            materias = AsignacionMateria.AsignarDocenteAMateria(materias, "51112145", "333");
            materias = AsignacionMateria.AsignarAlumnoAMateria(materias, "50001002", "111");
            materias = AsignacionMateria.AsignarAlumnoAMateria(materias, "49912233", "444");

        }
        /*public void GenerarDatos()
        {

        }*/

    }
}
