using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Daos;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.CapaServicios
{
    
    internal class JugadorService
    {
        private IJugador jugadorDao = new JugadorDao();

        public DataTable traerTodos(string fpais)
        {
            return jugadorDao.RecuperarTodos(fpais);
        }
    }
}
