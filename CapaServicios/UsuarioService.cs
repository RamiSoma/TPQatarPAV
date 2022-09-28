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
        public DataTable traerTodos(string fNombreMail, string fPerfil)
        {
            return usrDao.RecuperarTodos(fNombreMail, fPerfil);
        }
        public void crearUsr(string nNombre, string nApellido,string nMail, string nUsuario, string nPswd, string nRolPerfil)
        {
            usrDao.crearUsr(nNombre, nApellido, nMail, nUsuario, nPswd, nRolPerfil);
        }
        public void modificarUsr(string id, string nNombre, string nApellido, string nUsuario, string nPswd, string nRolPerfil)
        {
            usrDao.modificarUsr(id, nNombre, nApellido, nUsuario, nPswd, nRolPerfil);
        }
        public void eliminarUsr(int id)
        {
            usrDao.eliminarUsr(id);
        }
        public bool validar(string mail)
        {
            return usrDao.validar(mail);
        }
        public DataTable traerEliminados()
        {
            return usrDao.recuperarEliminados();            
        }
        public void recuperarUsr(string id)
        {
            usrDao.recuperarUsr(id);
        }
    }
}
