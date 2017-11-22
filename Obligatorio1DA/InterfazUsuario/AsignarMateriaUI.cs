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
    public partial class AsignarMateriaUI : Form
    {
        MantenimientoMateria mantenimientoMateria = new MantenimientoMateria();
        string codigoMateriaSeleccionada;
        public static string ciDocenteSeleccionado;
        public static string ciAlumnoSeleccionado;
        public static Form ventanaOrigen;
        //private ContextoDb contextoDb = new ContextoDb();
        public AsignarMateriaUI()
        {
            InitializeComponent();
        }

        private void AsignarMateriaUI_Load(object sender, EventArgs e)
        {

            mantenimientoMateria.GenerarDatos();
            //Console.WriteLine("count alumnos " + mantenimientoAlumno.GetAlumnos().Count());
            listaMaterias.Columns.Add("Código Materia");
            listaMaterias.Columns.Add("Nombre");

            ListViewItem itemMateria = new ListViewItem();
            //itemAlumno.SubItems.Add("Matematicas");
            //itemAlumno.SubItems.Add("1MA");

            listaMaterias.View = View.Details;
            listaMaterias.Items.Add(itemMateria);
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
            ListView.SelectedListViewItemCollection materiaSeleccionada = listaMaterias.SelectedItems;
            if (materiaSeleccionada.Count > 0)
            {
                codigoMateriaSeleccionada = materiaSeleccionada[0].SubItems[0].Text;
            }
        }

        private void botonAltaMateria_Click(object sender, EventArgs e)
        {
            List<Materia> materias = mantenimientoMateria.ObtenerMaterias();
            if (ciDocenteSeleccionado != null)
            {
                AsignacionMateria.AsignarDocenteAMateria(materias, ciDocenteSeleccionado, codigoMateriaSeleccionada);
                //                List<Docente> docentesDb=contextoDb.Docentes.SqlQuery("Select * from Docentes where ci='"+ciDocenteSeleccionado+"'").ToList();
                /*List<Materia> materiasDb = contextoDb.Materias.SqlQuery("Select * from Materias where codigoMateria='" + codigoMateriaSeleccionada + "'").ToList();
                DocenteMateria docenteMateriaDb = new DocenteMateria();
                docenteMateriaDb.MateriaId = materiasDb[0].Id;
                docenteMateriaDb.DocenteId = Int32.Parse(idDocenteSeleccionado);
                contextoDb.DocentesMaterias.Add(docenteMateriaDb);
                contextoDb.SaveChanges();*/


                //VentanaPrincipal.ventanaGestionDocenteUI.actualizarListaMateriaDocente();
                ciDocenteSeleccionado = null;
            }
            else
            {
                AsignacionMateria.AsignarAlumnoAMateria(materias, ciAlumnoSeleccionado, codigoMateriaSeleccionada);
                //VentanaPrincipal.ventanaGestionDocenteUI.actualizarListaMateriaDocente();
                ciAlumnoSeleccionado = null;
            }
            /*
            ventanaOrigen.Close();
            ventanaOrigen = new GestionDocenteUI();
            ventanaOrigen.Show();
*/
            Close();
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
