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
        DataTable RecuperarTodos(string fNombreMail, string fPerfil);
        void crearUsr(string nNombre, string nApellido, string nMail, string nUsuario, string nPswd, string nRolPerfil);
        void modificarUsr(string id, string nNombre, string nApellido, string nUsuario, string nPswd, string nRolPerfil);
        void eliminarUsr(int id);
    }
}
