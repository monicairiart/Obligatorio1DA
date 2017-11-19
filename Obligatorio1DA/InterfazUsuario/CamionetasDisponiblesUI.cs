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
    public partial class CamionetasDisponiblesUI : Form
    {
        MantenimientoCamioneta mantenimientoCamioneta = new MantenimientoCamioneta();
        public CamionetasDisponiblesUI()
        {
            InitializeComponent();
        }
        private void CamionetasDisponibles_Load(object sender, EventArgs e)
        {
            listaCamionetasDisponibles.Columns.Add("Matrícula");
            listaCamionetasDisponibles.Columns.Add("Capacidad");
            listaCamionetasDisponibles.Columns.Add("Estado");
            cargarListaCamioneta();
        }
        private void cargarListaCamioneta()
        {
            listaCamionetasDisponibles.Items.Clear();
            listaCamionetasDisponibles.View = View.Details;
//Mantenimiento o mantenimiento
            foreach (Camioneta camioneta in mantenimientoCamioneta.ObtenerCamionetas())
            {
                if (camioneta.Estado == "Disponible")
                {
                    ListViewItem itemCamioneta = new ListViewItem(camioneta.Matricula);
                    itemCamioneta.SubItems.Add(camioneta.Capacidad.ToString());
                    itemCamioneta.SubItems.Add(camioneta.Estado);
                    listaCamionetasDisponibles.Items.Add(itemCamioneta);
                }
            }
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
