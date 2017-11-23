using GestionAlumno;
using GestionMateria;
using Persistencia;
using RelacionAlumnoMateria;
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
        public static string idAlumnoSeleccionado { get; set; }
        MantenimientoMateria mantenimientoMateria = new MantenimientoMateria();
        private ContextoDb contextoDb = new ContextoDb();
        Alumno alumnoDbSeleccionado;
        public GestionAlumnoUI()
        {
            InitializeComponent();
        }
        private void GestionAlumnoUI_Load(object sender, EventArgs e)
        {
            //            mantenimientoAlumno.GenerarDatos();
            //            mantenimientoMateria.GenerarDatos();
            listaAlumnos.Columns.Add("Id");
            listaAlumnos.Columns.Add("CI");
            listaAlumnos.Columns.Add("Nombre");
            listaAlumnos.Columns.Add("Apellido");
            listaAlumnos.Columns.Add("Ubicacion x,y");
            listaMaterias.Columns.Add("Código");
            listaMaterias.Columns.Add("Materia");
            cargarListaAlumno();
        }
        private void cargarListaAlumno()
        {
            List<Alumno> registroAlumnos = new List<Alumno>();
            try
            {
                registroAlumnos = contextoDb.Alumnos.ToList();
            }
            catch
            {
                MessageBox.Show("Hubo un error al listar los alumnos.");
            }
            listaAlumnos.Items.Clear();
            listaAlumnos.View = View.Details;
            foreach (Alumno alumno in registroAlumnos)
            {
                ListViewItem itemAlumno = new ListViewItem(alumno.Id.ToString());
                itemAlumno.SubItems.Add(alumno.Ci);
                itemAlumno.SubItems.Add(alumno.Nombre);
                itemAlumno.SubItems.Add(alumno.Apellido);
                itemAlumno.SubItems.Add(alumno.Ubicacion.ToString());
                listaAlumnos.Items.Add(itemAlumno);
            }
        }
        private void listaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*List<Materia> materiasDelAlumno = new List<Materia>();
            ListView.SelectedListViewItemCollection alumnoSeleccionado = listaAlumnos.SelectedItems;
            if (alumnoSeleccionado.Count > 0)
            {
                entradaCIAlumno.Text = alumnoSeleccionado[0].SubItems[1].Text;
                entradaNombreAlumno.Text = alumnoSeleccionado[0].SubItems[2].Text;
                entradaApellidoAlumno.Text = alumnoSeleccionado[0].SubItems[3].Text;
                entradaUbicacionX.Text = alumnoSeleccionado[0].SubItems[4].Text;
                entradaUbicacionY.Text = alumnoSeleccionado[0].SubItems[5].Text;
                idAlumnoSeleccionado = alumnoSeleccionado[0].SubItems[0].Text;
                int idAlumno = Int32.Parse(idAlumnoSeleccionado);
                alumnoDbSeleccionado = contextoDb.Alumnos.Where(alumno => alumno.Id == idAlumno).ToList()[0];
                List<Materia> materiasDb = contextoDb.Materias.ToList();
                
                //materiasDelAlumno = mantenimientoMateria.ObtenerMateriasPorAlumno(idAlumnoSeleccionado);
                //cargarListaMateriaAlumno(materiasDelAlumno);
            }*/
            List<Materia> materiasDelAlumno = new List<Materia>();
            ListView.SelectedListViewItemCollection alumnoSeleccionado = listaAlumnos.SelectedItems;
            if (alumnoSeleccionado.Count > 0)
            {
                entradaCIAlumno.Text = alumnoSeleccionado[0].SubItems[1].Text;
                entradaNombreAlumno.Text = alumnoSeleccionado[0].SubItems[2].Text;
                entradaApellidoAlumno.Text = alumnoSeleccionado[0].SubItems[3].Text;
                entradaUbicacion.Text = alumnoSeleccionado[0].SubItems[4].ToString();
                idAlumnoSeleccionado = alumnoSeleccionado[0].SubItems[0].Text;
                int idAlumno = Int32.Parse(idAlumnoSeleccionado);
                alumnoDbSeleccionado = contextoDb.Alumnos.Where(alumno => alumno.Id == idAlumno).ToList()[0];
                List<Materia> materiasDb = contextoDb.Materias.ToList();
                List<Materia> materiasDelAlumnoDb = materiasDb.FindAll(buscarMateriasDb);
                cargarListaMateriaAlumno(materiasDelAlumnoDb);

            }
        }
        private bool existeMateriaRelacionada(AlumnoMateria alumnoMateria, Materia materia)
        {
            return (alumnoMateria.MateriaId == materia.Id);
        }

        private bool buscarMateriasDb(Materia materia)
        {
            return alumnoDbSeleccionado.AlumnosMaterias.ToList().Exists(alumnoMateria => existeMateriaRelacionada(alumnoMateria, materia));
        }
        private void botonAltaAlumno_Click(object sender, EventArgs e)
        {
            string nombre = entradaNombreAlumno.Text;
            string apellido = entradaApellidoAlumno.Text;
            string ci = entradaCIAlumno.Text;
            double ubicacion = 1.2;    //Double.Parse.ToString(entradaUbicacion);
            /////Tuple ubicacion = Tuple.Create(entradaUbicacionX.Text, entradaUbicacionY.Text);
           // Tuple<double, double> ubicacion = entradaUbicacionX.Text;
           //     ubicacion.Item1, ubicacion.//
            Alumno nuevosValoresAlumno = new Alumno();
            nuevosValoresAlumno.Ci = ci;
            nuevosValoresAlumno.Nombre = nombre;
            nuevosValoresAlumno.Apellido = apellido;
            if (ValidarDatos(ci, nuevosValoresAlumno, true))
            {
                mantenimientoAlumno.AltaDatosAlumno(nombre, apellido, ci, ubicacion);
                try
                {
                    contextoDb.Alumnos.Add(nuevosValoresAlumno);
                    contextoDb.SaveChanges();
                    /////////tuple
                    //mantenimientoAlumno.AltaDatosAlumno(nombre, apellido, ci, Tuple.Create(1.0, 2.0));
                    cargarListaAlumno();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("error: " + ex.ToString());
                    MessageBox.Show("Hubo un error al agregar un alumno.");
                }
            }
        }
        private void botonModificarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumnoModificado = new Alumno();

            alumnoModificado.Nombre = entradaNombreAlumno.Text;
            alumnoModificado.Apellido = entradaApellidoAlumno.Text;
            alumnoModificado.Ci = entradaCIAlumno.Text;
            alumnoModificado.Id = int.Parse(idAlumnoSeleccionado);
            if (ValidarDatos(alumnoModificado.Ci, alumnoModificado, false))
            {
                mantenimientoAlumno.ModificarAlumno(idAlumnoSeleccionado, alumnoModificado);
                entradaCIAlumno.Clear();
                entradaApellidoAlumno.Clear();
                entradaNombreAlumno.Clear();
                Alumno alumnoBaseDatos = contextoDb.Alumnos.Find(alumnoModificado.Id);
                if (alumnoBaseDatos != null)
                {
                    contextoDb.Entry(alumnoBaseDatos).CurrentValues.SetValues(alumnoModificado);
                    contextoDb.SaveChanges();
                }
                cargarListaAlumno();
            }
        }
        private void botonBajarAlumno_Click_1(object sender, EventArgs e)
        {
            /*mantenimientoAlumno.BajarAlumno(idAlumnoSeleccionado);
            limpiarValoresViejos();
            cargarListaAlumno();*/
            mantenimientoAlumno.BajarAlumno(idAlumnoSeleccionado); //7 ci x id
            //7 agrego inicio
            Alumno alumnoBaseDatos = contextoDb.Alumnos.Find(int.Parse(idAlumnoSeleccionado));
            if (alumnoBaseDatos != null)
            {
                contextoDb.Alumnos.Remove(alumnoBaseDatos);
                contextoDb.SaveChanges();
            } //7 fin
            limpiarValoresViejos();
            cargarListaAlumno();
        }
        private void limpiarValoresViejos()
        {
            entradaNombreAlumno.Clear();
            entradaApellidoAlumno.Clear();
            entradaCIAlumno.Clear();
            entradaUbicacion.Clear();
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
            AsignarMateriaUI.idAlumnoSeleccionado = idAlumnoSeleccionado;
            AsignarMateriaUI.ventanaOrigen = this;
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
