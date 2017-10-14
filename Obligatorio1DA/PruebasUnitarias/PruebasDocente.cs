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
            // Creamos el abmDocente para gestionar docentes
            MantenimientoDocente Docente = new GestionDocente.MantenimientoDocente();
            List<string> materias = new List<string>();
            // Creamos un docente utilizando el abmDocente.AltaDatosDocente
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "1234", materias);

            // Validamos si el docente creado es del tipo Docente
            Assert.IsInstanceOfType(docente, typeof(Docente));
        }

        [TestMethod]
        public void ProbarDatosAltaDocente()
        {
            // Validamos si el docente tiene un atributo nombre de tipo string
            // y si el nombre es igual al nombre asignado en AltaDatosDocente
            List<string> materias = new List<string>();
            Docente docente = mantenimientoDocente.AltaDatosDocente("Nombre del Docente", "1234", materias);
            Assert.IsInstanceOfType(docente.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", docente.Nombre);
            Assert.AreEqual("Nombre del Docente", docente.Nombre);
            // Validamos si el docente tiene un atributo CI de tipo string
            // y si la ci es igual al asignado en el AltaDatosDocente
            Assert.IsInstanceOfType(docente.Ci, typeof(string));
            Assert.AreNotEqual("1111", docente.Ci);
            Assert.AreEqual("1234", docente.Ci);
            // Creamos una lista de materias diferente de la que asignamos
            // al docente para validar que una es igual y la otra no lo es
            List<string> materiasDiferentes = new List<string>();
            materiasDiferentes.Add("Ingles");
            materiasDiferentes.Add("Dibujo");
            // Validamos que el docente tiene un atributo materias de tipo List<string>
            // y que las materias del docente son las asignadas por el metodo AltaDatosDocente
            Assert.IsInstanceOfType(docente.Materias, typeof(List<string>));
            Assert.AreNotEqual(materiasDiferentes, docente.Materias);
            Assert.AreEqual(materias, docente.Materias);
        }
    }
}
