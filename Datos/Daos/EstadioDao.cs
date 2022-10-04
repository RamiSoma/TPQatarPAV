using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    internal class EstadioDao : IEstadio
    {
        public DataTable traerTodos()
        {
            string consulta = "select nombre + ' - ' + nombre_ciudad from Estadio WHERE borrado = 0";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
