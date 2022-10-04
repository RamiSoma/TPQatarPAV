using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Datos.Interfaces
{
    interface IArbitro
    {
        DataTable RecuperarTodos(string fnombre);
        DataTable RecuperarTodos(string fNombre, string fApellido);
        DataTable RecuperarTodos();
    }
}
