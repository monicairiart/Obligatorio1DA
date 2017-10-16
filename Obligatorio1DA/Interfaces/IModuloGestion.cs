using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces
{
    public interface IModuloGestion
    {
        string Nombre { get; set; }
        string Descripcion { get; set; }
        object Menu { get; set; }
        IList Acciones { get; set; }

    }
}
