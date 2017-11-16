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
            this.tituloMantenimientoMateria = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonModificarMateria = new System.Windows.Forms.Button();
            this.botonBajaMateria = new System.Windows.Forms.Button();
            this.botonAltaMateria = new System.Windows.Forms.Button();
            this.panelVentanaMateria = new System.Windows.Forms.Panel();
            this.listaAlumnosInscriptos = new System.Windows.Forms.ListView();
            this.tituloInscripcionAlumnos = new System.Windows.Forms.Label();
            this.tituloListaMateriasDocente = new System.Windows.Forms.Label();
            this.listaMateriasDocente = new System.Windows.Forms.ListView();
            this.tituloCodigoMateria = new System.Windows.Forms.Label();
            this.tituloNombreMateria = new System.Windows.Forms.Label();
            this.entradaCodigoMateria = new System.Windows.Forms.TextBox();
            this.entradaNombreMateria = new System.Windows.Forms.TextBox();
            this.listaMaterias = new System.Windows.Forms.ListView();
            this.panelVentanaMateria.SuspendLayout();
            this.SuspendLayout();
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
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(712, 209);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 18;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonModificarMateria
            // 
            this.botonModificarMateria.Location = new System.Drawing.Point(712, 146);
            this.botonModificarMateria.Name = "botonModificarMateria";
            this.botonModificarMateria.Size = new System.Drawing.Size(75, 23);
            this.botonModificarMateria.TabIndex = 17;
            this.botonModificarMateria.Text = "Modificación";
            this.botonModificarMateria.UseVisualStyleBackColor = true;
            this.botonModificarMateria.Click += new System.EventHandler(this.botonModificarMateria_Click);
            // 
            // botonBajaMateria
            // 
            this.botonBajaMateria.Location = new System.Drawing.Point(712, 106);
            this.botonBajaMateria.Name = "botonBajaMateria";
            this.botonBajaMateria.Size = new System.Drawing.Size(75, 23);
            this.botonBajaMateria.TabIndex = 16;
            this.botonBajaMateria.Text = "Baja";
            this.botonBajaMateria.UseVisualStyleBackColor = true;
            this.botonBajaMateria.Click += new System.EventHandler(this.botonBajaMateria_Click);
            // 
            // botonAltaMateria
            // 
            this.botonAltaMateria.Location = new System.Drawing.Point(712, 66);
            this.botonAltaMateria.Name = "botonAltaMateria";
            this.botonAltaMateria.Size = new System.Drawing.Size(75, 23);
            this.botonAltaMateria.TabIndex = 15;
            this.botonAltaMateria.Text = "Alta";
            this.botonAltaMateria.UseVisualStyleBackColor = true;
            this.botonAltaMateria.Click += new System.EventHandler(this.botonAltaMateria_Click);
            // 
            // panelVentanaMateria
            // 
            this.panelVentanaMateria.Controls.Add(this.listaAlumnosInscriptos);
            this.panelVentanaMateria.Controls.Add(this.tituloInscripcionAlumnos);
            this.panelVentanaMateria.Controls.Add(this.tituloListaMateriasDocente);
            this.panelVentanaMateria.Controls.Add(this.listaMateriasDocente);
            this.panelVentanaMateria.Controls.Add(this.tituloCodigoMateria);
            this.panelVentanaMateria.Controls.Add(this.tituloNombreMateria);
            this.panelVentanaMateria.Controls.Add(this.entradaCodigoMateria);
            this.panelVentanaMateria.Controls.Add(this.entradaNombreMateria);
            this.panelVentanaMateria.Controls.Add(this.listaMaterias);
            this.panelVentanaMateria.Location = new System.Drawing.Point(12, 50);
            this.panelVentanaMateria.Name = "panelVentanaMateria";
            this.panelVentanaMateria.Size = new System.Drawing.Size(694, 313);
            this.panelVentanaMateria.TabIndex = 30;
            // 
            // listaAlumnosInscriptos
            // 
            this.listaAlumnosInscriptos.Location = new System.Drawing.Point(551, 94);
            this.listaAlumnosInscriptos.Name = "listaAlumnosInscriptos";
            this.listaAlumnosInscriptos.Size = new System.Drawing.Size(122, 186);
            this.listaAlumnosInscriptos.TabIndex = 35;
            this.listaAlumnosInscriptos.UseCompatibleStateImageBehavior = false;
            // 
            // tituloInscripcionAlumnos
            // 
            this.tituloInscripcionAlumnos.AutoSize = true;
            this.tituloInscripcionAlumnos.Location = new System.Drawing.Point(548, 65);
            this.tituloInscripcionAlumnos.Name = "tituloInscripcionAlumnos";
            this.tituloInscripcionAlumnos.Size = new System.Drawing.Size(95, 13);
            this.tituloInscripcionAlumnos.TabIndex = 34;
            this.tituloInscripcionAlumnos.Text = "Alumnos Inscriptos";
            // 
            // tituloListaMateriasDocente
            // 
            this.tituloListaMateriasDocente.AutoSize = true;
            this.tituloListaMateriasDocente.Location = new System.Drawing.Point(394, 65);
            this.tituloListaMateriasDocente.Name = "tituloListaMateriasDocente";
            this.tituloListaMateriasDocente.Size = new System.Drawing.Size(114, 13);
            this.tituloListaMateriasDocente.TabIndex = 33;
            this.tituloListaMateriasDocente.Text = "Asignadas a Docentes";
            // 
            // listaMateriasDocente
            // 
            this.listaMateriasDocente.Location = new System.Drawing.Point(394, 94);
            this.listaMateriasDocente.Name = "listaMateriasDocente";
            this.listaMateriasDocente.Size = new System.Drawing.Size(120, 186);
            this.listaMateriasDocente.TabIndex = 32;
            this.listaMateriasDocente.UseCompatibleStateImageBehavior = false;
            // 
            // tituloCodigoMateria
            // 
            this.tituloCodigoMateria.AutoSize = true;
            this.tituloCodigoMateria.Location = new System.Drawing.Point(12, 26);
            this.tituloCodigoMateria.Name = "tituloCodigoMateria";
            this.tituloCodigoMateria.Size = new System.Drawing.Size(78, 13);
            this.tituloCodigoMateria.TabIndex = 6;
            this.tituloCodigoMateria.Text = "Código Materia";
            // 
            // tituloNombreMateria
            // 
            this.tituloNombreMateria.AutoSize = true;
            this.tituloNombreMateria.Location = new System.Drawing.Point(145, 26);
            this.tituloNombreMateria.Name = "tituloNombreMateria";
            this.tituloNombreMateria.Size = new System.Drawing.Size(44, 13);
            this.tituloNombreMateria.TabIndex = 4;
            this.tituloNombreMateria.Text = "Nombre";
            // 
            // entradaCodigoMateria
            // 
            this.entradaCodigoMateria.Location = new System.Drawing.Point(15, 58);
            this.entradaCodigoMateria.Name = "entradaCodigoMateria";
            this.entradaCodigoMateria.Size = new System.Drawing.Size(100, 20);
            this.entradaCodigoMateria.TabIndex = 3;
            // 
            // entradaNombreMateria
            // 
            this.entradaNombreMateria.Location = new System.Drawing.Point(148, 56);
            this.entradaNombreMateria.Name = "entradaNombreMateria";
            this.entradaNombreMateria.Size = new System.Drawing.Size(100, 20);
            this.entradaNombreMateria.TabIndex = 1;
            // 
            // listaMaterias
            // 
            this.listaMaterias.Location = new System.Drawing.Point(15, 92);
            this.listaMaterias.Name = "listaMaterias";
            this.listaMaterias.Size = new System.Drawing.Size(349, 177);
            this.listaMaterias.TabIndex = 0;
            this.listaMaterias.UseCompatibleStateImageBehavior = false;
            this.listaMaterias.SelectedIndexChanged += new System.EventHandler(this.listaMaterias_SelectedIndexChanged);
            // 
            // GestionMateriaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(806, 305);
            this.Controls.Add(this.panelVentanaMateria);
            this.Controls.Add(this.tituloMantenimientoMateria);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonModificarMateria);
            this.Controls.Add(this.botonBajaMateria);
            this.Controls.Add(this.botonAltaMateria);
            this.Name = "GestionMateriaUI";
            this.Text = "GestionMateria";
            this.Load += new System.EventHandler(this.GestionMateriaUI_Load);
            this.panelVentanaMateria.ResumeLayout(false);
            this.panelVentanaMateria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloMantenimientoMateria;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonModificarMateria;
        private System.Windows.Forms.Button botonBajaMateria;
        private System.Windows.Forms.Button botonAltaMateria;
        private System.Windows.Forms.Panel panelVentanaMateria;
        private System.Windows.Forms.ListView listaAlumnosInscriptos;
        private System.Windows.Forms.Label tituloInscripcionAlumnos;
        private System.Windows.Forms.Label tituloListaMateriasDocente;
        private System.Windows.Forms.ListView listaMateriasDocente;
        private System.Windows.Forms.Label tituloCodigoMateria;
        private System.Windows.Forms.Label tituloNombreMateria;
        private System.Windows.Forms.TextBox entradaCodigoMateria;
        private System.Windows.Forms.TextBox entradaNombreMateria;
        private System.Windows.Forms.ListView listaMaterias;
    }
}