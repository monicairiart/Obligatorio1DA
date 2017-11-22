using GestionActividad;
using GestionAlumno;
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
    public partial class GestionActividadUI : Form
    {
        MantenimientoActividad mantenimientoActividad = new MantenimientoActividad();
        public static string codigoActividadSeleccionada;
        MantenimientoAlumno mantenimientoAlumno = new MantenimientoAlumno();
        public GestionActividadUI()
        {
            InitializeComponent();
        }

        private void GestionActividadUI_Load(object sender, EventArgs e)
        {
            listaActividades.Columns.Add("Código Actividad");
            listaActividades.Columns.Add("Nombre");
            listaActividades.Columns.Add("Fecha");
            listaActividades.Columns.Add("Costo");
            listaAlumnosInscriptos.Columns.Add("CI");
            listaAlumnosInscriptos.Columns.Add("Nombre");
            listaAlumnosInscriptos.Columns.Add("Apellido");
            cargarListaActividad();
        }
        private void cargarListaActividad()
        {
            listaActividades.Items.Clear();
            listaActividades.View = View.Details;
            foreach (GestionActividad.Actividad actividad in mantenimientoActividad.ObtenerActividades())
            {
                ListViewItem itemActividad = new ListViewItem(actividad.CodigoActividad);
                itemActividad.SubItems.Add(actividad.Nombre);

                listaActividades.Items.Add(itemActividad);
            }
        }

        private void listaActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> alumnosDeActividad = new List<string>();
            ListView.SelectedListViewItemCollection actividadSeleccionada = listaActividades.SelectedItems;
            if (actividadSeleccionada.Count > 0)
            {
                entradaCodigoActividad.Text = actividadSeleccionada[0].SubItems[0].Text;
                entradaNombreActividad.Text = actividadSeleccionada[0].SubItems[1].Text;
                entradaPickerFecha.Text = actividadSeleccionada[0].SubItems[2].Text;
                entradaCosto.Text = actividadSeleccionada[0].SubItems[3].Text;
                codigoActividadSeleccionada = actividadSeleccionada[0].SubItems[0].Text;
                alumnosDeActividad = mantenimientoActividad.ObtenerActividadPorCodigo(codigoActividadSeleccionada).Alumnos;
                listaAlumnosInscriptos.Items.Clear();
                listaAlumnosInscriptos.View = View.Details;
                foreach (string ci in alumnosDeActividad)
                {
                    Alumno alumno = mantenimientoAlumno.ObtenerAlumnoPorCi(ci);
                    ListViewItem itemAlumno = new ListViewItem(alumno.Ci);
                    itemAlumno.SubItems.Add(alumno.Nombre);
                    itemAlumno.SubItems.Add(alumno.Apellido);
                    listaAlumnosInscriptos.Items.Add(itemAlumno);
                }
            }
        }

        private void botonAltaActividad_Click(object sender, EventArgs e)
        {
            string nombre = entradaNombreActividad.Text;
            string codigoActividad = entradaCodigoActividad.Text;
            // DateTime fecha = Int32.Parse(entradaFecha.TextBox());
            //DateTime fecha = ToString.(entradaPickerFecha.Text);

            int costo = Int32.Parse(entradaCosto.Text);
            Actividad nuevosValoresActividad = new Actividad();
            nuevosValoresActividad.CodigoActividad = codigoActividad;
            nuevosValoresActividad.Nombre = nombre;
            if (ValidarDatos(codigoActividad, nuevosValoresActividad, true))
            {
                mantenimientoActividad.AltaDatosActividad(codigoActividad, nombre, new DateTime(), costo, new List<string>());


                cargarListaActividad();
            }
        }
        private Boolean ValidarDatos(string codigoActividad, Actividad nuevosValores, Boolean comprobarDuplicado)
        {
            if ((codigoActividad.Length == 0) || (nuevosValores.Nombre.Length == 0))
            {
                MessageBox.Show("Error: Los datos ingresados no son correctos");
                return (false);
            }
            if ((codigoActividad.Trim().Length == 0) || (nuevosValores.Nombre.Trim().Length == 0))
            {
                MessageBox.Show("Error: Los datos ingresados no son correctos");
                return (false);
            }
            if (mantenimientoActividad.ActividadExistente(codigoActividad) && comprobarDuplicado)
            {
                MessageBox.Show("Error: La actividad ya existe");
                return (false);
            }
            return (true);
        }
    }
}
