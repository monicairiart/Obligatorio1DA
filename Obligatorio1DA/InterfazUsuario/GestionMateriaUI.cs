using GestionAlumno;
using GestionDocente;
using GestionMateria;
using Persistencia;
using RelacionAlumnoMateria;
using RelacionDocenteMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class GestionMateriaUI : Form
    {
        MantenimientoMateria mantenimientoMateria = new MantenimientoMateria();
        public static string idMateriaSeleccionada { get; set; }
        MantenimientoDocente mantenimientoDocente = new MantenimientoDocente();
        MantenimientoAlumno mantenimientoAlumno = new MantenimientoAlumno();
        private ContextoDb contextoDb = new ContextoDb();
	    Materia materiaDbSeleccionada;

        public GestionMateriaUI()
        {
            InitializeComponent();
        }

 /*       private void tituloMantenimientoAlumnos_Click(object sender, EventArgs e)
        {

        }
*/
        private void GestionMateriaUI_Load(object sender, EventArgs e)
        {
            listaMaterias.Columns.Add("Id");
            listaMaterias.Columns.Add("Código Materia");
            listaMaterias.Columns.Add("Nombre");
            listaMateriasDocente.Columns.Add("CI");
            listaMateriasDocente.Columns.Add("Nombre");
            listaMateriasDocente.Columns.Add("Apellido");
            listaAlumnosInscriptos.Columns.Add("CI");
            listaAlumnosInscriptos.Columns.Add("Nombre");
            listaAlumnosInscriptos.Columns.Add("Apellido");
            cargarListaMateria();
        }
        private void cargarListaMateria()
        {
            List<Materia> registroMaterias = new List<Materia>(); // 
            //contextoDb.Materias.SqlQuery("Select * from Materias").ToList(); //07
            try
            {
                registroMaterias = contextoDb.Materias.SqlQuery("Select * from Materias").ToList(); //07
            }
            catch
            {
                MessageBox.Show("Hubo un error al listar las materias.");
            }
            listaMaterias.Items.Clear();
            listaMaterias.View = View.Details;
            /*foreach (GestionMateria.Materia materia in mantenimientoMateria.ObtenerMaterias())
            {
                ListViewItem itemMateria = new ListViewItem(materia.CodigoMateria);
                itemMateria.SubItems.Add(materia.Nombre);

                listaMaterias.Items.Add(itemMateria);
            }*/
            foreach (Materia materia in registroMaterias)
            {
                //7 ListViewItem itemMateria = new ListViewItem(materia.CodigoMateria);
                ListViewItem itemMateria = new ListViewItem(materia.Id.ToString()); //7 agregñue tostring
                itemMateria.SubItems.Add(materia.CodigoMateria);                    //7 agregue
                itemMateria.SubItems.Add(materia.Nombre);
                listaMaterias.Items.Add(itemMateria);
            }
        }
        private void listaMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> docentesDeMateria = new List<string>();
            List<string> alumnosDeMateria = new List<string>();
            ListView.SelectedListViewItemCollection materiaSeleccionada = listaMaterias.SelectedItems;
            if (materiaSeleccionada.Count > 0)
            {
                entradaCodigoMateria.Text = materiaSeleccionada[0].SubItems[1].Text;
                entradaNombreMateria.Text = materiaSeleccionada[0].SubItems[2].Text;
                idMateriaSeleccionada = materiaSeleccionada[0].SubItems[0].Text;
                int idMateria = Int32.Parse(idMateriaSeleccionada);
                materiaDbSeleccionada = contextoDb.Materias.Where(materia => materia.Id == idMateria).ToList()[0];
                //////List<Materia> materiasDb = contextoDb.Materias.ToList();

                List<Docente> docentesDb = contextoDb.Docentes.ToList();
                List<Docente> docentesDelaMateriaDb = docentesDb.FindAll(buscarDocentesDb);
                cargarListaDocenteMateria(docentesDelaMateriaDb);

                List<Alumno> alumnosDb = contextoDb.Alumnos.ToList();
                List<Alumno> alumnosDelaMateriaDb = alumnosDb.FindAll(buscarAlumnosDb);
                cargarListaAlumnoMateria(alumnosDelaMateriaDb);


                //                docentesDeMateria = mantenimientoMateria.ObtenerMateriaPorCodigo(idMateriaSeleccionada).Docentes;
                /*               alumnosDeMateria = mantenimientoMateria.ObtenerMateriaPorCodigo(idMateriaSeleccionada).Alumnos;
                               listaMateriasDocente.Items.Clear();
                               listaMateriasDocente.View = View.Details;
                               listaAlumnosInscriptos.Items.Clear();
                               listaAlumnosInscriptos.View = View.Details;

                               foreach (string ci in docentesDeMateria)
                               {
                                   Docente docente = mantenimientoDocente.ObtenerDocentePorCi(ci);
                                   ListViewItem itemDocente = new ListViewItem(docente.Ci);
                                   itemDocente.SubItems.Add(docente.Nombre);
                                   itemDocente.SubItems.Add(docente.Apellido);
                                   listaMateriasDocente.Items.Add(itemDocente);
                               }
                               foreach (string ci in alumnosDeMateria)
                               {
                                   Alumno alumno = mantenimientoAlumno.ObtenerAlumnoPorCi(ci);
                                   ListViewItem itemAlumno = new ListViewItem(alumno.Ci);
                                   itemAlumno.SubItems.Add(alumno.Nombre);
                                   itemAlumno.SubItems.Add(alumno.Apellido);
                                   listaAlumnosInscriptos.Items.Add(itemAlumno);
                               }*/
            }
        }
        private bool existeDocenteRelacionado(DocenteMateria docenteMateria, Docente docente)
        {
            return (docenteMateria.DocenteId == docente.Id);
        }

        private bool buscarDocentesDb(Docente docente)
        {
            return materiaDbSeleccionada.DocentesMaterias.ToList().Exists(materiaDocente => existeDocenteRelacionado(materiaDocente, docente));
        }
        private bool existeAlumnoRelacionado(AlumnoMateria alumnoMateria, Alumno alumno)
        {
            return (alumnoMateria.AlumnoId == alumno.Id);
        }

        private bool buscarAlumnosDb(Alumno alumno)
        {
            return materiaDbSeleccionada.AlumnosMaterias.ToList().Exists(materiaAlumno => existeAlumnoRelacionado(materiaAlumno, alumno));
        }
        private void botonAltaMateria_Click(object sender, EventArgs e)
        {
            string nombre = entradaNombreMateria.Text;
            string codigoMateria = entradaCodigoMateria.Text;
            Materia nuevosValoresMateria = new Materia();

            nuevosValoresMateria.CodigoMateria = codigoMateria;
            nuevosValoresMateria.Nombre = nombre;
            if (ValidarDatos(codigoMateria, nuevosValoresMateria, true))
            {
                mantenimientoMateria.AltaDatosMateria(codigoMateria, nombre, new List<string>(), new List<string>());
                contextoDb.Materias.Add(nuevosValoresMateria);
                contextoDb.SaveChanges();
                cargarListaMateria();
            }
        }
        private void botonModificarMateria_Click(object sender, EventArgs e)
        {
            /*Materia materiaModificada = new Materia();
            materiaModificada.Nombre = entradaNombreMateria.Text;
            materiaModificada.CodigoMateria = entradaCodigoMateria.Text;
            mantenimientoMateria.ModificarMateria(idMateriaSeleccionada, materiaModificada);
            limpiarValoresViejos();
            cargarListaMateria();*/
            Materia materiaModificado = new Materia();
            materiaModificado.Nombre = entradaNombreMateria.Text;
            materiaModificado.CodigoMateria = entradaCodigoMateria.Text;
            materiaModificado.Id = int.Parse(idMateriaSeleccionada); //7 agregue
            if (ValidarDatos(materiaModificado.CodigoMateria, materiaModificado, false))
            {
                //mantenimientoDocente.ModificarDocente(idDocenteSeleccionado, docenteModificado); //7 ci x id
                entradaCodigoMateria.Clear();
                entradaNombreMateria.Clear();
                //7 agrefe inio
                Materia materiaBaseDatos = contextoDb.Materias.Find(materiaModificado.Id);
                if (materiaBaseDatos != null)
                {
                    contextoDb.Entry(materiaBaseDatos).CurrentValues.SetValues(materiaModificado);
                    contextoDb.SaveChanges();
                } //7 fin            
                cargarListaMateria();
            }
        }
        private void botonBajaMateria_Click(object sender, EventArgs e)
        {
            /*mantenimientoMateria.BajarMateria(idMateriaSeleccionada);
            limpiarValoresViejos();
            cargarListaMateria();*/
            mantenimientoMateria.BajarMateria(idMateriaSeleccionada); //7 ci x id
            //7 agrego inicio
            Materia materiaBaseDatos = contextoDb.Materias.Find(int.Parse(idMateriaSeleccionada));
            if (materiaBaseDatos != null)
            {
                contextoDb.Materias.Remove(materiaBaseDatos);
                contextoDb.SaveChanges();
            } //7 fin
            limpiarValoresViejos();
            cargarListaMateria();
            listaAlumnosInscriptos.Clear();
            listaMateriasDocente.Clear();

        }
        private void limpiarValoresViejos()
        {
            entradaCodigoMateria.Clear();
            entradaNombreMateria.Clear();
        }

        public void actualizarListaDocenteMateria()
        {
            cargarListaDocenteMateria(mantenimientoDocente.ObtenerDocentes());

        }

        private void cargarListaDocenteMateria(List<Docente> docentesARetonar)
        {
            listaMateriasDocente.Items.Clear();
            listaMateriasDocente.View = View.Details;
            foreach (Docente docente in docentesARetonar)
            {
                ListViewItem itemDocente = new ListViewItem(docente.Ci);
                itemDocente.SubItems.Add(docente.Nombre);
                listaMateriasDocente.Items.Add(itemDocente);
            }
        }
        private void cargarListaAlumnoMateria(List<Alumno> alumnosARetonar)
        {
            listaAlumnosInscriptos.Items.Clear();
            listaAlumnosInscriptos.View = View.Details;
            foreach (Alumno alumno in alumnosARetonar)
            {
                ListViewItem itemAlumno = new ListViewItem(alumno.Ci);
                itemAlumno.SubItems.Add(alumno.Nombre);
                listaAlumnosInscriptos.Items.Add(itemAlumno);
            }
        }
        // hacer validar datos, ver para mostrar docentes y alumnos??
        // hacer existenregistros repetidos para materias
        /*public static void LimpiarCodigoMateriaSeleccionada()
        {
            codigoMateriaSeleccionada = null;
        }*/
        private Boolean ValidarDatos(string codigoMateria, Materia nuevosValores, Boolean comprobarDuplicado)
        {

            if ((codigoMateria.Length == 0) || (nuevosValores.Nombre.Length == 0))
            {
                MessageBox.Show("Error: Los datos ingresados no son correctos");
                return (false);
            }
            if ((codigoMateria.Trim().Length == 0) || (nuevosValores.Nombre.Trim().Length == 0))
            {
                MessageBox.Show("Error: Los datos ingresados no son correctos");
                return (false);
            }
            try
            {
                materiaDbSeleccionada = contextoDb.Materias.Where(materia => materia.CodigoMateria == codigoMateria).ToList()[0];

                if (comprobarDuplicado)
                {
                    MessageBox.Show("Error: La materia ya existe");
                    return (false);
                }
            }
            catch
            {
            }
            return (true);
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
