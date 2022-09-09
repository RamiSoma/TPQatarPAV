using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TPQatarPAVI.Datos.Interfaces
{
    internal interface IUsuario
    {
        int validarUsr(string nombreUsu, string pswdUsu);
        DataTable RecuperarTodos();
    }
}
