using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    internal class ArbitroDao : IArbitro
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "select nombre + ' ' + apellido from arbitro WHERE borrado = 0";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }

    }
}
