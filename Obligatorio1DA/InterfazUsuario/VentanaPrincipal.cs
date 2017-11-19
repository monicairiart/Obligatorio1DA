﻿using GestionAlumno;
using GestionCamioneta;
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
    public partial class VentanaPrincipal : Form
    {
        MantenimientoDocente mantenimientoDocente = new MantenimientoDocente();
        MantenimientoAlumno mantenimientoAlumno = new MantenimientoAlumno();
        MantenimientoMateria mantenimientoMateria = new MantenimientoMateria();
        MantenimientoCamioneta mantenimientoCamioneta = new MantenimientoCamioneta();
        public VentanaPrincipal()
        {
            InitializeComponent();
            this.CenterToScreen();
            //this.BackgroundImage();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            mantenimientoDocente.GenerarDatos();
            mantenimientoAlumno.GenerarDatos();
            mantenimientoMateria.GenerarDatos();
            mantenimientoCamioneta.GenerarDatos();

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
