using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Datos.Interfaces
{
    internal interface IEstadio
    {
        DataTable traerTodos();
        DataTable traerPartidoPorEstadio(bool asc);
    }
}
