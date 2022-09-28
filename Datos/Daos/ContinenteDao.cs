using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    internal class ContinenteDao : IContinente
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM continente WHERE borrado = 0 order by 2";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
