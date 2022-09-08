using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Daos;
using TPQatarPAVI.Datos.Interfaces;
using TPQatarPAVI.LogicaNegocio;

namespace TPQatarPAVI.CapaServicios
{
    internal class UsuarioService
    {
        private IUsuario usrDao = new UsuarioDao();
        public int encontrarUsuario(Usuario usr)
        {
            string nombre = usr.nombreUsu;
            string pswd = usr.pswdUsu;
            return usrDao.validarUsr(nombre,pswd);
        }
    }
}
