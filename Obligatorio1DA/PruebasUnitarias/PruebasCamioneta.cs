using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionCamioneta;
using Interfaces;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebasCamioneta
    {
        public MantenimientoCamioneta mantenimientoCamioneta { get; set; }
        public List<Camioneta> camionetas { get; set; }
        public List<Camioneta> misCamionetas { get; set; }
        public PruebasCamioneta()
        {
            mantenimientoCamioneta = new MantenimientoCamioneta();
        }

        [TestMethod]
        public void ProbarTipoModuloGestionCamioneta()
        {
           Assert.IsInstanceOfType(mantenimientoCamioneta, typeof(IModuloGestion));
        }
        [TestMethod]
        public void ProbarDatosTipoModuloGestionCamioneta()
        {
            Assert.AreEqual("Gestion Camioneta", mantenimientoCamioneta.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Camionetas", mantenimientoCamioneta.Descripcion);
        }
        [TestMethod]
        public void ProbarTipoModuloAltaCamioneta()
        {
            MantenimientoCamioneta Camioneta = new GestionCamioneta.MantenimientoCamioneta();
            List<string> alumnos = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Estado", alumnos);
            Assert.IsInstanceOfType(camioneta, typeof(Camioneta));
        }
        [TestMethod]
        public void ProbarDatosAltaCamionetaMatricula()
        {
            List<string> alumnos = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Disponible", alumnos);
            Assert.IsInstanceOfType(camioneta.Matricula, typeof(string));
            Assert.AreNotEqual("SAF0000", camioneta.Matricula);
            Assert.AreEqual("SAF3685", camioneta.Matricula);
        }
        [TestMethod]
        public void ProbarDatosAltaCamionetaCapacidad()
        {
            List<string> alumnos = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Disponible", alumnos);
            Assert.IsInstanceOfType(camioneta.Matricula, typeof(string));
            Assert.AreNotEqual(40, camioneta.Capacidad);
            Assert.AreEqual(50, camioneta.Capacidad);
        }
        [TestMethod]
        public void ProbarDatosAltaCamionetaEstado()
        {
            List<string> alumnos = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Disponible", new List<string>());
            Assert.IsInstanceOfType(camioneta.Estado, typeof(string));
            Assert.AreNotEqual("Estado cualquiera", camioneta.Estado);
            Assert.AreEqual("Disponible", camioneta.Estado);
        }
        [TestMethod]
        public void ProbarDatosModificacionCamionetaMatricula()
        {
            List<Camioneta> misCamionetas = new List<Camioneta>();
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Disponible", new List<string>()));
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3333", 30, "NoDisponible", new List<string>()));
            Camioneta nuevosValoresCamioneta = new Camioneta();
            nuevosValoresCamioneta.Matricula = "SAF1111";
            mantenimientoCamioneta.ModificarCamioneta("SAF3685", nuevosValoresCamioneta);
            Assert.AreEqual("SAF1111", misCamionetas[0].Matricula);
            Console.WriteLine("nvos valor matricula " + misCamionetas[0].Matricula);
        }
        [TestMethod]
        public void ProbarDatosModificacionCamionetaCapacidad()
        {
            List<Camioneta> misCamionetas = new List<Camioneta>();
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Disponible", new List<string>()));
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3333", 30, "NoDisponible", new List<string>()));
            Camioneta nuevosValoresCamioneta = new Camioneta();
            nuevosValoresCamioneta.Capacidad = 51;
            mantenimientoCamioneta.ModificarCamioneta("SAF3685", nuevosValoresCamioneta);
            Assert.AreEqual(51, misCamionetas[0].Capacidad);
            Console.WriteLine("nvos valor capacidad " + misCamionetas[0].Capacidad);
        }

        [TestMethod]
        public void ProbarDatosModificacionCamionetaEstado()
        {
            List<Camioneta> misCamionetas = new List<Camioneta>();
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Disponible", new List<string>()));
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3333", 30, "NoDisponible", new List<string>()));
            Camioneta nuevosValoresCamioneta = new Camioneta();
            nuevosValoresCamioneta.Estado = "NoDisponible";
            mantenimientoCamioneta.ModificarCamioneta("SAF3685", nuevosValoresCamioneta);
            Assert.AreEqual("NoDisponible", misCamionetas[0].Estado);
            Console.WriteLine("nvos valor estado " + misCamionetas[0].Estado);
        }
        [TestMethod]
        public void ProbarDatosBajaCamioneta()
        {
            MantenimientoCamioneta mantenimientoCamioneta = new GestionCamioneta.MantenimientoCamioneta();
            List<Camioneta> misCamionetas = new List<Camioneta>();
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Disponible", new List<string>()));
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3333", 30, "NoDisponible", new List<string>()));
            Console.WriteLine("count de obtener camionetas " + mantenimientoCamioneta.ObtenerCamionetas().Count);
            CollectionAssert.AreEqual(misCamionetas, mantenimientoCamioneta.ObtenerCamionetas());
            mantenimientoCamioneta.BajarCamioneta("SAF3685");
            CollectionAssert.AreNotEqual(misCamionetas, mantenimientoCamioneta.ObtenerCamionetas());
            mantenimientoCamioneta.BajarCamioneta("SAF3333");
        }
        [TestMethod]
        public void ProbarDatosBajaCamionetaNoExiste()
        {
            MantenimientoCamioneta mantenimientoCamioneta = new GestionCamioneta.MantenimientoCamioneta();
            List<Camioneta> misCamionetas = new List<Camioneta>();
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Disponible", new List<string>()));
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3333", 30, "NoDisponible",new List<string>()));
            CollectionAssert.AreEqual(misCamionetas, mantenimientoCamioneta.ObtenerCamionetas());
            mantenimientoCamioneta.BajarCamioneta("999");
            CollectionAssert.AreEqual(misCamionetas, mantenimientoCamioneta.ObtenerCamionetas());
            mantenimientoCamioneta.BajarCamioneta("");

        }
        [TestMethod]
        public void ProbarCamionetaExistente()
        {
            MantenimientoCamioneta mantenimientoCamioneta = new GestionCamioneta.MantenimientoCamioneta();
            List<Camioneta> misCamionetas = new List<Camioneta>();
            misCamionetas.Add(mantenimientoCamioneta.AltaDatosCamioneta("SAF3685", 50, "Disponible", new List<string>()));
            Assert.IsTrue(mantenimientoCamioneta.CamionetaExistente("SAF3685"));
        }
        [TestMethod]
        public void ProbarAsignarAlumnoACamioneta()
        {
            camionetas = mantenimientoCamioneta.ObtenerCamionetas();
            string ciAlumno = "50001002";
            string matricula = "SAF3685";
            Console.WriteLine("entra a asignar alumno camioneta ");
            camionetas = AsignacionCamioneta.AsignarAlumnoACamioneta(camionetas, ciAlumno, matricula);
            Console.WriteLine("cant camionetas " + camionetas.Count);
            Camioneta camioneta = mantenimientoCamioneta.ObtenerCamionetaPorMatricula(matricula);
            string ciAlumnoEncontrado = camioneta.Alumnos.Find(ci => ci == ciAlumno);
            Console.WriteLine("alumno de la camioneta " + camioneta.Alumnos.ToString());
            Assert.AreEqual(ciAlumno, ciAlumnoEncontrado);
        }
        //[TestMethod]
        /*public void ProbarDatosAltaCamionetasViajes()
        {
            List<string> viajes = new List<string>();
            List<string> viajesDiferentes = new List<string>();
            Camioneta camioneta = mantenimientoCamioneta.AltaDatosCamioneta("SAF3670", 50, "Disponible", viajes);
            viajes.Add("1R", "0,1", "Alumno1");
            viajes.Add("1R", "1,2", "Alumno2");
            viajes.Add("1R", "2,2", "Alumno3");
            viajesDiferentes.Add("1R", "2,3", "Alumno1");
            viajesDiferentes.Add("1R", "3,3", "Alumno1");
            viajesDiferentes.Add("2R", "1,2", "Alumno2");
            Assert.IsInstanceOfType(camioneta.Viajes, typeof(List<string>));
            Assert.AreNotEqual(viajesDiferentes, camioneta.Viajes);
            Assert.AreEqual(viajes, camioneta.Viajes);
        }*/
    }
}

