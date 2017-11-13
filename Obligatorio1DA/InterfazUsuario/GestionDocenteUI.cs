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
    public partial class GestionDocenteUI : Form
    {
        MantenimientoDocente mantenimientoDocente = new MantenimientoDocente();
        public static string ciDocenteSeleccionado { get; set; }
        MantenimientoMateria mantenimientoMateria = new MantenimientoMateria();
        public GestionDocenteUI()
        {
            InitializeComponent();
        }

        private void GestionDocenteUI_Load(object sender, EventArgs e)
        {
            mantenimientoDocente.GenerarDatos();
            mantenimientoMateria.GenerarDatos();
            listaDocentes.Columns.Add("CI");
            listaDocentes.Columns.Add("Nombre");
            listaDocentes.Columns.Add("Apellido");
            listaMaterias.Columns.Add("Código");
            listaMaterias.Columns.Add("Materia");
            cargarListaDocente();
        }

        private void cargarListaDocente()
        {
            listaDocentes.Items.Clear();
            listaDocentes.View = View.Details;
            foreach (Docente docente in mantenimientoDocente.ObtenerDocentes())
            {
                ListViewItem itemDocente = new ListViewItem(docente.Ci);
                itemDocente.SubItems.Add(docente.Nombre);
                itemDocente.SubItems.Add(docente.Apellido);
                listaDocentes.Items.Add(itemDocente);
            }
        }
        private void listaDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Materia> materiasDelDocente = new List<Materia>();
            ListView.SelectedListViewItemCollection docenteSeleccionado = listaDocentes.SelectedItems;
            if (docenteSeleccionado.Count > 0)
            {
                entradaCIDocente.Text = docenteSeleccionado[0].SubItems[0].Text; //7 cambio todos los indices agrego +1
                entradaNombreDocente.Text = docenteSeleccionado[0].SubItems[1].Text;
                entradaApellidoDocente.Text = docenteSeleccionado[0].SubItems[2].Text;
                ciDocenteSeleccionado = docenteSeleccionado[0].SubItems[0].Text;
//                materiasDelDocente = mantenimientoMateria.ObtenerMateriasPorDocente(idDocenteSeleccionado); //7 ci x id
//               cargarListaMateriaDocente(materiasDelDocente);
            }
        }

        private void botonAltaDocente_Click(object sender, EventArgs e)
        {
            string nombre = entradaNombreDocente.Text;
            string apellido = entradaApellidoDocente.Text;
            string ci = entradaCIDocente.Text;
            Docente nuevosValoresDocente = new Docente();
            nuevosValoresDocente.Ci = ci;
            nuevosValoresDocente.Nombre = nombre;
            nuevosValoresDocente.Apellido = apellido;
            if (ValidarDatos(ci, nuevosValoresDocente, true))
            {
                mantenimientoDocente.AltaDatosDocente(nombre, apellido, ci);
                cargarListaDocente();
            }
        }
        private void botonModificarDocente_Click(object sender, EventArgs e)
        {
            Docente docenteModificado = new Docente();
            docenteModificado.Nombre = entradaNombreDocente.Text;
            docenteModificado.Apellido = entradaApellidoDocente.Text;
            docenteModificado.Ci = entradaCIDocente.Text;

            if (ValidarDatos(docenteModificado.Ci, docenteModificado, false))
            {
                mantenimientoDocente.ModificarDocente(ciDocenteSeleccionado, docenteModificado); //7 ci x id
                entradaCIDocente.Clear();
                entradaApellidoDocente.Clear();
                entradaNombreDocente.Clear();




                cargarListaDocente();
            }
        }
        private void botonBajarDocente_Click_1(object sender, EventArgs e)
        {
            mantenimientoDocente.BajarDocente(ciDocenteSeleccionado); //7 ci x id
            limpiarValoresViejos();
            cargarListaDocente();
        }

        private void limpiarValoresViejos()
        {
            entradaNombreDocente.Clear();
            entradaApellidoDocente.Clear();
            entradaCIDocente.Clear();
        }
        public void actualizarListaMateriaDocente()
        {
            cargarListaMateriaDocente(mantenimientoMateria.ObtenerMaterias());
        }

        private void cargarListaMateriaDocente(List<Materia> materiasARetornar)
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

        private void botonAsignarMateriaADocente_Click(object sender, EventArgs e)
        {
 //           AsignarMateriaUI.ciDocenteSeleccionado = idDocenteSeleccionado; //7 ci x id
            Form nuevaVentana = new AsignarMateriaUI();
            nuevaVentana.Show();
        }
        private Boolean ValidarDatos(string ci, Docente nuevosValores, Boolean comprobarDuplicado)
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
            if (mantenimientoDocente.DocenteExistente(ci) && comprobarDuplicado)
            {
                MessageBox.Show("Error: El docente ya existe");
                return (false);
            }
            return (true);
        }
        private void botonSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
