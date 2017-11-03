namespace InterfazUsuario
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonGestionAlumnos = new System.Windows.Forms.Button();
            this.botonGestionDocentes = new System.Windows.Forms.Button();
            this.botonGestionMaterias = new System.Windows.Forms.Button();
            this.botonGestionCamionetas = new System.Windows.Forms.Button();
            this.botonCargarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonGestionAlumnos
            // 
            this.botonGestionAlumnos.AutoSize = true;
            this.botonGestionAlumnos.Location = new System.Drawing.Point(49, 39);
            this.botonGestionAlumnos.Name = "botonGestionAlumnos";
            this.botonGestionAlumnos.Size = new System.Drawing.Size(125, 23);
            this.botonGestionAlumnos.TabIndex = 0;
            this.botonGestionAlumnos.Text = "Gestion de Alumnos";
            this.botonGestionAlumnos.UseVisualStyleBackColor = true;
            this.botonGestionAlumnos.Click += new System.EventHandler(this.botonGestionAlumnos_Click);
            // 
            // botonGestionDocentes
            // 
            this.botonGestionDocentes.Location = new System.Drawing.Point(49, 78);
            this.botonGestionDocentes.Name = "botonGestionDocentes";
            this.botonGestionDocentes.Size = new System.Drawing.Size(125, 22);
            this.botonGestionDocentes.TabIndex = 1;
            this.botonGestionDocentes.Text = "Gestion de Docentes";
            this.botonGestionDocentes.UseVisualStyleBackColor = true;
            this.botonGestionDocentes.Click += new System.EventHandler(this.botonGestionDocentes_Click);
            // 
            // botonGestionMaterias
            // 
            this.botonGestionMaterias.Location = new System.Drawing.Point(49, 119);
            this.botonGestionMaterias.Name = "botonGestionMaterias";
            this.botonGestionMaterias.Size = new System.Drawing.Size(125, 24);
            this.botonGestionMaterias.TabIndex = 2;
            this.botonGestionMaterias.Text = "Gestion de Materias";
            this.botonGestionMaterias.UseVisualStyleBackColor = true;
            this.botonGestionMaterias.Click += new System.EventHandler(this.botonGestionMaterias_Click);
            // 
            // botonGestionCamionetas
            // 
            this.botonGestionCamionetas.Location = new System.Drawing.Point(49, 168);
            this.botonGestionCamionetas.Name = "botonGestionCamionetas";
            this.botonGestionCamionetas.Size = new System.Drawing.Size(125, 24);
            this.botonGestionCamionetas.TabIndex = 3;
            this.botonGestionCamionetas.Text = "Gestion de Camionetas";
            this.botonGestionCamionetas.UseVisualStyleBackColor = true;
            // 
            // botonCargarDatos
            // 
            this.botonCargarDatos.Location = new System.Drawing.Point(49, 213);
            this.botonCargarDatos.Name = "botonCargarDatos";
            this.botonCargarDatos.Size = new System.Drawing.Size(125, 25);
            this.botonCargarDatos.TabIndex = 4;
            this.botonCargarDatos.Text = "Cargar Datos";
            this.botonCargarDatos.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::InterfazUsuario.Properties.Resources.fondo_ventana;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 245);
            this.Controls.Add(this.botonCargarDatos);
            this.Controls.Add(this.botonGestionCamionetas);
            this.Controls.Add(this.botonGestionMaterias);
            this.Controls.Add(this.botonGestionDocentes);
            this.Controls.Add(this.botonGestionAlumnos);
            this.Name = "VentanaPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonGestionAlumnos;
        private System.Windows.Forms.Button botonGestionDocentes;
        private System.Windows.Forms.Button botonGestionMaterias;
        private System.Windows.Forms.Button botonGestionCamionetas;
        private System.Windows.Forms.Button botonCargarDatos;
    }
}

