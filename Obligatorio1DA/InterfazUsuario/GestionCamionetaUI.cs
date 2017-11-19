using GestionAlumno;
using GestionCamioneta;
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
    public partial class GestionCamionetaUI : Form
    {
        MantenimientoCamioneta mantenimientoCamioneta = new MantenimientoCamioneta();
        public static string matriculaCamionetaSeleccionada { get; set; }
        MantenimientoAlumno mantenimientoAlumno = new MantenimientoAlumno();

        public GestionCamionetaUI()
        {
            InitializeComponent();
        }
        private void GestionCamionetaUI_Load(object sender, EventArgs e)
        {
            listaCamionetas.Columns.Add("Matrícula");
            listaCamionetas.Columns.Add("Capacidad");
            listaCamionetas.Columns.Add("Estado");
            listaAlumnos.Columns.Add("CI");
            listaAlumnos.Columns.Add("Nombre");
            listaAlumnos.Columns.Add("Apellido");
            listaAlumnos.Columns.Add("Ubicación");
            cargarListaCamioneta();
        }
        private void cargarListaCamioneta()
        {
            listaCamionetas.Items.Clear();
            listaCamionetas.View = View.Details;
            foreach (Camioneta camioneta in mantenimientoCamioneta.ObtenerCamionetas())
            {
                ListViewItem itemCamioneta = new ListViewItem(camioneta.Matricula);
                itemCamioneta.SubItems.Add(camioneta.Capacidad.ToString());
                itemCamioneta.SubItems.Add(camioneta.Estado);
                listaCamionetas.Items.Add(itemCamioneta);
            }
        }
        private void listaCamionetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //           List<string> docentesDeMateria = new List<string>();
            List<string> alumnosDeCamioneta = new List<string>();
            ListView.SelectedListViewItemCollection camionetaSeleccionada = listaCamionetas.SelectedItems;
            if (camionetaSeleccionada.Count > 0)
            {
                entradaMatricula.Text = camionetaSeleccionada[0].SubItems[0].Text;
                entradaCapacidad.Text = camionetaSeleccionada[0].SubItems[1].Text;
                comboBoxEstado.Text = camionetaSeleccionada[0].SubItems[2].Text;
                matriculaCamionetaSeleccionada = camionetaSeleccionada[0].SubItems[0].Text;
                alumnosDeCamioneta = mantenimientoCamioneta.ObtenerCamionetaPorMatricula(matriculaCamionetaSeleccionada).Alumnos;
                listaAlumnos.Items.Clear();
                listaAlumnos.View = View.Details;
                foreach (string ci in alumnosDeCamioneta)
                {
                    Alumno alumno = mantenimientoAlumno.ObtenerAlumnoPorCi(ci);
                    ListViewItem itemAlumno = new ListViewItem(alumno.Ci);
                    itemAlumno.SubItems.Add(alumno.Nombre);
                    itemAlumno.SubItems.Add(alumno.Apellido);
                    itemAlumno.SubItems.Add(alumno.Ubicacion.Item1.ToString());
                    itemAlumno.SubItems.Add(alumno.Ubicacion.Item2.ToString());
                    listaAlumnos.Items.Add(itemAlumno);
                }
            }
        }
        private void botonAltaCamioneta_Click_1(object sender, EventArgs e)
        {
            string matricula = entradaMatricula.Text;
            string estado = comboBoxEstado.Text;
            Camioneta nuevosValoresCamioneta = new Camioneta();
            nuevosValoresCamioneta.Matricula = matricula;
            nuevosValoresCamioneta.Estado = estado;
            if (entradaCapacidad.Text == null || entradaCapacidad.Text == "0" || entradaCapacidad.Text == "")
            {
                nuevosValoresCamioneta.Capacidad = 0;
            }
            else
            {
                nuevosValoresCamioneta.Capacidad = Int32.Parse(entradaCapacidad.Text);
            }
            if (ValidarDatos(matricula, nuevosValoresCamioneta, true))
            {
                mantenimientoCamioneta.AltaDatosCamioneta(matricula, nuevosValoresCamioneta.Capacidad, estado, new List<string>());
                cargarListaCamioneta();
            }
        }
        private void botonModificarCamioneta_Click(object sender, EventArgs e)
        {
            Camioneta camionetaModificada = new Camioneta();
            camionetaModificada.Matricula = entradaMatricula.Text;
            camionetaModificada.Estado = comboBoxEstado.Text;

            try
            {
                camionetaModificada.Capacidad = Int32.Parse(entradaCapacidad.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Debe ingresar un número distinto de cero.");
            }

/*            if (entradaCapacidad.Text == null || entradaCapacidad.Text == "0" || entradaCapacidad.Text == "")
            {
                camionetaModificada.Capacidad = 0;
            }
            else
            {
                camionetaModificada.Capacidad = Int32.Parse(entradaCapacidad.Text);
            } */
            if (ValidarDatos(camionetaModificada.Matricula, camionetaModificada, false))
            { 
                mantenimientoCamioneta.ModificarCamioneta(matriculaCamionetaSeleccionada, camionetaModificada);
                limpiarValoresViejos();
                cargarListaCamioneta();
            }
        }
        private void botonBajaCamioneta_Click(object sender, EventArgs e)
        {
            mantenimientoCamioneta.BajarCamioneta(matriculaCamionetaSeleccionada);
            limpiarValoresViejos();
            cargarListaCamioneta();
        }
        private void limpiarValoresViejos()
        {
            entradaMatricula.Clear();
            entradaCapacidad.Clear();
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Boolean ValidarDatos(string matricula, Camioneta nuevosValores, Boolean comprobarDuplicado)
        {
            if ((matricula.Length == 0) || (nuevosValores.Capacidad == 0 ) || (nuevosValores.Estado.Length == 0))
            {
                MessageBox.Show("Error: Los datos ingresados no son correctos");
                return (false);
            }
            if ((matricula.Trim().Length == 0) || (nuevosValores.Capacidad == 0) || (nuevosValores.Estado.Length == 0))
            {
                MessageBox.Show("Error: Los datos ingresados no son correctos");
                return (false);
            }
            if (mantenimientoCamioneta.CamionetaExistente(matricula) && comprobarDuplicado)
            {
                MessageBox.Show("Error: La camioneta ya existe");
                return (false);
            }
            return (true);

        }
        
 
        
        private void listaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
