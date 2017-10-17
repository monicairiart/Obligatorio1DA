﻿using Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionUI
{
    public class Dominio : IModuloGestion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public object Menu { get; set; }
        public IList Acciones { get; set; }
        public IContenedorModulo Contenedor { get; set; }
        public Dominio()
        {
            Nombre = "Dominio";
        }
        public void Mostrar()
        {
            FormularioPrincipal formularioPrincipal = new FormularioPrincipal();
            formularioPrincipal.ShowDialog();
        }
    }
}