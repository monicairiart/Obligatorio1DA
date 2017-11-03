using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Collections;

namespace GestionMateria
{
    public class MantenimientoMateria : IModuloGestion
    {
        public int CodigoMateria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public object Menu { get; set; }
        public IList Acciones { get; set; }
        private List<Materia> materias = new List<Materia>();
        public List<Materia> GetMaterias()
        {
            return materias;
        }
        public MantenimientoMateria()
        {
            Console.WriteLine();
            Nombre = "Gestion Materia";
            Descripcion = "Alta, Baja y Modificación de Materias";
        }
        public Materia AltaDatosMateria(int codigoMateria, string nombreMateria, List<string> docentes, List<string>alumnos)
        {
            Materia materia = new Materia();
            materia.CodigoMateria = codigoMateria;
            materia.Nombre = nombreMateria;
            materia.Docentes = docentes;
            materia.Alumnos = alumnos;
            materias.Add(materia);
            return materia;
        }
        public void BajaMateria(int codigoMateria)
        {
            Console.WriteLine("Código de Materia a bajar de Materia > " + codigoMateria);

            try
            {
                // Filtro los docentes por la ci que recibo por parametro
                // Single es un metodo iterativo que recibe una funcion anonima por cada
                // elemento de la lista y retorna el elemento que cumpla con el filtro
                Materia materiaAEliminar = materias.Single(materia => materia.CodigoMateria == codigoMateria);

                // Removemos la materiaAEliminar de la lista de materias
                materias.Remove(materiaAEliminar);
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar materia > " + e.ToString());
            }
        }
        public void ModificarMateria(int codigoMateria, Materia nuevosValores)
        {
            Console.WriteLine("Materia a modificar > " + codigoMateria);
            try
            {
                Materia materiaAModificar = materias.Single(materia => materia.CodigoMateria == codigoMateria);
                int indiceDelaMateriaAModificar = materias.IndexOf(materiaAModificar);

                materias[indiceDelaMateriaAModificar].Nombre = nuevosValores.Nombre != "" ? nuevosValores.Nombre : materiaAModificar.Nombre;

                materias[indiceDelaMateriaAModificar].Docentes = nuevosValores.Docentes[0] != "" ? nuevosValores.Docentes : materiaAModificar.Docentes;
                materias[indiceDelaMateriaAModificar].Alumnos = nuevosValores.Alumnos[0] != "" ? nuevosValores.Alumnos : materiaAModificar.Docentes;

            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar materia > " + e.ToString());
            }
        }
    }
}