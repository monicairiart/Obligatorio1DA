using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistencia;
using System.Data.Entity;
using GestionDocente;
using System.Linq;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasPersistencia
    {
        public ContextoDb contextoDb { get; set; }
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
    }
}
