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
        private List<Docente> docentes = new List<Docente>();
        public List<Docente> docentesPrueba = new List<Docente>();
        public List<Docente> GetDocentes()
        {
            return docentes;
        }
        public MantenimientoDocente()
        { 
            Console.WriteLine();
            Nombre = "Gestion Docente";
            Descripcion = "Alta, Baja y Modificación de Docentes";
        }
        public Docente AltaDatosDocente(string nombreDocente, string apellidoDocente, string ciDocente, List<string> materias)
        {
            Docente docente = new Docente();
            docente.Nombre = nombreDocente;
            docente.Apellido = apellidoDocente;
            docente.Ci = ciDocente;
            docente.Materias = materias;
            docentes.Add(docente);
            return docente;
        }
            
        public void BajaDocente(string ci)
        {
            Console.WriteLine("Cedula de Identidad a Baja de Docente > " + ci);

            try
            {
                // Filtro los docentes por la ci que recibo por parametro
                // Single es un metodo iterativo que recibe una funcion anonima por cada
                // elemento de la lista y retorna el elemento que cumpla con el filtro
                Docente docenteAEliminar = docentes.Single(docente => docente.Ci == ci);

                // Removemos el docenteAEliminar de la lista de docentes
                docentes.Remove(docenteAEliminar);
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar docente > " + e.ToString());
            }
        }
        public void ModificarDocente(string ci, Docente nuevosValores)
        {
            Console.WriteLine("Docente a modificar > " + ci);
            try
            {
                Docente docenteAModificar = docentes.Single(docente => docente.Ci == ci);
                int indiceDelDocenteAModificar = docentes.IndexOf(docenteAModificar);

                docentes[indiceDelDocenteAModificar].Nombre = nuevosValores.Nombre != "" ? nuevosValores.Nombre : docenteAModificar.Nombre;

                docentes[indiceDelDocenteAModificar].Apellido = nuevosValores.Apellido != "" ? nuevosValores.Apellido : docenteAModificar.Apellido;
                docentes[indiceDelDocenteAModificar].Ci = nuevosValores.Ci != "" ? nuevosValores.Ci : docenteAModificar.Ci;

                docentes[indiceDelDocenteAModificar].Materias = nuevosValores.Materias[0] != "" ? nuevosValores.Materias : docenteAModificar.Materias;

            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar docente > " + e.ToString());
            }
        }
        public void GenerarDatos()
        {
            // Agrego Docentes con AltaDatosDocente para tener una lista
            docentesPrueba.Add(AltaDatosDocente("Juan Pablo", "Perez", "111", new List<string>()));
            docentesPrueba.Add(AltaDatosDocente("Pedro", "Malan", "1231", new List<string>()));
            docentesPrueba.Add(AltaDatosDocente("Horacio", "Gabriel", "1234", new List<string>()));
            docentesPrueba.Add(AltaDatosDocente("Alejandro", "Gonzalez", "333", new List<string>()));

            docentes = GetDocentes();
        }
    }
}
