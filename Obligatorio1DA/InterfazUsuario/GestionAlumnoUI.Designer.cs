using System;

namespace InterfazUsuario
{
    partial class GestionAlumnoUI
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
            this.botonBajarAlumno = new System.Windows.Forms.Button();
            this.botonModificarAlumno = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.tituloCIAlumno = new System.Windows.Forms.Label();
            this.tituloNombreAlumno = new System.Windows.Forms.Label();
            this.tituloApellidoAlumno = new System.Windows.Forms.Label();
            this.tituloUbicacionAlumno = new System.Windows.Forms.Label();
            this.tituloMantenimientoAlumnos = new System.Windows.Forms.Label();
            this.entradaCIAlumno = new System.Windows.Forms.TextBox();
            this.entradaNombreAlumno = new System.Windows.Forms.TextBox();
            this.entradaApellidoAlumno = new System.Windows.Forms.TextBox();
            this.entradaUbicacion = new System.Windows.Forms.TextBox();
            this.tituloMateria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listaAlumnos = new System.Windows.Forms.ListView();
            this.listaMaterias = new System.Windows.Forms.ListView();
            this.botonAsignarMateriaAAlumno = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonAltaAlumno
            // 
            this.botonAltaAlumno.Location = new System.Drawing.Point(571, 67);
            this.botonAltaAlumno.Name = "botonAltaAlumno";
            this.botonAltaAlumno.Size = new System.Drawing.Size(75, 23);
            this.botonAltaAlumno.TabIndex = 0;
            this.botonAltaAlumno.Text = "Agregar";
            this.botonAltaAlumno.UseVisualStyleBackColor = true;
            this.botonAltaAlumno.Click += new System.EventHandler(this.botonAltaAlumno_Click);
            // 
            // botonBajarAlumno
            // 
            this.botonBajarAlumno.Location = new System.Drawing.Point(571, 96);
            this.botonBajarAlumno.Name = "botonBajarAlumno";
            this.botonBajarAlumno.Size = new System.Drawing.Size(75, 23);
            this.botonBajarAlumno.TabIndex = 1;
            this.botonBajarAlumno.Text = "Bajar";
            this.botonBajarAlumno.UseVisualStyleBackColor = true;
            this.botonBajarAlumno.Click += new System.EventHandler(this.botonBajarAlumno_Click_1);
            // 
            // botonModificarAlumno
            // 
            this.botonModificarAlumno.Location = new System.Drawing.Point(571, 125);
            this.botonModificarAlumno.Name = "botonModificarAlumno";
            this.botonModificarAlumno.Size = new System.Drawing.Size(75, 23);
            this.botonModificarAlumno.TabIndex = 2;
            this.botonModificarAlumno.Text = "Modificar";
            this.botonModificarAlumno.UseVisualStyleBackColor = true;
            this.botonModificarAlumno.Click += new System.EventHandler(this.botonModificarAlumno_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(571, 197);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 3;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // tituloCIAlumno
            // 
            this.tituloCIAlumno.AutoSize = true;
            this.tituloCIAlumno.Location = new System.Drawing.Point(3, 2);
            this.tituloCIAlumno.Name = "tituloCIAlumno";
            this.tituloCIAlumno.Size = new System.Drawing.Size(90, 13);
            this.tituloCIAlumno.TabIndex = 4;
            this.tituloCIAlumno.Text = "Cédula Identidad:";
            // 
            // tituloNombreAlumno
            // 
            this.tituloNombreAlumno.AutoSize = true;
            this.tituloNombreAlumno.Location = new System.Drawing.Point(126, 3);
            this.tituloNombreAlumno.Name = "tituloNombreAlumno";
            this.tituloNombreAlumno.Size = new System.Drawing.Size(50, 13);
            this.tituloNombreAlumno.TabIndex = 5;
            this.tituloNombreAlumno.Text = "Nombre: ";
            // 
            // tituloApellidoAlumno
            // 
            this.tituloApellidoAlumno.AutoSize = true;
            this.tituloApellidoAlumno.Location = new System.Drawing.Point(239, 3);
            this.tituloApellidoAlumno.Name = "tituloApellidoAlumno";
            this.tituloApellidoAlumno.Size = new System.Drawing.Size(44, 13);
            this.tituloApellidoAlumno.TabIndex = 6;
            this.tituloApellidoAlumno.Text = "Apellido";
            // 
            // tituloUbicacionAlumno
            // 
            this.tituloUbicacionAlumno.AutoSize = true;
            this.tituloUbicacionAlumno.Location = new System.Drawing.Point(324, 5);
            this.tituloUbicacionAlumno.Name = "tituloUbicacionAlumno";
            this.tituloUbicacionAlumno.Size = new System.Drawing.Size(86, 13);
            this.tituloUbicacionAlumno.TabIndex = 7;
            this.tituloUbicacionAlumno.Text = "Ubicación (x, y): ";
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
            // 
            // entradaCIAlumno
            // 
            this.entradaCIAlumno.Location = new System.Drawing.Point(6, 18);
            this.entradaCIAlumno.Name = "entradaCIAlumno";
            this.entradaCIAlumno.Size = new System.Drawing.Size(100, 20);
            this.entradaCIAlumno.TabIndex = 9;
            // 
            // entradaNombreAlumno
            // 
            this.entradaNombreAlumno.Location = new System.Drawing.Point(112, 19);
            this.entradaNombreAlumno.Name = "entradaNombreAlumno";
            this.entradaNombreAlumno.Size = new System.Drawing.Size(100, 20);
            this.entradaNombreAlumno.TabIndex = 10;
            // 
            // entradaApellidoAlumno
            // 
            this.entradaApellidoAlumno.Location = new System.Drawing.Point(218, 19);
            this.entradaApellidoAlumno.Name = "entradaApellidoAlumno";
            this.entradaApellidoAlumno.Size = new System.Drawing.Size(100, 20);
            this.entradaApellidoAlumno.TabIndex = 11;
            // 
            // entradaUbicacion
            // 
            this.entradaUbicacion.Location = new System.Drawing.Point(340, 18);
            this.entradaUbicacion.Name = "entradaUbicacion";
            this.entradaUbicacion.Size = new System.Drawing.Size(42, 20);
            this.entradaUbicacion.TabIndex = 12;
            // 
            // tituloMateria
            // 
            this.tituloMateria.AutoSize = true;
            this.tituloMateria.Location = new System.Drawing.Point(476, 93);
            this.tituloMateria.Name = "tituloMateria";
            this.tituloMateria.Size = new System.Drawing.Size(45, 13);
            this.tituloMateria.TabIndex = 14;
            this.tituloMateria.Text = "Materia:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listaAlumnos);
            this.panel1.Controls.Add(this.tituloCIAlumno);
            this.panel1.Controls.Add(this.entradaCIAlumno);
            this.panel1.Controls.Add(this.tituloNombreAlumno);
            this.panel1.Controls.Add(this.entradaUbicacion);
            this.panel1.Controls.Add(this.tituloUbicacionAlumno);
            this.panel1.Controls.Add(this.entradaNombreAlumno);
            this.panel1.Controls.Add(this.entradaApellidoAlumno);
            this.panel1.Controls.Add(this.tituloApellidoAlumno);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 275);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(6, 49);
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.Size = new System.Drawing.Size(415, 214);
            this.listaAlumnos.TabIndex = 13;
            this.listaAlumnos.UseCompatibleStateImageBehavior = false;
            this.listaAlumnos.SelectedIndexChanged += new System.EventHandler(this.listaAlumnos_SelectedIndexChanged);
            // 
            // listaMaterias
            // 
            this.listaMaterias.Location = new System.Drawing.Point(445, 110);
            this.listaMaterias.Name = "listaMaterias";
            this.listaMaterias.Size = new System.Drawing.Size(120, 220);
            this.listaMaterias.TabIndex = 16;
            this.listaMaterias.UseCompatibleStateImageBehavior = false;
            this.listaMaterias.SelectedIndexChanged += new System.EventHandler(this.listaMaterias_SelectedIndexChanged);
            // 
            // botonAsignarMateriaAAlumno
            // 
            this.botonAsignarMateriaAAlumno.Location = new System.Drawing.Point(571, 154);
            this.botonAsignarMateriaAAlumno.Name = "botonAsignarMateriaAAlumno";
            this.botonAsignarMateriaAAlumno.Size = new System.Drawing.Size(75, 23);
            this.botonAsignarMateriaAAlumno.TabIndex = 29;
            this.botonAsignarMateriaAAlumno.Text = "Asignar";
            this.botonAsignarMateriaAAlumno.UseVisualStyleBackColor = true;
            this.botonAsignarMateriaAAlumno.Click += new System.EventHandler(this.botonAsignarMateriaAAlumno_Click);
            // 
            // GestionAlumnoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(824, 342);
            this.Controls.Add(this.botonAsignarMateriaAAlumno);
            this.Controls.Add(this.listaMaterias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tituloMateria);
            this.Controls.Add(this.tituloMantenimientoAlumnos);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonModificarAlumno);
            this.Controls.Add(this.botonBajarAlumno);
            this.Controls.Add(this.botonAltaAlumno);
            this.Name = "GestionAlumnoUI";
            this.Text = "Gestion de Alumnos";
            this.Load += new System.EventHandler(this.GestionAlumnoUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAltaAlumno;
        private System.Windows.Forms.Button botonBajarAlumno;
        private System.Windows.Forms.Button botonModificarAlumno;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label tituloCIAlumno;
        private System.Windows.Forms.Label tituloNombreAlumno;
        private System.Windows.Forms.Label tituloApellidoAlumno;
        private System.Windows.Forms.Label tituloUbicacionAlumno;
        private System.Windows.Forms.Label tituloMantenimientoAlumnos;
        private System.Windows.Forms.TextBox entradaCIAlumno;
        private System.Windows.Forms.TextBox entradaNombreAlumno;
        private System.Windows.Forms.TextBox entradaApellidoAlumno;
        private System.Windows.Forms.TextBox entradaUbicacion;
        private System.Windows.Forms.Label tituloMateria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listaAlumnos;
        private System.Windows.Forms.ListView listaMaterias;
        private System.Windows.Forms.Button botonAsignarMateriaAAlumno;
    }
}