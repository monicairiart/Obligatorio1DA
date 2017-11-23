using GestionDocente;
using GestionMateria;
using Persistencia;
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
    public partial class GestionDocenteUI : Form
    {
        MantenimientoDocente mantenimientoDocente = new MantenimientoDocente();
        public static string idDocenteSeleccionado { get; set; }
        MantenimientoMateria mantenimientoMateria = new MantenimientoMateria();
        private ContextoDb contextoDb = new ContextoDb();
        Docente docenteDbSeleccionado;

        public GestionDocenteUI()
        {
            InitializeComponent();
        }

        private void GestionDocenteUI_Load(object sender, EventArgs e)
        {
            listaDocentes.Columns.Add("Id");
            listaDocentes.Columns.Add("CI");
            listaDocentes.Columns.Add("Nombre");
            listaDocentes.Columns.Add("Apellido");
            listaMaterias.Columns.Add("Código");
            listaMaterias.Columns.Add("Materia");
            cargarListaDocente();
        }

        private void cargarListaDocente()
        {
            /*listaDocentes.Items.Clear();
            listaDocentes.View = View.Details;
            foreach (Docente docente in mantenimientoDocente.ObtenerDocentes())
            {
                ListViewItem itemDocente = new ListViewItem(docente.Ci);
                itemDocente.SubItems.Add(docente.Nombre);
                itemDocente.SubItems.Add(docente.Apellido);
                listaDocentes.Items.Add(itemDocente);
            }  */
            List<Docente> registroDocentes = new List<Docente>();
            try
            {
                registroDocentes = contextoDb.Docentes.ToList();
            }
            catch
            {
                MessageBox.Show("Hubo un error al listar los docentes.");
            }
            listaDocentes.Items.Clear();
            listaDocentes.View = View.Details;
            Console.WriteLine("count reg db docentes" + registroDocentes.Count());
            foreach (Docente docente in registroDocentes)
            {
                ListViewItem itemDocente = new ListViewItem(docente.Id.ToString()); //7 agregñue tostring
                itemDocente.SubItems.Add(docente.Ci);                    //7 agregue
                itemDocente.SubItems.Add(docente.Nombre);
                itemDocente.SubItems.Add(docente.Apellido);
                listaDocentes.Items.Add(itemDocente);
            }
        }
        private void listaDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*List<Materia> materiasDelDocente = new List<Materia>();
            ListView.SelectedListViewItemCollection docenteSeleccionado = listaDocentes.SelectedItems;
            if (docenteSeleccionado.Count > 0)
            {
                entradaCIDocente.Text = docenteSeleccionado[0].SubItems[0].Text; 
                entradaNombreDocente.Text = docenteSeleccionado[0].SubItems[1].Text;
                entradaApellidoDocente.Text = docenteSeleccionado[0].SubItems[2].Text;
                ciDocenteSeleccionado = docenteSeleccionado[0].SubItems[0].Text;
                materiasDelDocente = mantenimientoMateria.ObtenerMateriasPorDocente(ciDocenteSeleccionado); 
                cargarListaMateriaDocente(materiasDelDocente);
            }*/
            List<Materia> materiasDelDocente = new List<Materia>();
            ListView.SelectedListViewItemCollection docenteSeleccionado = listaDocentes.SelectedItems;
            if (docenteSeleccionado.Count > 0)
            {
                entradaCIDocente.Text = docenteSeleccionado[0].SubItems[1].Text; //7 cambio todos los indices agrego +1
                entradaNombreDocente.Text = docenteSeleccionado[0].SubItems[2].Text;
                entradaApellidoDocente.Text = docenteSeleccionado[0].SubItems[3].Text;
                idDocenteSeleccionado = docenteSeleccionado[0].SubItems[0].Text;
                int idDocente = Int32.Parse(idDocenteSeleccionado);
                docenteDbSeleccionado = contextoDb.Docentes.Where(docente => docente.Id == idDocente).ToList()[0];
                List<Materia> materiasDb = contextoDb.Materias.ToList();
                List<Materia> materiasDelDocenteDb = materiasDb.FindAll(buscarMateriasDb);
                cargarListaMateriaDocente(materiasDelDocenteDb);
            }
        }
        private bool existeMateriaRelacionada(DocenteMateria docenteMateria, Materia materia)
        {
            return (docenteMateria.MateriaId == materia.Id);
        }

        private bool buscarMateriasDb(Materia materia)
        {
            return docenteDbSeleccionado.DocentesMaterias.ToList().Exists(docenteMateria => existeMateriaRelacionada(docenteMateria, materia));
        }
        private void botonAltaDocente_Click(object sender, EventArgs e)
        {
            /*string nombre = entradaNombreDocente.Text;
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
            }*/
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
                try
                {
                    contextoDb.Docentes.Add(nuevosValoresDocente);
                    contextoDb.SaveChanges();
                    cargarListaDocente();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("error: " + ex.ToString());
                    MessageBox.Show("Hubo un error al agregar un docente.");
                }
            }
        }
        private void botonModificarDocente_Click(object sender, EventArgs e)
        {
            /*Docente docenteModificado = new Docente();
            docenteModificado.Nombre = entradaNombreDocente.Text;
            docenteModificado.Apellido = entradaApellidoDocente.Text;
            docenteModificado.Ci = entradaCIDocente.Text;
            if (ValidarDatos(docenteModificado.Ci, docenteModificado, false))
            {
                mantenimientoDocente.ModificarDocente(ciDocenteSeleccionado, docenteModificado); 
                entradaCIDocente.Clear();
                entradaApellidoDocente.Clear();
                entradaNombreDocente.Clear();
                cargarListaDocente();
            }*/
            Docente docenteModificado = new Docente();
            docenteModificado.Nombre = entradaNombreDocente.Text;
            docenteModificado.Apellido = entradaApellidoDocente.Text;
            docenteModificado.Ci = entradaCIDocente.Text;
            docenteModificado.Id = int.Parse(idDocenteSeleccionado); //7 agregue
            if (ValidarDatos(docenteModificado.Ci, docenteModificado, false))
            {
                mantenimientoDocente.ModificarDocente(idDocenteSeleccionado, docenteModificado); //7 ci x id
                entradaCIDocente.Clear();
                entradaApellidoDocente.Clear();
                entradaNombreDocente.Clear();
                //7 agrefe inio
                Docente docenteBaseDatos = contextoDb.Docentes.Find(docenteModificado.Id);
                if (docenteBaseDatos != null)
                {
                    contextoDb.Entry(docenteBaseDatos).CurrentValues.SetValues(docenteModificado);
                    contextoDb.SaveChanges();
                } //7 fin            
                cargarListaDocente();
            }
        }
        private void botonBajarDocente_Click_1(object sender, EventArgs e)
        {
            /*mantenimientoDocente.BajarDocente(ciDocenteSeleccionado); 
            limpiarValoresViejos();
            cargarListaDocente();*/
            mantenimientoDocente.BajarDocente(idDocenteSeleccionado); //7 ci x id
            //7 agrego inicio
            Docente docenteBaseDatos = contextoDb.Docentes.Find(int.Parse(idDocenteSeleccionado));
            if (docenteBaseDatos != null)
            {
                contextoDb.Docentes.Remove(docenteBaseDatos);
                contextoDb.SaveChanges();
            } //7 fin
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
            AsignarMateriaUI.idDocenteSeleccionado = idDocenteSeleccionado; //7 ci x id
            AsignarMateriaUI.ventanaOrigen = this;
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
