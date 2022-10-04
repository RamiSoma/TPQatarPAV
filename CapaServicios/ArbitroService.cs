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
    internal class ArbitroService
    {
        private IArbitro dao;
        public ArbitroService()
        {
            dao = new ArbitroDao();
        }
        public DataTable traerTodos()
        {
            return dao.traerTodos();
        }
    }
}
