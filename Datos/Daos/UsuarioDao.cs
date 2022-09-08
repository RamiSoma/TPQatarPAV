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
    }
}
