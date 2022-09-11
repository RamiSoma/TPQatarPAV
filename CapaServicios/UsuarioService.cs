using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Daos;
using TPQatarPAVI.Datos.Interfaces;
using TPQatarPAVI.LogicaNegocio;
using System.Data;
using System.Windows.Forms;

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
        public DataTable traerTodos()
        {
            return usrDao.RecuperarTodos();
        }
        public void crearUsr(string nombre, string pswd, string rolPerfil)
        {
            usrDao.crearUsr(nombre, pswd, rolPerfil);
        }
        public void modificarUsr(string id, string nNombre, string nPswd, string nRolPerfil)
        {
            usrDao.modificarUsr(id, nNombre, nPswd, nRolPerfil);
        }
        public void eliminarUsr(int id)
        {
            usrDao.eliminarUsr(id);
        }
    }
}
