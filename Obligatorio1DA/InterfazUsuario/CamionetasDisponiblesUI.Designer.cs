namespace InterfazUsuario
{
    partial class CamionetasDisponiblesUI
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
            this.panelVentanaCamionetasDisponibles = new System.Windows.Forms.Panel();
            this.listaCamionetasDisponibles = new System.Windows.Forms.ListView();
            this.tituloMantenimientoMateria = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.panelVentanaCamionetasDisponibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVentanaCamionetasDisponibles
            // 
            this.panelVentanaCamionetasDisponibles.Controls.Add(this.listaCamionetasDisponibles);
            this.panelVentanaCamionetasDisponibles.Location = new System.Drawing.Point(0, 55);
            this.panelVentanaCamionetasDisponibles.Name = "panelVentanaCamionetasDisponibles";
            this.panelVentanaCamionetasDisponibles.Size = new System.Drawing.Size(572, 313);
            this.panelVentanaCamionetasDisponibles.TabIndex = 39;
            //this.panelVentanaCamionetasDisponibles.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVentanaCamioneta_Paint);
            // 
            // listaCamionetasDisponibles
            // 
            this.listaCamionetasDisponibles.Location = new System.Drawing.Point(138, 54);
            this.listaCamionetasDisponibles.Name = "listaCamionetasDisponibles";
            this.listaCamionetasDisponibles.Size = new System.Drawing.Size(349, 225);
            this.listaCamionetasDisponibles.TabIndex = 0;
            this.listaCamionetasDisponibles.UseCompatibleStateImageBehavior = false;
            // 
            // tituloMantenimientoMateria
            // 
            this.tituloMantenimientoMateria.AutoSize = true;
            this.tituloMantenimientoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMantenimientoMateria.Location = new System.Drawing.Point(177, 14);
            this.tituloMantenimientoMateria.Name = "tituloMantenimientoMateria";
            this.tituloMantenimientoMateria.Size = new System.Drawing.Size(329, 26);
            this.tituloMantenimientoMateria.TabIndex = 38;
            this.tituloMantenimientoMateria.Text = "Disponibilidad de Camionetas";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(588, 129);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 37;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // CamionetasDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(709, 383);
            this.Controls.Add(this.panelVentanaCamionetasDisponibles);
            this.Controls.Add(this.tituloMantenimientoMateria);
            this.Controls.Add(this.botonSalir);
            this.Name = "CamionetasDisponibles";
            this.Text = "CamionetasDisponibles";
            this.Load += new System.EventHandler(this.CamionetasDisponibles_Load);
            this.panelVentanaCamionetasDisponibles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVentanaCamionetasDisponibles;
        private System.Windows.Forms.ListView listaCamionetasDisponibles;
        private System.Windows.Forms.Label tituloMantenimientoMateria;
        private System.Windows.Forms.Button botonSalir;
    }
}