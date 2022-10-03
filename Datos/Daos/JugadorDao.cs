using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    internal class JugadorDao : IJugador
    {
        public DataTable RecuperarTodos(string fpais)
        {
            string consulta = "select * from jugadores where borrado = 0 and pais like '%"+ fpais+ "%'";

            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
