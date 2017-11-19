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
            this.listaAlumnosInscriptos = new System.Windows.Forms.ListView();
            this.tituloInscripcionAlumnos = new System.Windows.Forms.Label();
            this.tituloCodigoMateria = new System.Windows.Forms.Label();
            this.tituloNombreMateria = new System.Windows.Forms.Label();
            this.entradaCodigoMateria = new System.Windows.Forms.TextBox();
            this.entradaNombreMateria = new System.Windows.Forms.TextBox();
            this.listaActividades = new System.Windows.Forms.ListView();
            this.tituloMantenimientoActividad = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonModificarMateria = new System.Windows.Forms.Button();
            this.botonBajaActividad = new System.Windows.Forms.Button();
            this.botonAltaActividad = new System.Windows.Forms.Button();
            this.tituloFecha = new System.Windows.Forms.Label();
            this.tituloCosto = new System.Windows.Forms.Label();
            this.entradaFecha = new System.Windows.Forms.TextBox();
            this.entradaCosto = new System.Windows.Forms.TextBox();
            this.panelVentanaMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVentanaMateria
            // 
            this.panelVentanaMateria.Controls.Add(this.entradaCosto);
            this.panelVentanaMateria.Controls.Add(this.entradaFecha);
            this.panelVentanaMateria.Controls.Add(this.tituloCosto);
            this.panelVentanaMateria.Controls.Add(this.tituloFecha);
            this.panelVentanaMateria.Controls.Add(this.listaAlumnosInscriptos);
            this.panelVentanaMateria.Controls.Add(this.tituloInscripcionAlumnos);
            this.panelVentanaMateria.Controls.Add(this.tituloCodigoMateria);
            this.panelVentanaMateria.Controls.Add(this.tituloNombreMateria);
            this.panelVentanaMateria.Controls.Add(this.entradaCodigoMateria);
            this.panelVentanaMateria.Controls.Add(this.entradaNombreMateria);
            this.panelVentanaMateria.Controls.Add(this.listaActividades);
            this.panelVentanaMateria.Location = new System.Drawing.Point(22, 50);
            this.panelVentanaMateria.Name = "panelVentanaMateria";
            this.panelVentanaMateria.Size = new System.Drawing.Size(661, 313);
            this.panelVentanaMateria.TabIndex = 36;
            // 
            // listaAlumnosInscriptos
            // 
            this.listaAlumnosInscriptos.Location = new System.Drawing.Point(495, 92);
            this.listaAlumnosInscriptos.Name = "listaAlumnosInscriptos";
            this.listaAlumnosInscriptos.Size = new System.Drawing.Size(122, 186);
            this.listaAlumnosInscriptos.TabIndex = 35;
            this.listaAlumnosInscriptos.UseCompatibleStateImageBehavior = false;
            // 
            // tituloInscripcionAlumnos
            // 
            this.tituloInscripcionAlumnos.AutoSize = true;
            this.tituloInscripcionAlumnos.Location = new System.Drawing.Point(492, 66);
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
            // entradaCodigoMateria
            // 
            this.entradaCodigoMateria.Location = new System.Drawing.Point(15, 58);
            this.entradaCodigoMateria.Name = "entradaCodigoMateria";
            this.entradaCodigoMateria.Size = new System.Drawing.Size(100, 20);
            this.entradaCodigoMateria.TabIndex = 3;
            // 
            // entradaNombreMateria
            // 
            this.entradaNombreMateria.Location = new System.Drawing.Point(121, 59);
            this.entradaNombreMateria.Name = "entradaNombreMateria";
            this.entradaNombreMateria.Size = new System.Drawing.Size(100, 20);
            this.entradaNombreMateria.TabIndex = 1;
            // 
            // listaActividades
            // 
            this.listaActividades.Location = new System.Drawing.Point(15, 92);
            this.listaActividades.Name = "listaActividades";
            this.listaActividades.Size = new System.Drawing.Size(420, 177);
            this.listaActividades.TabIndex = 0;
            this.listaActividades.UseCompatibleStateImageBehavior = false;
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
            // botonModificarMateria
            // 
            this.botonModificarMateria.Location = new System.Drawing.Point(689, 147);
            this.botonModificarMateria.Name = "botonModificarMateria";
            this.botonModificarMateria.Size = new System.Drawing.Size(75, 23);
            this.botonModificarMateria.TabIndex = 33;
            this.botonModificarMateria.Text = "Modificación";
            this.botonModificarMateria.UseVisualStyleBackColor = true;
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
            // tituloCosto
            // 
            this.tituloCosto.AutoSize = true;
            this.tituloCosto.Location = new System.Drawing.Point(340, 26);
            this.tituloCosto.Name = "tituloCosto";
            this.tituloCosto.Size = new System.Drawing.Size(34, 13);
            this.tituloCosto.TabIndex = 37;
            this.tituloCosto.Text = "Costo";
            // 
            // entradaFecha
            // 
            this.entradaFecha.Location = new System.Drawing.Point(227, 59);
            this.entradaFecha.Name = "entradaFecha";
            this.entradaFecha.Size = new System.Drawing.Size(100, 20);
            this.entradaFecha.TabIndex = 38;
            // 
            // entradaCosto
            // 
            this.entradaCosto.Location = new System.Drawing.Point(343, 57);
            this.entradaCosto.Name = "entradaCosto";
            this.entradaCosto.Size = new System.Drawing.Size(100, 20);
            this.entradaCosto.TabIndex = 39;
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
            this.Controls.Add(this.botonModificarMateria);
            this.Controls.Add(this.botonBajaActividad);
            this.Controls.Add(this.botonAltaActividad);
            this.Name = "GestionActividadUI";
            this.Text = "GestionActividadUI";
            this.panelVentanaMateria.ResumeLayout(false);
            this.panelVentanaMateria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVentanaMateria;
        private System.Windows.Forms.TextBox entradaCosto;
        private System.Windows.Forms.TextBox entradaFecha;
        private System.Windows.Forms.Label tituloCosto;
        private System.Windows.Forms.Label tituloFecha;
        private System.Windows.Forms.ListView listaAlumnosInscriptos;
        private System.Windows.Forms.Label tituloInscripcionAlumnos;
        private System.Windows.Forms.Label tituloCodigoMateria;
        private System.Windows.Forms.Label tituloNombreMateria;
        private System.Windows.Forms.TextBox entradaCodigoMateria;
        private System.Windows.Forms.TextBox entradaNombreMateria;
        private System.Windows.Forms.ListView listaActividades;
        private System.Windows.Forms.Label tituloMantenimientoActividad;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonModificarMateria;
        private System.Windows.Forms.Button botonBajaActividad;
        private System.Windows.Forms.Button botonAltaActividad;
    }
}