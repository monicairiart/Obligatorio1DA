using GestionAlumno;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace InterfazUsuario
{
    public partial class GestionAlumnoUI : Form
    {
        MantenimientoAlumno mantenimientoAlumno = new MantenimientoAlumno();
        public static string ciAlumnoSeleccionado { get; set; }
        MantenimientoMateria mantenimientoMateria = new MantenimientoMateria();
        public GestionAlumnoUI()
        {
            InitializeComponent();
        }
        private void GestionAlumnoUI_Load(object sender, EventArgs e)
        {
//            mantenimientoAlumno.GenerarDatos();
//            mantenimientoMateria.GenerarDatos();
            listaAlumnos.Columns.Add("CI");
            listaAlumnos.Columns.Add("Nombre");
            listaAlumnos.Columns.Add("Apellido");
            listaAlumnos.Columns.Add("Ubic. X");
            listaAlumnos.Columns.Add("Ubic. Y");
            listaMaterias.Columns.Add("Código");
            listaMaterias.Columns.Add("Materia");
            cargarListaAlumno();
        }
        private void cargarListaAlumno()
        {
            listaAlumnos.Items.Clear();
            listaAlumnos.View = View.Details;
            foreach (Alumno alumno in mantenimientoAlumno.ObtenerAlumnos())
            {
                ListViewItem itemAlumno = new ListViewItem(alumno.Ci);
                itemAlumno.SubItems.Add(alumno.Nombre);
                itemAlumno.SubItems.Add(alumno.Apellido);
                itemAlumno.SubItems.Add(alumno.Ubicacion.Item1.ToString());
                itemAlumno.SubItems.Add(alumno.Ubicacion.Item2.ToString());
                listaAlumnos.Items.Add(itemAlumno);
            }
        }
        private void listaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Materia> materiasDelAlumno = new List<Materia>();
            ListView.SelectedListViewItemCollection alumnoSeleccionado = listaAlumnos.SelectedItems;
            if (alumnoSeleccionado.Count > 0)
            {
                entradaCIAlumno.Text = alumnoSeleccionado[0].SubItems[0].Text;
                entradaNombreAlumno.Text = alumnoSeleccionado[0].SubItems[1].Text;
                entradaApellidoAlumno.Text = alumnoSeleccionado[0].SubItems[2].Text;
                entradaUbicacionX.Text = alumnoSeleccionado[0].SubItems[3].Text;
                entradaUbicacionY.Text = alumnoSeleccionado[0].SubItems[4].Text;
                ciAlumnoSeleccionado = alumnoSeleccionado[0].SubItems[0].Text;
                materiasDelAlumno = mantenimientoMateria.ObtenerMateriasPorAlumno(ciAlumnoSeleccionado);
                cargarListaMateriaAlumno(materiasDelAlumno);
            }
        }

        private void botonAltaAlumno_Click(object sender, EventArgs e)
        {
            string nombre = entradaNombreAlumno.Text;
            string apellido = entradaApellidoAlumno.Text;
            string ci = entradaCIAlumno.Text;
            /////Tuple ubicacion = Tuple.Create(entradaUbicacionX.Text, entradaUbicacionY.Text);
           // Tuple<double, double> ubicacion = entradaUbicacionX.Text;
           //     ubicacion.Item1, ubicacion.//
            Alumno nuevosValoresAlumno = new Alumno();
            nuevosValoresAlumno.Ci = ci;
            nuevosValoresAlumno.Nombre = nombre;
            nuevosValoresAlumno.Apellido = apellido;
            if (ValidarDatos(ci, nuevosValoresAlumno, true))
            {
                /////////tuple
                mantenimientoAlumno.AltaDatosAlumno(nombre, apellido, ci, Tuple.Create(1.0, 2.0));
                cargarListaAlumno();
            }
        }
        private void botonModificarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumnoModificado = new Alumno();

            alumnoModificado.Nombre = entradaNombreAlumno.Text;
            alumnoModificado.Apellido = entradaApellidoAlumno.Text;
            alumnoModificado.Ci = entradaCIAlumno.Text;
            if (ValidarDatos(alumnoModificado.Ci, alumnoModificado, false))
            {
                mantenimientoAlumno.ModificarAlumno(ciAlumnoSeleccionado, alumnoModificado);
                entradaCIAlumno.Clear();
                entradaApellidoAlumno.Clear();
                entradaNombreAlumno.Clear();
                cargarListaAlumno();
            }
        }
        private void botonBajarAlumno_Click_1(object sender, EventArgs e)
        {
            mantenimientoAlumno.BajarAlumno(ciAlumnoSeleccionado);
            limpiarValoresViejos();
            cargarListaAlumno();
        }
        private void limpiarValoresViejos()
        {
            entradaNombreAlumno.Clear();
            entradaApellidoAlumno.Clear();
            entradaCIAlumno.Clear();
            entradaUbicacionX.Clear();
            entradaUbicacionY.Clear();
        }
        public void actualizarListaMateriaAlumno()
        {
            cargarListaMateriaAlumno(mantenimientoMateria.ObtenerMaterias());
        }
        private void cargarListaMateriaAlumno(List<Materia> materiasARetornar)
        {
            listaMaterias.Items.Clear();
            listaMaterias.View = View.Details;
            foreach (Materia materia in materiasARetornar)
            {
                ListViewItem itemMateria = new ListViewItem(materia.CodigoMateria);
                itemMateria.SubItems.Add(materia.Nombre);
                listaMaterias.Items.Add(itemMateria);
            }
        }
        private void botonAsignarMateriaAAlumno_Click(object sender, EventArgs e)
        {
            AsignarMateriaUI.ciAlumnoSeleccionado = ciAlumnoSeleccionado;
            Form nuevaVentana = new AsignarMateriaUI();
            nuevaVentana.Show();
        }
        private Boolean ValidarDatos(string ci, Alumno nuevosValores, Boolean comprobarDuplicado)
        {
            if ((ci.Length == 0) || (nuevosValores.Apellido.Length == 0) || (nuevosValores.Nombre.Length == 0))
            {
                MessageBox.Show("Error: Los datos ingresados no son correctos");
                return (false);
            }
            if ((ci.Trim().Length == 0) || (nuevosValores.Apellido.Trim().Length == 0) || (nuevosValores.Nombre.Trim().Length == 0))
            {
                MessageBox.Show("Error: Los datos ingresados no son correctos");
                return (false);
            }
            if (mantenimientoAlumno.AlumnoExistente(ci) && comprobarDuplicado)
            {
                MessageBox.Show("Error: El alumno ya existe");
                return (false);
            }
            return (true);
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listaMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
