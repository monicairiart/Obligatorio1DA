namespace InterfazUsuario
{
    partial class GestionCamionetaUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelVentanaCamioneta = new System.Windows.Forms.Panel();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.tituloEstado = new System.Windows.Forms.Label();
            this.tituloListaAlumnosCamioneta = new System.Windows.Forms.Label();
            this.listaAlumnos = new System.Windows.Forms.ListView();
            this.tituloCodigoMateria = new System.Windows.Forms.Label();
            this.tituloNombreMateria = new System.Windows.Forms.Label();
            this.entradaMatricula = new System.Windows.Forms.TextBox();
            this.entradaCapacidad = new System.Windows.Forms.TextBox();
            this.listaCamionetas = new System.Windows.Forms.ListView();
            this.tituloMantenimientoMateria = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonModificarCamioneta = new System.Windows.Forms.Button();
            this.botonBajaCamioneta = new System.Windows.Forms.Button();
            this.botonAltaCamioneta = new System.Windows.Forms.Button();
            this.botonDisponibilidadCamionetas = new System.Windows.Forms.Button();
            this.panelVentanaCamioneta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVentanaCamioneta
            // 
            this.panelVentanaCamioneta.Controls.Add(this.comboBoxEstado);
            this.panelVentanaCamioneta.Controls.Add(this.tituloEstado);
            this.panelVentanaCamioneta.Controls.Add(this.tituloListaAlumnosCamioneta);
            this.panelVentanaCamioneta.Controls.Add(this.listaAlumnos);
            this.panelVentanaCamioneta.Controls.Add(this.tituloCodigoMateria);
            this.panelVentanaCamioneta.Controls.Add(this.tituloNombreMateria);
            this.panelVentanaCamioneta.Controls.Add(this.entradaMatricula);
            this.panelVentanaCamioneta.Controls.Add(this.entradaCapacidad);
            this.panelVentanaCamioneta.Controls.Add(this.listaCamionetas);
            this.panelVentanaCamioneta.Location = new System.Drawing.Point(12, 58);
            this.panelVentanaCamioneta.Name = "panelVentanaCamioneta";
            this.panelVentanaCamioneta.Size = new System.Drawing.Size(664, 313);
            this.panelVentanaCamioneta.TabIndex = 36;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.comboBoxEstado.Location = new System.Drawing.Point(267, 55);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 36;
            // 
            // tituloEstado
            // 
            this.tituloEstado.AutoSize = true;
            this.tituloEstado.Location = new System.Drawing.Point(273, 26);
            this.tituloEstado.Name = "tituloEstado";
            this.tituloEstado.Size = new System.Drawing.Size(40, 13);
            this.tituloEstado.TabIndex = 34;
            this.tituloEstado.Text = "Estado";
            // 
            // tituloListaAlumnosCamioneta
            // 
            this.tituloListaAlumnosCamioneta.AutoSize = true;
            this.tituloListaAlumnosCamioneta.Location = new System.Drawing.Point(441, 78);
            this.tituloListaAlumnosCamioneta.Name = "tituloListaAlumnosCamioneta";
            this.tituloListaAlumnosCamioneta.Size = new System.Drawing.Size(47, 13);
            this.tituloListaAlumnosCamioneta.TabIndex = 33;
            this.tituloListaAlumnosCamioneta.Text = "Alumnos";
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(387, 94);
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.Size = new System.Drawing.Size(266, 186);
            this.listaAlumnos.TabIndex = 32;
            this.listaAlumnos.UseCompatibleStateImageBehavior = false;
            this.listaAlumnos.SelectedIndexChanged += new System.EventHandler(this.listaAlumnos_SelectedIndexChanged);
            // 
            // tituloCodigoMateria
            // 
            this.tituloCodigoMateria.AutoSize = true;
            this.tituloCodigoMateria.Location = new System.Drawing.Point(21, 26);
            this.tituloCodigoMateria.Name = "tituloCodigoMateria";
            this.tituloCodigoMateria.Size = new System.Drawing.Size(52, 13);
            this.tituloCodigoMateria.TabIndex = 6;
            this.tituloCodigoMateria.Text = "Matrícula";
            // 
            // tituloNombreMateria
            // 
            this.tituloNombreMateria.AutoSize = true;
            this.tituloNombreMateria.Location = new System.Drawing.Point(145, 26);
            this.tituloNombreMateria.Name = "tituloNombreMateria";
            this.tituloNombreMateria.Size = new System.Drawing.Size(58, 13);
            this.tituloNombreMateria.TabIndex = 4;
            this.tituloNombreMateria.Text = "Capacidad";
            // 
            // entradaMatricula
            // 
            this.entradaMatricula.Location = new System.Drawing.Point(24, 56);
            this.entradaMatricula.Name = "entradaMatricula";
            this.entradaMatricula.Size = new System.Drawing.Size(100, 20);
            this.entradaMatricula.TabIndex = 3;
            // 
            // entradaCapacidad
            // 
            this.entradaCapacidad.Location = new System.Drawing.Point(148, 56);
            this.entradaCapacidad.Name = "entradaCapacidad";
            this.entradaCapacidad.Size = new System.Drawing.Size(100, 20);
            this.entradaCapacidad.TabIndex = 1;
            // 
            // listaCamionetas
            // 
            this.listaCamionetas.Location = new System.Drawing.Point(15, 92);
            this.listaCamionetas.Name = "listaCamionetas";
            this.listaCamionetas.Size = new System.Drawing.Size(349, 188);
            this.listaCamionetas.TabIndex = 0;
            this.listaCamionetas.UseCompatibleStateImageBehavior = false;
            this.listaCamionetas.SelectedIndexChanged += new System.EventHandler(this.listaCamionetas_SelectedIndexChanged);
            // 
            // tituloMantenimientoMateria
            // 
            this.tituloMantenimientoMateria.AutoSize = true;
            this.tituloMantenimientoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMantenimientoMateria.Location = new System.Drawing.Point(189, 17);
            this.tituloMantenimientoMateria.Name = "tituloMantenimientoMateria";
            this.tituloMantenimientoMateria.Size = new System.Drawing.Size(335, 26);
            this.tituloMantenimientoMateria.TabIndex = 35;
            this.tituloMantenimientoMateria.Text = "Mantenimiento de Camionetas";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(702, 239);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 34;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonModificarCamioneta
            // 
            this.botonModificarCamioneta.Location = new System.Drawing.Point(702, 176);
            this.botonModificarCamioneta.Name = "botonModificarCamioneta";
            this.botonModificarCamioneta.Size = new System.Drawing.Size(75, 23);
            this.botonModificarCamioneta.TabIndex = 33;
            this.botonModificarCamioneta.Text = "Modificar";
            this.botonModificarCamioneta.UseVisualStyleBackColor = true;
            this.botonModificarCamioneta.Click += new System.EventHandler(this.botonModificarCamioneta_Click);
            // 
            // botonBajaCamioneta
            // 
            this.botonBajaCamioneta.Location = new System.Drawing.Point(702, 136);
            this.botonBajaCamioneta.Name = "botonBajaCamioneta";
            this.botonBajaCamioneta.Size = new System.Drawing.Size(75, 23);
            this.botonBajaCamioneta.TabIndex = 32;
            this.botonBajaCamioneta.Text = "Bajar";
            this.botonBajaCamioneta.UseVisualStyleBackColor = true;
            this.botonBajaCamioneta.Click += new System.EventHandler(this.botonBajaCamioneta_Click);
            // 
            // botonAltaCamioneta
            // 
            this.botonAltaCamioneta.Location = new System.Drawing.Point(702, 96);
            this.botonAltaCamioneta.Name = "botonAltaCamioneta";
            this.botonAltaCamioneta.Size = new System.Drawing.Size(75, 23);
            this.botonAltaCamioneta.TabIndex = 31;
            this.botonAltaCamioneta.Text = "Agregar";
            this.botonAltaCamioneta.UseVisualStyleBackColor = true;
            this.botonAltaCamioneta.Click += new System.EventHandler(this.botonAltaCamioneta_Click_1);
            // 
            // botonDisponibilidadCamionetas
            // 
            this.botonDisponibilidadCamionetas.Location = new System.Drawing.Point(682, 210);
            this.botonDisponibilidadCamionetas.Name = "botonDisponibilidadCamionetas";
            this.botonDisponibilidadCamionetas.Size = new System.Drawing.Size(132, 23);
            this.botonDisponibilidadCamionetas.TabIndex = 37;
            this.botonDisponibilidadCamionetas.Text = "Camionetas Disponibles";
            this.botonDisponibilidadCamionetas.UseVisualStyleBackColor = true;
            this.botonDisponibilidadCamionetas.Click += new System.EventHandler(this.botonDisponibilidadCamionetas_Click);
            // 
            // GestionCamionetaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(818, 372);
            this.Controls.Add(this.botonDisponibilidadCamionetas);
            this.Controls.Add(this.panelVentanaCamioneta);
            this.Controls.Add(this.tituloMantenimientoMateria);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonModificarCamioneta);
            this.Controls.Add(this.botonBajaCamioneta);
            this.Controls.Add(this.botonAltaCamioneta);
            this.Name = "GestionCamionetaUI";
            this.Text = "GestionCamionetas";
            this.Load += new System.EventHandler(this.GestionCamionetaUI_Load);
            this.panelVentanaCamioneta.ResumeLayout(false);
            this.panelVentanaCamioneta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVentanaCamioneta;
        private System.Windows.Forms.Label tituloListaAlumnosCamioneta;
        private System.Windows.Forms.ListView listaAlumnos;
        private System.Windows.Forms.Label tituloCodigoMateria;
        private System.Windows.Forms.Label tituloNombreMateria;
        private System.Windows.Forms.TextBox entradaMatricula;
        private System.Windows.Forms.TextBox entradaCapacidad;
        private System.Windows.Forms.ListView listaCamionetas;
        private System.Windows.Forms.Label tituloMantenimientoMateria;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonModificarCamioneta;
        private System.Windows.Forms.Button botonBajaCamioneta;
        private System.Windows.Forms.Button botonAltaCamioneta;
        private System.Windows.Forms.Label tituloEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Button botonDisponibilidadCamionetas;
    }
}