using GestionDocente;
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

        public GestionDocenteUI()
        {
            InitializeComponent();
        }

        private void GestionDocenteUI_Load(object sender, EventArgs e)
        {
            mantenimientoDocente.GenerarDatos();
            //Console.WriteLine("count docentes " + mantenimientoDocente.GetDocentes().Count());
            listaDocentes.Columns.Add("Nombre");
            listaDocentes.Columns.Add("Apellido");
            listaDocentes.Columns.Add("CI");

            /*ListViewItem itemDocente = new ListViewItem("Jose");
            //itemDocente.SubItems.Add("Jose");
            itemDocente.SubItems.Add("Perez");
            itemDocente.SubItems.Add("1111");

            listaDocentes.View = View.Details;
            listaDocentes.Items.Add(itemDocente);*/
            cargarListaDocente();
        }

        private void cargarListaDocente()
        {
            listaDocentes.Items.Clear();
            listaDocentes.View = View.Details;
            foreach (Docente docente in mantenimientoDocente.GetDocentes())
            {
                ListViewItem itemDocente = new ListViewItem(docente.Nombre);
                itemDocente.SubItems.Add(docente.Apellido);
                itemDocente.SubItems.Add(docente.Ci);

                listaDocentes.Items.Add(itemDocente);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listaDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonAltaDocente_Click(object sender, EventArgs e)
        {
            string nombre = entradaNombreDocente.Text;
            string apellido = entradaApellidoDocente.Text;
            string ci = entradaCIDocente.Text;
            mantenimientoDocente.AltaDatosDocente(nombre, apellido, ci, new List<string>());
            cargarListaDocente();
        }
    }
 }
