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
        public DataTable traerPartidoPorEstadio(bool asc)
        {
            string orden = "desc";
            if (asc)
            {
                orden = "";
            }
            string consulta = "select p.estadio, count(*)as Partidos from partido p " +
                "where p.borrado = 0 " +
                "group by p.estadio " +
                "order by 2 "+ orden;
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
