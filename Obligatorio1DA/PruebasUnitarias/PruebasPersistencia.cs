using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistencia;
using System.Data.Entity;
using GestionDocente;
using System.Linq;
using GestionAlumno;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasPersistencia
    {
        public ContextoDb contextoDb { get; set; }
        public MantenimientoDocente mantenimientoDocente { get; set; }

        public PruebasPersistencia()
        {
            contextoDb = new ContextoDb();
        }
        
        [TestMethod]
        public void ProbarContextoDb()
        {
            Assert.IsInstanceOfType(contextoDb, typeof(DbContext));
        }
        [TestMethod]
        public void ProbarConexionBaseDatos()
        {
            Assert.IsTrue(contextoDb.Database.Exists());
        }
        [TestMethod]
        public void ProbarAltaDocenteBaseDatos()
        {
            Docente nuevosValoresDocente = new Docente();
            List<Docente> docenteDb = new List<Docente>();
            nuevosValoresDocente.Ci = "18681749";
            nuevosValoresDocente.Nombre = "Monica";
            nuevosValoresDocente.Apellido = "Iriart";
            contextoDb.Docentes.Add(nuevosValoresDocente);
            contextoDb.SaveChanges();
            docenteDb = contextoDb.Docentes.SqlQuery("Select * from Docentes where Ci = '18681749'").ToList();
            Console.WriteLine("docentes db " + docenteDb[0].Nombre + docenteDb[0].Apellido + docenteDb[0].Ci);
            Assert.AreEqual(docenteDb[0].Ci, nuevosValoresDocente.Ci);
        }
        [TestMethod]
        public void ProbarModificarDocenteBaseDatos()
        {
            List<Docente> docenteDb = new List<Docente>();
            docenteDb = contextoDb.Docentes.SqlQuery("Select * from Docentes where Ci = '18681749'").ToList();
            Docente docenteBaseDatos = docenteDb[0];
            if (docenteBaseDatos != null)
            {
                docenteBaseDatos.Ci = "88833";
                contextoDb.Entry(docenteBaseDatos).CurrentValues.SetValues(docenteBaseDatos);
                contextoDb.SaveChanges();
            }
            docenteDb = contextoDb.Docentes.SqlQuery("Select * from Docentes where Ci = '88833'").ToList();
            Assert.AreEqual(docenteDb[0].Ci, docenteBaseDatos.Ci);
        }
        public Docente ObtenerDocenteDb(int id)
        {
            Docente docente = contextoDb.Docentes.FirstOrDefault(st => st.Id == id);
            if (docente == null)
                throw new ArgumentException("La entidad no existe");
            return docente;
        }
        [TestMethod]
        public void ProbarBajarDocenteBaseDatos()
        {
            int idDocente;
 //           int ciDocente;
            List<Docente> docenteDb = new List<Docente>();
            docenteDb = contextoDb.Docentes.SqlQuery("Select * from Docentes where Ci = '88833'").ToList();
            Docente docenteBaseDatos = docenteDb[0];
            if (docenteBaseDatos != null)
            {
                //                docenteBaseDatos.Ci = "88833";
                //              contextoDb.Docentes.SqlQuery("Delete from Docentes where Ci = '88833'").ToList();

                //contextoDb.SaveChanges();
                idDocente = docenteDb[0].Id;
   //             ciDocente = docenteDb[0].Ci;
                contextoDb = new ContextoDb();
                Docente docente = ObtenerDocenteDb(idDocente);
                contextoDb.Docentes.Attach(docente);
                contextoDb.Docentes.Remove(docente);
                contextoDb.SaveChanges();
            }
            docenteDb = contextoDb.Docentes.SqlQuery("Select * from Docentes where Ci = '888'").ToList();
            Assert.AreNotEqual(docenteDb.Count, contextoDb.Docentes.Count());
        }
        [TestMethod]
        public void ProbarAltaAlumnoBaseDatos()
        {
            Alumno nuevosValoresAlumno = new Alumno();
            List<Alumno> alumnoDb = new List<Alumno>();
            nuevosValoresAlumno.Ci = "18681770";
            nuevosValoresAlumno.Nombre = "Ana";
            nuevosValoresAlumno.Apellido = "Iriart";
            contextoDb.Alumnos.Add(nuevosValoresAlumno);
            contextoDb.SaveChanges();
            alumnoDb = contextoDb.Alumnos.SqlQuery("Select * from Alumnoes where Ci = '18681770'").ToList();
            Assert.AreEqual(alumnoDb[0].Ci, nuevosValoresAlumno.Ci);
        }
        [TestMethod]
        public void ProbarModificarAlumnoBaseDatos()
        {
            List<Alumno> alumnoDb = new List<Alumno>();
            alumnoDb = contextoDb.Alumnos.SqlQuery("Select * from Alumnoes where Ci = '18681770'").ToList();
            Alumno alumnoBaseDatos = alumnoDb[0];
            if (alumnoBaseDatos != null)
            {
                alumnoBaseDatos.Ci = "8883333";
                contextoDb.Entry(alumnoBaseDatos).CurrentValues.SetValues(alumnoBaseDatos);
                contextoDb.SaveChanges();
            }
            alumnoDb = contextoDb.Alumnos.SqlQuery("Select * from Alumnoes where Ci = '8883333'").ToList();
            Assert.AreEqual(alumnoDb[0].Ci, alumnoBaseDatos.Ci);
        }
        [TestMethod]
        public void ProbarBajarAlumnoBaseDatos()
        {
            List<Alumno> alumnoDb = new List<Alumno>();
            alumnoDb = contextoDb.Alumnos.SqlQuery("Select * from Alumnoes where Ci = '8883333'").ToList();
            Alumno alumnoBaseDatos = alumnoDb[0];
            if (alumnoBaseDatos != null)
            {
                contextoDb.Alumnos.SqlQuery("Delete from Alumnoes where Ci = '8883333'").ToList();
                contextoDb.SaveChanges();
            }
            alumnoDb = contextoDb.Alumnos.SqlQuery("Select * from Alumnoes where Ci = '8883333'").ToList();
            Assert.AreNotEqual(alumnoDb[0].Ci, alumnoBaseDatos.Ci);
        }
        public void SetUp()
        {
            using (var contextoDb = new ContextoDb())
            {
                contextoDb.Database.Delete();
            }
        }
    }
}
