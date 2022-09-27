using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    class UsuarioDao : IUsuario
    {
        public int validarUsr(string nombre,string pswd)
        {
            string consulta = "SELECT * FROM Usuario WHERE (usuario='" + nombre + "' OR mail = '"+ nombre +"') AND contraseña='" + pswd + "'";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }
        public DataTable RecuperarTodos(string fNombreMail, string fPerfil)
        {
            string consulta = "select u.id,u.nombre,u.apellido,u.mail,u.usuario,p.rol,u.contraseña from usuario u, perfil p " +
                                     "where (p.id = u.rol_id) and u.borrado = 0 and (u.nombre like '%"+fNombreMail+"%' or u.apellido like '%" + fNombreMail + "%' or u.mail like '%"+fNombreMail+"%') and u.rol_id='"+obtenerRolPerfilId(fPerfil)+"'";

            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void crearUsr(string nNombre, string nApellido, string nMail, string nUsuario, string nPswd, string nRolPerfil)
        {
            int idRol = obtenerRolPerfilId(nRolPerfil);
            string consulta = "insert into usuario values('"+nNombre+ "','" + nApellido + "','" + nUsuario + "','" + nMail + "','" + nPswd + "',"+ idRol +",0)";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        private int obtenerRolPerfilId(string rol)
        {
            string consulta = "select id from perfil where rol='" + rol + "'";
            return (int)DBHelper.obtenerInstancia().consultar(consulta).Rows[0][0];
        }
        public void modificarUsr(string id, string nNombre, string nApellido, string nUsuario, string nPswd, string nRolPerfil)
        {
            string consulta = "UPDATE usuario SET nombre = '"+nNombre+"', apellido = '" + nApellido + "', usuario = '" + nUsuario + "', contraseña = '"+nPswd+"',rol_id = "+ obtenerRolPerfilId(nRolPerfil) +" WHERE id = "+id;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void eliminarUsr(int id)
        {
            string consulta = "Update usuario set borrado = 1 where id =" + id;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
