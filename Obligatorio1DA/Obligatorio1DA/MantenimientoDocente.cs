using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Collections;

namespace GestionDocente 
{
    public class MantenimientoDocente : IModuloGestion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public object Menu { get; set; }
        public IList Acciones { get; set; }
        private static List<Docente> docentes = new List<Docente>();
        public List<Docente> docentesPrueba = new List<Docente>();
        public List<Docente> ObtenerDocentes()
        {
            return docentes;
        }
        public MantenimientoDocente()
        { 
            Nombre = "Gestion Docente";
            Descripcion = "Alta, Baja y Modificación de Docentes";
        }
        public Docente AltaDatosDocente(string nombreDocente, string apellidoDocente, string ciDocente)
        {
            Docente docente = new Docente();
            if (!DocenteExistente(ciDocente))
            {
                docente.Nombre = nombreDocente;
                docente.Apellido = apellidoDocente;
                docente.Ci = ciDocente;
                docentes.Add(docente);
                return docente;
            }
            return docente;
        }
            
        public void BajarDocente(string ci)
        {
            try
            {
                if (DocenteExistente(ci))
                {
                    Docente docenteAEliminar = docentes.Single(docente => docente.Ci == ci);
                    docentes.Remove(docenteAEliminar);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar docente > " + e.ToString());
            }
        }
        public void ModificarDocente(string ci, Docente nuevosValores)
        {
            try
            {
                Docente docenteAModificar = docentes.Single(docente => docente.Ci == ci);
                int indiceDelDocenteAModificar = docentes.IndexOf(docenteAModificar);
                docentes[indiceDelDocenteAModificar].Nombre = nuevosValores.Nombre != "" ? nuevosValores.Nombre : docenteAModificar.Nombre;
                docentes[indiceDelDocenteAModificar].Apellido = nuevosValores.Apellido != "" ? nuevosValores.Apellido : docenteAModificar.Apellido;
                docentes[indiceDelDocenteAModificar].Ci = nuevosValores.Ci != "" ? nuevosValores.Ci : docenteAModificar.Ci;
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar docente > " + e.ToString());
            }
        }
        public Docente ObtenerDocentePorCi(string ciDocente)
        {
            Docente docenteARetornar = docentes.Find(docente => docente.Ci == ciDocente);
            return docenteARetornar;
        }
        public Boolean DocenteExistente(string ciDocente)
        {
            Boolean docenteExistente = docentes.Exists(docenteEncontrado => docenteEncontrado.Ci == ciDocente);
            return docenteExistente;
        }
        public void GenerarDatos()
        {
            docentesPrueba.Add(AltaDatosDocente("Juan Pablo", "Perez", "38667442"));
            docentesPrueba.Add(AltaDatosDocente("Pedro", "Malan", "51112145"));
            docentesPrueba.Add(AltaDatosDocente("Horacio", "Gabriel", "35466661"));
            docentesPrueba.Add(AltaDatosDocente("Alejandro", "Gonzalez", "42227230"));
            docentes = ObtenerDocentes();
        }
    }
}
