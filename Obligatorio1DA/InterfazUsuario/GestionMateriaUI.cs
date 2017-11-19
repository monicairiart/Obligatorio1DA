using GestionAlumno;
using GestionDocente;
using GestionMateria;
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
        public static string codigoMateriaSeleccionada;
        MantenimientoDocente mantenimientoDocente = new MantenimientoDocente();
        MantenimientoAlumno mantenimientoAlumno = new MantenimientoAlumno();

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
            listaMaterias.Items.Clear();
            listaMaterias.View = View.Details;
            foreach (GestionMateria.Materia materia in mantenimientoMateria.ObtenerMaterias())
            {
                ListViewItem itemMateria = new ListViewItem(materia.CodigoMateria);
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
                entradaCodigoMateria.Text = materiaSeleccionada[0].SubItems[0].Text;
                entradaNombreMateria.Text = materiaSeleccionada[0].SubItems[1].Text;
                codigoMateriaSeleccionada = materiaSeleccionada[0].SubItems[0].Text;
                docentesDeMateria = mantenimientoMateria.ObtenerMateriaPorCodigo(codigoMateriaSeleccionada).Docentes;
                alumnosDeMateria = mantenimientoMateria.ObtenerMateriaPorCodigo(codigoMateriaSeleccionada).Alumnos;
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
                }
            }
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
                cargarListaMateria();
            }
        }
        private void botonModificarMateria_Click(object sender, EventArgs e)
        {
            Materia materiaModificada = new Materia();
            materiaModificada.Nombre = entradaNombreMateria.Text;
            materiaModificada.CodigoMateria = entradaCodigoMateria.Text;
            mantenimientoMateria.ModificarMateria(codigoMateriaSeleccionada, materiaModificada);
            entradaCodigoMateria.Clear();
            entradaNombreMateria.Clear();
            cargarListaMateria();
        }
        private void botonBajaMateria_Click(object sender, EventArgs e)
        {
            mantenimientoMateria.BajarMateria(codigoMateriaSeleccionada);
            limpiarValoresViejos();
            cargarListaMateria();
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
                // itemDocente.SubItems.Add(docente.Ci)
                itemDocente.SubItems.Add(docente.Nombre);
                // itemDocente.SubItems.Add(docente.Apellido);
                listaMateriasDocente.Items.Add(itemDocente);
            }
        }
        // hacer validar datos, ver para mostrar docentes y alumnos??
        // hacer existenregistros repetidos para materias
        public static void LimpiarCodigoMateriaSeleccionada()
        {
            codigoMateriaSeleccionada = null;
        }
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
            if (mantenimientoMateria.MateriaExistente(codigoMateria) && comprobarDuplicado)
            {
                MessageBox.Show("Error: La materia ya existe");
                return (false);
            }
            return (true);
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
