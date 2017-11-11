namespace InterfazUsuario
{
    partial class GestionAlumnosUI
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
            this.botonAltaAlumno = new System.Windows.Forms.Button();
            this.botonBajaAlumno = new System.Windows.Forms.Button();
            this.botonModificarAlumno = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.tituloCIAlumno = new System.Windows.Forms.Label();
            this.tituloNombreAlumno = new System.Windows.Forms.Label();
            this.tituloApellidoAlumno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tituloMantenimientoAlumnos = new System.Windows.Forms.Label();
            this.textoCIAlumno = new System.Windows.Forms.TextBox();
            this.textoNombreAlumno = new System.Windows.Forms.TextBox();
            this.textoApellidoAlumno = new System.Windows.Forms.TextBox();
            this.textoUbicacion = new System.Windows.Forms.TextBox();
            this.textoMateria = new System.Windows.Forms.TextBox();
            this.tituloMateria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonAltaAlumno
            // 
            this.botonAltaAlumno.Location = new System.Drawing.Point(169, 270);
            this.botonAltaAlumno.Name = "botonAltaAlumno";
            this.botonAltaAlumno.Size = new System.Drawing.Size(75, 23);
            this.botonAltaAlumno.TabIndex = 0;
            this.botonAltaAlumno.Text = "Alta";
            this.botonAltaAlumno.UseVisualStyleBackColor = true;
            // 
            // botonBajaAlumno
            // 
            this.botonBajaAlumno.Location = new System.Drawing.Point(250, 270);
            this.botonBajaAlumno.Name = "botonBajaAlumno";
            this.botonBajaAlumno.Size = new System.Drawing.Size(75, 23);
            this.botonBajaAlumno.TabIndex = 1;
            this.botonBajaAlumno.Text = "Baja";
            this.botonBajaAlumno.UseVisualStyleBackColor = true;
            // 
            // botonModificarAlumno
            // 
            this.botonModificarAlumno.Location = new System.Drawing.Point(331, 270);
            this.botonModificarAlumno.Name = "botonModificarAlumno";
            this.botonModificarAlumno.Size = new System.Drawing.Size(75, 23);
            this.botonModificarAlumno.TabIndex = 2;
            this.botonModificarAlumno.Text = "Modificación";
            this.botonModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(445, 270);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 3;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            // 
            // tituloCIAlumno
            // 
            this.tituloCIAlumno.AutoSize = true;
            this.tituloCIAlumno.Location = new System.Drawing.Point(78, 67);
            this.tituloCIAlumno.Name = "tituloCIAlumno";
            this.tituloCIAlumno.Size = new System.Drawing.Size(90, 13);
            this.tituloCIAlumno.TabIndex = 4;
            this.tituloCIAlumno.Text = "Cédula Identidad:";
            // 
            // tituloNombreAlumno
            // 
            this.tituloNombreAlumno.AutoSize = true;
            this.tituloNombreAlumno.Location = new System.Drawing.Point(78, 94);
            this.tituloNombreAlumno.Name = "tituloNombreAlumno";
            this.tituloNombreAlumno.Size = new System.Drawing.Size(50, 13);
            this.tituloNombreAlumno.TabIndex = 5;
            this.tituloNombreAlumno.Text = "Nombre: ";
            // 
            // tituloApellidoAlumno
            // 
            this.tituloApellidoAlumno.AutoSize = true;
            this.tituloApellidoAlumno.Location = new System.Drawing.Point(78, 120);
            this.tituloApellidoAlumno.Name = "tituloApellidoAlumno";
            this.tituloApellidoAlumno.Size = new System.Drawing.Size(44, 13);
            this.tituloApellidoAlumno.TabIndex = 6;
            this.tituloApellidoAlumno.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ubicación (x, y): ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tituloMantenimientoAlumnos
            // 
            this.tituloMantenimientoAlumnos.AutoSize = true;
            this.tituloMantenimientoAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMantenimientoAlumnos.Location = new System.Drawing.Point(201, 13);
            this.tituloMantenimientoAlumnos.Name = "tituloMantenimientoAlumnos";
            this.tituloMantenimientoAlumnos.Size = new System.Drawing.Size(301, 26);
            this.tituloMantenimientoAlumnos.TabIndex = 8;
            this.tituloMantenimientoAlumnos.Text = "Mantenimiento de Alumnos";
            this.tituloMantenimientoAlumnos.Click += new System.EventHandler(this.label1_Click);
            // 
            // textoCIAlumno
            // 
            this.textoCIAlumno.Location = new System.Drawing.Point(190, 60);
            this.textoCIAlumno.Name = "textoCIAlumno";
            this.textoCIAlumno.Size = new System.Drawing.Size(100, 20);
            this.textoCIAlumno.TabIndex = 9;
            // 
            // textoNombreAlumno
            // 
            this.textoNombreAlumno.Location = new System.Drawing.Point(190, 87);
            this.textoNombreAlumno.Name = "textoNombreAlumno";
            this.textoNombreAlumno.Size = new System.Drawing.Size(100, 20);
            this.textoNombreAlumno.TabIndex = 10;
            // 
            // textoApellidoAlumno
            // 
            this.textoApellidoAlumno.Location = new System.Drawing.Point(190, 113);
            this.textoApellidoAlumno.Name = "textoApellidoAlumno";
            this.textoApellidoAlumno.Size = new System.Drawing.Size(100, 20);
            this.textoApellidoAlumno.TabIndex = 11;
            // 
            // textoUbicacion
            // 
            this.textoUbicacion.Location = new System.Drawing.Point(190, 139);
            this.textoUbicacion.Name = "textoUbicacion";
            this.textoUbicacion.Size = new System.Drawing.Size(100, 20);
            this.textoUbicacion.TabIndex = 12;
            // 
            // textoMateria
            // 
            this.textoMateria.Location = new System.Drawing.Point(190, 167);
            this.textoMateria.Name = "textoMateria";
            this.textoMateria.Size = new System.Drawing.Size(100, 20);
            this.textoMateria.TabIndex = 13;
            // 
            // tituloMateria
            // 
            this.tituloMateria.AutoSize = true;
            this.tituloMateria.Location = new System.Drawing.Point(81, 174);
            this.tituloMateria.Name = "tituloMateria";
            this.tituloMateria.Size = new System.Drawing.Size(45, 13);
            this.tituloMateria.TabIndex = 14;
            this.tituloMateria.Text = "Materia:";
            // 
            // GestionAlumnosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(648, 305);
            this.Controls.Add(this.tituloMateria);
            this.Controls.Add(this.textoMateria);
            this.Controls.Add(this.textoUbicacion);
            this.Controls.Add(this.textoApellidoAlumno);
            this.Controls.Add(this.textoNombreAlumno);
            this.Controls.Add(this.textoCIAlumno);
            this.Controls.Add(this.tituloMantenimientoAlumnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tituloApellidoAlumno);
            this.Controls.Add(this.tituloNombreAlumno);
            this.Controls.Add(this.tituloCIAlumno);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonModificarAlumno);
            this.Controls.Add(this.botonBajaAlumno);
            this.Controls.Add(this.botonAltaAlumno);
            this.Name = "GestionAlumnosUI";
            this.Text = "Gestion de Alumnos";
            this.Load += new System.EventHandler(this.GestionAlumnosUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAltaAlumno;
        private System.Windows.Forms.Button botonBajaAlumno;
        private System.Windows.Forms.Button botonModificarAlumno;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label tituloCIAlumno;
        private System.Windows.Forms.Label tituloNombreAlumno;
        private System.Windows.Forms.Label tituloApellidoAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tituloMantenimientoAlumnos;
        private System.Windows.Forms.TextBox textoCIAlumno;
        private System.Windows.Forms.TextBox textoNombreAlumno;
        private System.Windows.Forms.TextBox textoApellidoAlumno;
        private System.Windows.Forms.TextBox textoUbicacion;
        private System.Windows.Forms.TextBox textoMateria;
        private System.Windows.Forms.Label tituloMateria;
    }
}