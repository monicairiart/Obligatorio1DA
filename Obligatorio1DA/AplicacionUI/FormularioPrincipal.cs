using System;
using System.Windows.Forms;

namespace AplicacionUI
{
    internal class FormularioPrincipal : Form
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new FormularioPrincipal());
        }
    }
}