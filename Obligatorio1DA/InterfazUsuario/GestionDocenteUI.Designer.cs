using GestionDocente;

namespace InterfazUsuario
{
    partial class GestionDocenteUI
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
            this.tituloMantenimientosDocentes = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonAltaDocente = new System.Windows.Forms.Button();
            this.panelVentanaDocente = new System.Windows.Forms.Panel();
            this.tituloListaMaterias = new System.Windows.Forms.Label();
            this.listaMaterias = new System.Windows.Forms.ListView();
            this.tituloCIDocente = new System.Windows.Forms.Label();
            this.tituloApellidoDocente = new System.Windows.Forms.Label();
            this.tituloNombreDocente = new System.Windows.Forms.Label();
            this.entradaCIDocente = new System.Windows.Forms.TextBox();
            this.entradaApellidoDocente = new System.Windows.Forms.TextBox();
            this.entradaNombreDocente = new System.Windows.Forms.TextBox();
            this.listaDocentes = new System.Windows.Forms.ListView();
            this.botonBajarDocente = new System.Windows.Forms.Button();
            this.botonModificarDocente = new System.Windows.Forms.Button();
            this.botonAsignarMateriaADocente = new System.Windows.Forms.Button();
            this.panelVentanaDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloMantenimientosDocentes
            // 
            this.tituloMantenimientosDocentes.AutoSize = true;
            this.tituloMantenimientosDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloMantenimientosDocentes.Location = new System.Drawing.Point(185, 9);
            this.tituloMantenimientosDocentes.Name = "tituloMantenimientosDocentes";
            this.tituloMantenimientosDocentes.Size = new System.Drawing.Size(308, 26);
            this.tituloMantenimientosDocentes.TabIndex = 23;
            this.tituloMantenimientosDocentes.Text = "Mantenimiento de Docentes";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(561, 222);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 18;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click_1);
            // 
            // botonAltaDocente
            // 
            this.botonAltaDocente.Location = new System.Drawing.Point(561, 80);
            this.botonAltaDocente.Name = "botonAltaDocente";
            this.botonAltaDocente.Size = new System.Drawing.Size(75, 23);
            this.botonAltaDocente.TabIndex = 15;
            this.botonAltaDocente.Text = "Agregar";
            this.botonAltaDocente.UseVisualStyleBackColor = true;
            this.botonAltaDocente.Click += new System.EventHandler(this.botonAltaDocente_Click);
            // 
            // panelVentanaDocente
            // 
            this.panelVentanaDocente.Controls.Add(this.tituloListaMaterias);
            this.panelVentanaDocente.Controls.Add(this.listaMaterias);
            this.panelVentanaDocente.Controls.Add(this.tituloCIDocente);
            this.panelVentanaDocente.Controls.Add(this.tituloApellidoDocente);
            this.panelVentanaDocente.Controls.Add(this.tituloNombreDocente);
            this.panelVentanaDocente.Controls.Add(this.entradaCIDocente);
            this.panelVentanaDocente.Controls.Add(this.entradaApellidoDocente);
            this.panelVentanaDocente.Controls.Add(this.entradaNombreDocente);
            this.panelVentanaDocente.Controls.Add(this.listaDocentes);
            this.panelVentanaDocente.Location = new System.Drawing.Point(45, 61);
            this.panelVentanaDocente.Name = "panelVentanaDocente";
            this.panelVentanaDocente.Size = new System.Drawing.Size(510, 313);
            this.panelVentanaDocente.TabIndex = 24;
            // 
            // tituloListaMaterias
            // 
            this.tituloListaMaterias.AutoSize = true;
            this.tituloListaMaterias.Location = new System.Drawing.Point(384, 55);
            this.tituloListaMaterias.Name = "tituloListaMaterias";
            this.tituloListaMaterias.Size = new System.Drawing.Size(99, 13);
            this.tituloListaMaterias.TabIndex = 10;
            this.tituloListaMaterias.Text = "Materias Asignadas";
            // 
            // listaMaterias
            // 
            this.listaMaterias.Location = new System.Drawing.Point(384, 84);
            this.listaMaterias.Name = "listaMaterias";
            this.listaMaterias.Size = new System.Drawing.Size(120, 186);
            this.listaMaterias.TabIndex = 9;
            this.listaMaterias.UseCompatibleStateImageBehavior = false;
            // 
            // tituloCIDocente
            // 
            this.tituloCIDocente.AutoSize = true;
            this.tituloCIDocente.Location = new System.Drawing.Point(18, 19);
            this.tituloCIDocente.Name = "tituloCIDocente";
            this.tituloCIDocente.Size = new System.Drawing.Size(87, 13);
            this.tituloCIDocente.TabIndex = 6;
            this.tituloCIDocente.Text = "Cédula Identidad";
            // 
            // tituloApellidoDocente
            // 
            this.tituloApellidoDocente.AutoSize = true;
            this.tituloApellidoDocente.Location = new System.Drawing.Point(266, 18);
            this.tituloApellidoDocente.Name = "tituloApellidoDocente";
            this.tituloApellidoDocente.Size = new System.Drawing.Size(44, 13);
            this.tituloApellidoDocente.TabIndex = 5;
            this.tituloApellidoDocente.Text = "Apellido";
            // 
            // tituloNombreDocente
            // 
            this.tituloNombreDocente.AutoSize = true;
            this.tituloNombreDocente.Location = new System.Drawing.Point(136, 19);
            this.tituloNombreDocente.Name = "tituloNombreDocente";
            this.tituloNombreDocente.Size = new System.Drawing.Size(44, 13);
            this.tituloNombreDocente.TabIndex = 4;
            this.tituloNombreDocente.Text = "Nombre";
            // 
            // entradaCIDocente
            // 
            this.entradaCIDocente.Location = new System.Drawing.Point(12, 48);
            this.entradaCIDocente.Name = "entradaCIDocente";
            this.entradaCIDocente.Size = new System.Drawing.Size(100, 20);
            this.entradaCIDocente.TabIndex = 3;
            // 
            // entradaApellidoDocente
            // 
            this.entradaApellidoDocente.Location = new System.Drawing.Point(266, 48);
            this.entradaApellidoDocente.Name = "entradaApellidoDocente";
            this.entradaApellidoDocente.Size = new System.Drawing.Size(100, 20);
            this.entradaApellidoDocente.TabIndex = 2;
            // 
            // entradaNombreDocente
            // 
            this.entradaNombreDocente.Location = new System.Drawing.Point(136, 48);
            this.entradaNombreDocente.Name = "entradaNombreDocente";
            this.entradaNombreDocente.Size = new System.Drawing.Size(100, 20);
            this.entradaNombreDocente.TabIndex = 1;
            // 
            // listaDocentes
            // 
            this.listaDocentes.Location = new System.Drawing.Point(12, 85);
            this.listaDocentes.Name = "listaDocentes";
            this.listaDocentes.Size = new System.Drawing.Size(349, 177);
            this.listaDocentes.TabIndex = 0;
            this.listaDocentes.UseCompatibleStateImageBehavior = false;
            this.listaDocentes.SelectedIndexChanged += new System.EventHandler(this.listaDocentes_SelectedIndexChanged);
            // 
            // botonBajarDocente
            // 
            this.botonBajarDocente.Location = new System.Drawing.Point(561, 109);
            this.botonBajarDocente.Name = "botonBajarDocente";
            this.botonBajarDocente.Size = new System.Drawing.Size(75, 23);
            this.botonBajarDocente.TabIndex = 25;
            this.botonBajarDocente.Text = "Bajar";
            this.botonBajarDocente.UseVisualStyleBackColor = true;
            this.botonBajarDocente.Click += new System.EventHandler(this.botonBajarDocente_Click_1);
            // 
            // botonModificarDocente
            // 
            this.botonModificarDocente.Location = new System.Drawing.Point(561, 138);
            this.botonModificarDocente.Name = "botonModificarDocente";
            this.botonModificarDocente.Size = new System.Drawing.Size(75, 23);
            this.botonModificarDocente.TabIndex = 26;
            this.botonModificarDocente.Text = "Modificar";
            this.botonModificarDocente.UseVisualStyleBackColor = true;
            this.botonModificarDocente.Click += new System.EventHandler(this.botonModificarDocente_Click);
            // 
            // botonAsignarMateriaADocente
            // 
            this.botonAsignarMateriaADocente.Location = new System.Drawing.Point(561, 179);
            this.botonAsignarMateriaADocente.Name = "botonAsignarMateriaADocente";
            this.botonAsignarMateriaADocente.Size = new System.Drawing.Size(75, 23);
            this.botonAsignarMateriaADocente.TabIndex = 27;
            this.botonAsignarMateriaADocente.Text = "Asignar";
            this.botonAsignarMateriaADocente.UseVisualStyleBackColor = true;
            this.botonAsignarMateriaADocente.Click += new System.EventHandler(this.botonAsignarMateriaADocente_Click);
            // 
            // GestionDocenteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(648, 305);
            this.Controls.Add(this.botonAsignarMateriaADocente);
            this.Controls.Add(this.botonModificarDocente);
            this.Controls.Add(this.botonBajarDocente);
            this.Controls.Add(this.panelVentanaDocente);
            this.Controls.Add(this.tituloMantenimientosDocentes);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonAltaDocente);
            this.Name = "GestionDocenteUI";
            this.Text = "GestionDocenteUI";
            this.Load += new System.EventHandler(this.GestionDocenteUI_Load);
            this.panelVentanaDocente.ResumeLayout(false);
            this.panelVentanaDocente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloMantenimientosDocentes;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonAltaDocente;
        private System.Windows.Forms.Panel panelVentanaDocente;
        private System.Windows.Forms.ListView listaDocentes;
        private System.Windows.Forms.Label tituloCIDocente;
        private System.Windows.Forms.Label tituloApellidoDocente;
        private System.Windows.Forms.Label tituloNombreDocente;
        private System.Windows.Forms.TextBox entradaCIDocente;
        private System.Windows.Forms.TextBox entradaApellidoDocente;
        private System.Windows.Forms.TextBox entradaNombreDocente;
        private System.Windows.Forms.Button botonBajarDocente;
        private System.Windows.Forms.Button botonModificarDocente;
        private System.Windows.Forms.Button botonAsignarMateriaADocente;
        private System.Windows.Forms.Label tituloListaMaterias;
        private System.Windows.Forms.ListView listaMaterias;
    }
}