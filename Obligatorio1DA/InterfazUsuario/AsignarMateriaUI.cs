using GestionAlumno;
using GestionDocente;
using GestionMateria;
using Persistencia;
using RelacionAlumnoMateria;
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
    public partial class AsignarMateriaUI : Form
    {
        MantenimientoMateria mantenimientoMateria = new MantenimientoMateria();
        string idMateriaSeleccionada;
        public static string idDocenteSeleccionado;
        public static string idAlumnoSeleccionado;
        public static Form ventanaOrigen;
        private ContextoDb contextoDb = new ContextoDb();
        public AsignarMateriaUI()
        {
            InitializeComponent();
        }

        private void AsignarMateriaUI_Load(object sender, EventArgs e)
        {

            listaMaterias.Columns.Add("Id");
            listaMaterias.Columns.Add("Código Materia");
            listaMaterias.Columns.Add("Nombre");
            cargarListaMateria();
        }
        private void cargarListaMateria()
        {
            List<Materia> registroMaterias = new List<Materia>(); // contextoDb.Docentes.SqlQuery("Select * from Docentes").ToList(); //07

            try
            {
                registroMaterias = contextoDb.Materias.SqlQuery("Select * from Materias").ToList(); //07
            }
            catch
            {
                MessageBox.Show("Hubo un error al listar los docentes.");
            }
            listaMaterias.Items.Clear();
            listaMaterias.View = View.Details;
            foreach (Materia materia in registroMaterias)
            {
                ListViewItem itemMateria = new ListViewItem(materia.Id.ToString()); //7 agregñue tostring
                itemMateria.SubItems.Add(materia.CodigoMateria);                    //7 agregue
                itemMateria.SubItems.Add(materia.Nombre);
                listaMaterias.Items.Add(itemMateria);
            }
        }
        private void listaMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection materiaSeleccionada = listaMaterias.SelectedItems;
            if (materiaSeleccionada.Count > 0)
            {
                idMateriaSeleccionada = materiaSeleccionada[0].SubItems[0].Text;
            }
        }

        private void botonAltaMateria_Click(object sender, EventArgs e)
        {
            List<Materia> materias = mantenimientoMateria.ObtenerMaterias();
            Boolean volverVentanaDocente = false;
            if (idDocenteSeleccionado != null)
            {
                //AsignacionMateria.AsignarDocenteAMateria(materias, idDocenteSeleccionado, codigoMateriaSeleccionada);
                List<Docente> docentesDb=contextoDb.Docentes.SqlQuery("Select * from Docentes where ci='"+idDocenteSeleccionado+"'").ToList();
                List<Materia> materiasDb = contextoDb.Materias.SqlQuery("Select * from Materias where id='" + idMateriaSeleccionada + "'").ToList();
                DocenteMateria docenteMateriaDb = new DocenteMateria();
                docenteMateriaDb.MateriaId = materiasDb[0].Id;
                docenteMateriaDb.DocenteId = Int32.Parse(idDocenteSeleccionado);
                contextoDb.DocentesMaterias.Add(docenteMateriaDb);
                contextoDb.SaveChanges();
                volverVentanaDocente = true;
                idDocenteSeleccionado = null;
            }
            else if(idAlumnoSeleccionado != null)
            {
                //                AsignacionMateria.AsignarAlumnoAMateria(materias, idAlumnoSeleccionado, idMateriaSeleccionada);
                //VentanaPrincipal.ventanaGestionDocenteUI.actualizarListaMateriaDocente();
                List<Alumno> alumnosDb = contextoDb.Alumnos.SqlQuery("Select * from Alumnoes where ci='" + idAlumnoSeleccionado + "'").ToList();
                List<Materia> materiasDb = contextoDb.Materias.SqlQuery("Select * from Materias where id='" + idMateriaSeleccionada + "'").ToList();
                AlumnoMateria alumnoMateriaDb = new AlumnoMateria();
                alumnoMateriaDb.MateriaId = materiasDb[0].Id;
                alumnoMateriaDb.AlumnoId = Int32.Parse(idAlumnoSeleccionado);
                contextoDb.AlumnosMaterias.Add(alumnoMateriaDb);
                contextoDb.SaveChanges();
                volverVentanaDocente = false;
                idAlumnoSeleccionado = null;
            }
            else
            {
                MessageBox.Show("No se realizo una selección para asignar.");
            }
            ventanaOrigen.Close();
            if (volverVentanaDocente)
            {
                ventanaOrigen = new GestionDocenteUI();
            }
            else
            {
                ventanaOrigen = new GestionAlumnoUI();
            }
            ventanaOrigen.Show();
            Close();
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
