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

/*        private void tituloMantenimientoMateria_Click(object sender, EventArgs e)
        {

        }

        private void panelVentanaMateria_Paint(object sender, PaintEventArgs e)
        {

        }
*/
        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonModificarMateria_Click(object sender, EventArgs e)
        {

        }

        private void botonBajaMateria_Click(object sender, EventArgs e)
        {

        }

        private void botonAltaMateria_Click(object sender, EventArgs e)
        {

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
                matriculaCamionetaSeleccionada = camionetaSeleccionada[0].SubItems[0].Text;
                //    docentesDeMateria = mantenimientoMateria.ObtenerMateriaPorCodigo(codigoMateriaSeleccionada).Docentes;

                alumnosDeCamioneta = mantenimientoCamioneta.ObtenerCamionetaPorMatricula(matriculaCamionetaSeleccionada).Alumnos;
           //     listaCamionetasMateriasDocente.Items.Clear();
             //   listaMateriasDocente.View = View.Details;
                listaAlumnos.Items.Clear();
                listaAlumnos.View = View.Details;

               /* foreach (string ci in docentesDeMateria)
                {
                    Docente docente = mantenimientoDocente.ObtenerDocentePorCi(ci);
                    ListViewItem itemDocente = new ListViewItem(docente.Ci);
                    itemDocente.SubItems.Add(docente.Nombre);
                    itemDocente.SubItems.Add(docente.Apellido);
                    listaMateriasDocente.Items.Add(itemDocente);
                }*/
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
        private void listaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
