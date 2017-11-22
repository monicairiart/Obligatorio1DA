namespace InterfazUsuario
{
    partial class GestionActividadUI
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
            this.entradaCosto = new System.Windows.Forms.TextBox();
            this.tituloCosto = new System.Windows.Forms.Label();
            this.tituloFecha = new System.Windows.Forms.Label();
            this.listaAlumnosInscriptos = new System.Windows.Forms.ListView();
            this.tituloInscripcionAlumnos = new System.Windows.Forms.Label();
            this.tituloCodigoMateria = new System.Windows.Forms.Label();
            this.tituloNombreMateria = new System.Windows.Forms.Label();
            this.entradaCodigoActividad = new System.Windows.Forms.TextBox();
            this.entradaNombreActividad = new System.Windows.Forms.TextBox();
            this.listaActividades = new System.Windows.Forms.ListView();
            this.tituloMantenimientoActividad = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonModificarActividad = new System.Windows.Forms.Button();
            this.botonBajaActividad = new System.Windows.Forms.Button();
            this.botonAltaActividad = new System.Windows.Forms.Button();
            this.entradaPickerFecha = new System.Windows.Forms.DateTimePicker();
            this.panelVentanaMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVentanaMateria
            // 
            this.panelVentanaMateria.Controls.Add(this.entradaPickerFecha);
            this.panelVentanaMateria.Controls.Add(this.entradaCosto);
            this.panelVentanaMateria.Controls.Add(this.tituloCosto);
            this.panelVentanaMateria.Controls.Add(this.tituloFecha);
            this.panelVentanaMateria.Controls.Add(this.listaAlumnosInscriptos);
            this.panelVentanaMateria.Controls.Add(this.tituloInscripcionAlumnos);
            this.panelVentanaMateria.Controls.Add(this.tituloCodigoMateria);
            this.panelVentanaMateria.Controls.Add(this.tituloNombreMateria);
            this.panelVentanaMateria.Controls.Add(this.entradaCodigoActividad);
            this.panelVentanaMateria.Controls.Add(this.entradaNombreActividad);
            this.panelVentanaMateria.Controls.Add(this.listaActividades);
            this.panelVentanaMateria.Location = new System.Drawing.Point(22, 50);
            this.panelVentanaMateria.Name = "panelVentanaMateria";
            this.panelVentanaMateria.Size = new System.Drawing.Size(661, 313);
            this.panelVentanaMateria.TabIndex = 36;
            // 
            // entradaCosto
            // 
            this.entradaCosto.Location = new System.Drawing.Point(433, 57);
            this.entradaCosto.Name = "entradaCosto";
            this.entradaCosto.Size = new System.Drawing.Size(100, 20);
            this.entradaCosto.TabIndex = 39;
            // 
            // tituloCosto
            // 
            this.tituloCosto.AutoSize = true;
            this.tituloCosto.Location = new System.Drawing.Point(439, 26);
            this.tituloCosto.Name = "tituloCosto";
            this.tituloCosto.Size = new System.Drawing.Size(34, 13);
            this.tituloCosto.TabIndex = 37;
            this.tituloCosto.Text = "Costo";
            // 
            // tituloFecha
            // 
            this.tituloFecha.AutoSize = true;
            this.tituloFecha.Location = new System.Drawing.Point(233, 26);
            this.tituloFecha.Name = "tituloFecha";
            this.tituloFecha.Size = new System.Drawing.Size(37, 13);
            this.tituloFecha.TabIndex = 36;
            this.tituloFecha.Text = "Fecha";
            // 
            // listaAlumnosInscriptos
            // 
            this.listaAlumnosInscriptos.Location = new System.Drawing.Point(539, 108);
            this.listaAlumnosInscriptos.Name = "listaAlumnosInscriptos";
            this.listaAlumnosInscriptos.Size = new System.Drawing.Size(122, 186);
            this.listaAlumnosInscriptos.TabIndex = 35;
            this.listaAlumnosInscriptos.UseCompatibleStateImageBehavior = false;
            // 
            // tituloInscripcionAlumnos
            // 
            this.tituloInscripcionAlumnos.AutoSize = true;
            this.tituloInscripcionAlumnos.Location = new System.Drawing.Point(536, 92);
            this.tituloInscripcionAlumnos.Name = "tituloInscripcionAlumnos";
            this.tituloInscripcionAlumnos.Size = new System.Drawing.Size(95, 13);
            this.tituloInscripcionAlumnos.TabIndex = 34;
            this.tituloInscripcionAlumnos.Text = "Alumnos Inscriptos";
            // 
            // tituloCodigoMateria
            // 
            this.tituloCodigoMateria.AutoSize = true;
            this.tituloCodigoMateria.Location = new System.Drawing.Point(12, 26);
            this.tituloCodigoMateria.Name = "tituloCodigoMateria";
            this.tituloCodigoMateria.Size = new System.Drawing.Size(87, 13);
            this.tituloCodigoMateria.TabIndex = 6;
            this.tituloCodigoMateria.Text = "Código Actividad";
            // 
            // tituloNombreMateria
            // 
            this.tituloNombreMateria.AutoSize = true;
            this.tituloNombreMateria.Location = new System.Drawing.Point(127, 26);
            this.tituloNombreMateria.Name = "tituloNombreMateria";
            this.tituloNombreMateria.Size = new System.Drawing.Size(44, 13);
            this.tituloNombreMateria.TabIndex = 4;
            this.tituloNombreMateria.Text = "Nombre";
            // 
            // entradaCodigoActividad
            // 
            this.entradaCodigoActividad.Location = new System.Drawing.Point(15, 57);
            this.entradaCodigoActividad.Name = "entradaCodigoActividad";
            this.entradaCodigoActividad.Size = new System.Drawing.Size(100, 20);
            this.entradaCodigoActividad.TabIndex = 3;
            // 
            // entradaNombreActividad
            // 
            this.entradaNombreActividad.Location = new System.Drawing.Point(121, 57);
            this.entradaNombreActividad.Name = "entradaNombreActividad";
            this.entradaNombreActividad.Size = new System.Drawing.Size(100, 20);
            this.entradaNombreActividad.TabIndex = 1;
            // 
            // listaActividades
            // 
            this.listaActividades.Location = new System.Drawing.Point(15, 92);
            this.listaActividades.Name = "listaActividades";
            this.listaActividades.Size = new System.Drawing.Size(515, 177);
            this.listaActividades.TabIndex = 0;
            this.listaActividades.UseCompatibleStateImageBehavior = false;
            this.listaActividades.SelectedIndexChanged += new System.EventHandler(this.listaActividades_SelectedIndexChanged);
            // 
            // tituloMantenimientoActividad
            // 
            this.tituloMantenimientoActividad.AutoSize = true;
            this.tituloMantenimientoActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMantenimientoActividad.Location = new System.Drawing.Point(199, 9);
            this.tituloMantenimientoActividad.Name = "tituloMantenimientoActividad";
            this.tituloMantenimientoActividad.Size = new System.Drawing.Size(331, 26);
            this.tituloMantenimientoActividad.TabIndex = 35;
            this.tituloMantenimientoActividad.Text = "Mantenimiento de Actividades";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(689, 210);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 34;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            // 
            // botonModificarActividad
            // 
            this.botonModificarActividad.Location = new System.Drawing.Point(689, 147);
            this.botonModificarActividad.Name = "botonModificarActividad";
            this.botonModificarActividad.Size = new System.Drawing.Size(75, 23);
            this.botonModificarActividad.TabIndex = 33;
            this.botonModificarActividad.Text = "Modificación";
            this.botonModificarActividad.UseVisualStyleBackColor = true;
            // 
            // botonBajaActividad
            // 
            this.botonBajaActividad.Location = new System.Drawing.Point(689, 107);
            this.botonBajaActividad.Name = "botonBajaActividad";
            this.botonBajaActividad.Size = new System.Drawing.Size(75, 23);
            this.botonBajaActividad.TabIndex = 32;
            this.botonBajaActividad.Text = "Bajar";
            this.botonBajaActividad.UseVisualStyleBackColor = true;
            // 
            // botonAltaActividad
            // 
            this.botonAltaActividad.Location = new System.Drawing.Point(689, 67);
            this.botonAltaActividad.Name = "botonAltaActividad";
            this.botonAltaActividad.Size = new System.Drawing.Size(75, 23);
            this.botonAltaActividad.TabIndex = 31;
            this.botonAltaActividad.Text = "Agregar";
            this.botonAltaActividad.UseVisualStyleBackColor = true;
            this.botonAltaActividad.Click += new System.EventHandler(this.botonAltaActividad_Click);
            // 
            // entradaPickerFecha
            // 
            this.entradaPickerFecha.Location = new System.Drawing.Point(227, 57);
            this.entradaPickerFecha.Name = "entradaPickerFecha";
            this.entradaPickerFecha.Size = new System.Drawing.Size(200, 20);
            this.entradaPickerFecha.TabIndex = 40;
            this.entradaPickerFecha.Value = new System.DateTime(2017, 11, 21, 0, 0, 0, 0);
            // 
            // GestionActividadUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(818, 372);
            this.Controls.Add(this.panelVentanaMateria);
            this.Controls.Add(this.tituloMantenimientoActividad);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonModificarActividad);
            this.Controls.Add(this.botonBajaActividad);
            this.Controls.Add(this.botonAltaActividad);
            this.Name = "GestionActividadUI";
            this.Text = "GestionActividadUI";
            this.Load += new System.EventHandler(this.GestionActividadUI_Load);
            this.panelVentanaMateria.ResumeLayout(false);
            this.panelVentanaMateria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVentanaMateria;
        private System.Windows.Forms.TextBox entradaCosto;
        private System.Windows.Forms.Label tituloCosto;
        private System.Windows.Forms.Label tituloFecha;
        private System.Windows.Forms.ListView listaAlumnosInscriptos;
        private System.Windows.Forms.Label tituloInscripcionAlumnos;
        private System.Windows.Forms.Label tituloCodigoMateria;
        private System.Windows.Forms.Label tituloNombreMateria;
        private System.Windows.Forms.TextBox entradaCodigoActividad;
        private System.Windows.Forms.TextBox entradaNombreActividad;
        private System.Windows.Forms.ListView listaActividades;
        private System.Windows.Forms.Label tituloMantenimientoActividad;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonModificarActividad;
        private System.Windows.Forms.Button botonBajaActividad;
        private System.Windows.Forms.Button botonAltaActividad;
        private System.Windows.Forms.DateTimePicker entradaPickerFecha;
    }
}