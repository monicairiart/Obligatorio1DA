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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            this.CenterToScreen();
            //this.BackgroundImage();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void botonGestionAlumnos_Click(object sender, EventArgs e)
        {
            Form nuevaVentana = new GestionAlumnoUI();
            nuevaVentana.Show();
           // Console.ReadKey();
        }

        private void botonGestionMaterias_Click(object sender, EventArgs e)
        {
            Form nuevaVentana = new GestionMateriaUI();
            nuevaVentana.Show();
            //Console.ReadKey();
        }

        private void botonGestionDocentes_Click(object sender, EventArgs e)
        {
            Form nuevaVentana = new GestionDocenteUI();
            nuevaVentana.Show();
            //Console.ReadKey();
        }
    }
}
