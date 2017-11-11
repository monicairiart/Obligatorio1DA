namespace InterfazUsuario
{
    partial class GestionMateriaUI
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
            this.tituloDocente = new System.Windows.Forms.Label();
            this.tituloMantenimientoMateria = new System.Windows.Forms.Label();
            this.tituloNombreMateria = new System.Windows.Forms.Label();
            this.tituloCodigoMateria = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonModificarMateria = new System.Windows.Forms.Button();
            this.botonBajaMateria = new System.Windows.Forms.Button();
            this.botonAltaMateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloDocente
            // 
            this.tituloDocente.AutoSize = true;
            this.tituloDocente.Location = new System.Drawing.Point(106, 173);
            this.tituloDocente.Name = "tituloDocente";
            this.tituloDocente.Size = new System.Drawing.Size(51, 13);
            this.tituloDocente.TabIndex = 24;
            this.tituloDocente.Text = "Docente:";
            // 
            // tituloMantenimientoMateria
            // 
            this.tituloMantenimientoMateria.AutoSize = true;
            this.tituloMantenimientoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMantenimientoMateria.Location = new System.Drawing.Point(189, 9);
            this.tituloMantenimientoMateria.Name = "tituloMantenimientoMateria";
            this.tituloMantenimientoMateria.Size = new System.Drawing.Size(299, 26);
            this.tituloMantenimientoMateria.TabIndex = 23;
            this.tituloMantenimientoMateria.Text = "Mantenimiento de Materias";
            this.tituloMantenimientoMateria.Click += new System.EventHandler(this.tituloMantenimientoAlumnos_Click);
            // 
            // tituloNombreMateria
            // 
            this.tituloNombreMateria.AutoSize = true;
            this.tituloNombreMateria.Location = new System.Drawing.Point(103, 93);
            this.tituloNombreMateria.Name = "tituloNombreMateria";
            this.tituloNombreMateria.Size = new System.Drawing.Size(50, 13);
            this.tituloNombreMateria.TabIndex = 20;
            this.tituloNombreMateria.Text = "Nombre: ";
            // 
            // tituloCodigoMateria
            // 
            this.tituloCodigoMateria.AutoSize = true;
            this.tituloCodigoMateria.Location = new System.Drawing.Point(103, 66);
            this.tituloCodigoMateria.Name = "tituloCodigoMateria";
            this.tituloCodigoMateria.Size = new System.Drawing.Size(99, 13);
            this.tituloCodigoMateria.TabIndex = 19;
            this.tituloCodigoMateria.Text = "Código de Materia: ";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(470, 269);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 18;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            // 
            // botonModificarMateria
            // 
            this.botonModificarMateria.Location = new System.Drawing.Point(356, 269);
            this.botonModificarMateria.Name = "botonModificarMateria";
            this.botonModificarMateria.Size = new System.Drawing.Size(75, 23);
            this.botonModificarMateria.TabIndex = 17;
            this.botonModificarMateria.Text = "Modificación";
            this.botonModificarMateria.UseVisualStyleBackColor = true;
            // 
            // botonBajaMateria
            // 
            this.botonBajaMateria.Location = new System.Drawing.Point(275, 269);
            this.botonBajaMateria.Name = "botonBajaMateria";
            this.botonBajaMateria.Size = new System.Drawing.Size(75, 23);
            this.botonBajaMateria.TabIndex = 16;
            this.botonBajaMateria.Text = "Baja";
            this.botonBajaMateria.UseVisualStyleBackColor = true;
            // 
            // botonAltaMateria
            // 
            this.botonAltaMateria.Location = new System.Drawing.Point(194, 269);
            this.botonAltaMateria.Name = "botonAltaMateria";
            this.botonAltaMateria.Size = new System.Drawing.Size(75, 23);
            this.botonAltaMateria.TabIndex = 15;
            this.botonAltaMateria.Text = "Alta";
            this.botonAltaMateria.UseVisualStyleBackColor = true;
            this.botonAltaMateria.Click += new System.EventHandler(this.botonAltaAlumno_Click);
            // 
            // GestionMateriaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(648, 305);
            this.Controls.Add(this.tituloDocente);
            this.Controls.Add(this.tituloMantenimientoMateria);
            this.Controls.Add(this.tituloNombreMateria);
            this.Controls.Add(this.tituloCodigoMateria);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonModificarMateria);
            this.Controls.Add(this.botonBajaMateria);
            this.Controls.Add(this.botonAltaMateria);
            this.Name = "GestionMateriaUI";
            this.Text = "GestionMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloDocente;
        private System.Windows.Forms.Label tituloMantenimientoMateria;
        private System.Windows.Forms.Label tituloNombreMateria;
        private System.Windows.Forms.Label tituloCodigoMateria;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonModificarMateria;
        private System.Windows.Forms.Button botonBajaMateria;
        private System.Windows.Forms.Button botonAltaMateria;
    }
}