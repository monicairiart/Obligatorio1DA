namespace InterfazUsuario
{
    partial class AsignarMateriaUI
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
            this.panelVentanaMateria = new System.Windows.Forms.Panel();
            this.listaMaterias = new System.Windows.Forms.ListView();
            this.tituloMantenimientoMateria = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonAltaMateria = new System.Windows.Forms.Button();
            this.panelVentanaMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVentanaMateria
            // 
            this.panelVentanaMateria.Controls.Add(this.listaMaterias);
            this.panelVentanaMateria.Location = new System.Drawing.Point(60, 64);
            this.panelVentanaMateria.Name = "panelVentanaMateria";
            this.panelVentanaMateria.Size = new System.Drawing.Size(475, 313);
            this.panelVentanaMateria.TabIndex = 33;
            // 
            // listaMaterias
            // 
            this.listaMaterias.Location = new System.Drawing.Point(56, 84);
            this.listaMaterias.Name = "listaMaterias";
            this.listaMaterias.Size = new System.Drawing.Size(349, 177);
            this.listaMaterias.TabIndex = 0;
            this.listaMaterias.UseCompatibleStateImageBehavior = false;
            this.listaMaterias.SelectedIndexChanged += new System.EventHandler(this.listaMaterias_SelectedIndexChanged);
            // 
            // tituloMantenimientoMateria
            // 
            this.tituloMantenimientoMateria.AutoSize = true;
            this.tituloMantenimientoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMantenimientoMateria.Location = new System.Drawing.Point(209, 9);
            this.tituloMantenimientoMateria.Name = "tituloMantenimientoMateria";
            this.tituloMantenimientoMateria.Size = new System.Drawing.Size(179, 26);
            this.tituloMantenimientoMateria.TabIndex = 30;
            this.tituloMantenimientoMateria.Text = "Asignar Materia";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(576, 225);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 32;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonAltaMateria
            // 
            this.botonAltaMateria.Location = new System.Drawing.Point(576, 83);
            this.botonAltaMateria.Name = "botonAltaMateria";
            this.botonAltaMateria.Size = new System.Drawing.Size(75, 23);
            this.botonAltaMateria.TabIndex = 31;
            this.botonAltaMateria.Text = "Agregar";
            this.botonAltaMateria.UseVisualStyleBackColor = true;
            this.botonAltaMateria.Click += new System.EventHandler(this.botonAltaMateria_Click);
            // 
            // AsignarMateriaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(744, 417);
            this.Controls.Add(this.panelVentanaMateria);
            this.Controls.Add(this.tituloMantenimientoMateria);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonAltaMateria);
            this.Name = "AsignarMateriaUI";
            this.Text = "AsignarMateriaUI";
            this.Load += new System.EventHandler(this.AsignarMateriaUI_Load);
            this.panelVentanaMateria.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVentanaMateria;
        private System.Windows.Forms.ListView listaMaterias;
        private System.Windows.Forms.Label tituloMantenimientoMateria;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonAltaMateria;
    }
}