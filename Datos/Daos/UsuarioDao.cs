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
            string consulta = "SELECT * FROM Usuario WHERE nombre='" + nombre + "' AND contraseña='" + pswd + "'";

            DataTable tabla = DBHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "select u.id,u.nombre,u.contraseña,p.rol from usuario u, perfil p where (p.id = u.rol_id)";

            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void crearUsr(string nombre, string pswd, string rolPerfil)
        {
            int idRol = obtenerRolPerfilId(rolPerfil);
            string consulta = "insert into usuario values('"+nombre+"','"+pswd+"',"+idRol+",0)";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        private int obtenerRolPerfilId(string rol)
        {
            string consulta = "select id from perfil where rol='" + rol + "'";
            return (int)DBHelper.obtenerInstancia().consultar(consulta).Rows[0][0];
        }
        public void modificarUsr(string id, string nNombre, string nPswd, string nRolPerfil)
        {
            string consulta = "UPDATE usuario SET nombre = '"+nNombre+"', contraseña = '"+nPswd+"',rol_id = "+ obtenerRolPerfilId(nRolPerfil) +" WHERE id = "+id;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void eliminarUsr(int id)
        {
            string consulta = "delete from Usuario where id =" + id;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
