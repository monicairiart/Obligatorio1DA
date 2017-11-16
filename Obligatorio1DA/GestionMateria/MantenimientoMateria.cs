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
        public string CodigoMateria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public object Menu { get; set; }
        public IList Acciones { get; set; }
        private static List<Materia> materias = new List<Materia>();
        private static Boolean datosGenerados = false;
        public List<Materia> materiasPrueba = new List<Materia>();
        private string ciDocenteAFiltrar;
        private string ciAlumnoAFiltrar;
        public List<Materia> ObtenerMaterias()
        {
            return materias;
        }
        public MantenimientoMateria()
        {
            Nombre = "Gestion Materia";
            Descripcion = "Alta, Baja y Modificación de Materias";
            GenerarDatos();
        }
        public Materia AltaDatosMateria(string codigoMateria, string nombreMateria, List<string> docentes, List<string>alumnos)
        {
            Materia materia = new Materia();
            materia.CodigoMateria = codigoMateria;
            materia.Nombre = nombreMateria;
            materia.Docentes = docentes;
            materia.Alumnos = alumnos;
            materias.Add(materia);
            return materia;
        }
        public void BajarMateria(string codigoMateria)
        {
            try
            {
                Materia materiaAEliminar = materias.Single(materia => materia.CodigoMateria == codigoMateria);
                materias.Remove(materiaAEliminar);
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar materia > " + e.ToString());
            }
        }
        public void ModificarMateria(string codigoMateria, Materia nuevosValores)
        {
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
        public Materia ObtenerMateriaPorCodigo(string codigoMateria)
        {
            Materia materiaARetornar = materias.Single(materia => materia.CodigoMateria == codigoMateria);
            return materiaARetornar;
        }
        public List<Materia> ObtenerMateriasPorDocente(string ciDocente)
        {
            ciDocenteAFiltrar = ciDocente;
            List<Materia> materiasARetornar = new List<Materia>();
            materiasARetornar.Clear();
            foreach (Materia materiaActual in materias)
            {
                if (materiaActual.GetCiDocente(ciDocente))
                {
                    materiasARetornar.Add(materiaActual); 
                }
            }
            return materiasARetornar;
        }
        public List<Materia> ObtenerMateriasPorAlumno(string ciAlumno)
        {
            ciAlumnoAFiltrar = ciAlumno;
            List<Materia> materiasARetornar = new List<Materia>();
            materiasARetornar.Clear();
            foreach (Materia materiaActual in materias)
            {
                if (materiaActual.GetCiAlumno(ciAlumno))
                {
                    materiasARetornar.Add(materiaActual);
                }
            }
            return materiasARetornar;
        }
        public Boolean MateriaExistente(string codigoMateria)
        {
            Boolean materiaExistente = materias.Exists(materiaEncontrada => materiaEncontrada.CodigoMateria == codigoMateria);
            return materiaExistente;
        }
        public void GenerarDatos()
        {
            if (!datosGenerados)
            {
                materiasPrueba.Add(AltaDatosMateria("111", "Matemáticas", new List<string>(), new List<string>()));
                materiasPrueba.Add(AltaDatosMateria("444", "Algebra", new List<string>(), new List<string>()));
                materiasPrueba.Add(AltaDatosMateria("333", "Etica", new List<string>(), new List<string>()));
                materiasPrueba.Add(AltaDatosMateria("222", "Logica", new List<string>(), new List<string>()));
                materias = ObtenerMaterias();
                materias = AsignacionMateria.AsignarDocenteAMateria(materias, "38667442", "111");
                materias = AsignacionMateria.AsignarDocenteAMateria(materias, "51112145", "333");
                materias = AsignacionMateria.AsignarAlumnoAMateria(materias, "50001002", "111");
                materias = AsignacionMateria.AsignarAlumnoAMateria(materias, "49912233", "444");
                datosGenerados = true;
            }
        }
    }
}