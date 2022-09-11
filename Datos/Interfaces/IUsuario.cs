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
        void crearUsr(string nombre, string pswd, string rolPerfil);
        void modificarUsr(string id, string nNombre, string nPswd, string nRolPerfil);
        void eliminarUsr(int id);
    }
}
