﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlumno
{
    public partial class GestionAlumnoFormulario : Form
    {
        public GestionAlumnoFormulario()
        {
            InitializeComponent();
        }
        [STAThread]
        static void Main()
        {
            Application.Run(new GestionAlumnoFormulario());
        }
    }
}
