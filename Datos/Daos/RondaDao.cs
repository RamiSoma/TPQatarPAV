using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    internal class RondaDao : IRonda
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT descripcion FROM Ronda WHERE borrado = 0";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
