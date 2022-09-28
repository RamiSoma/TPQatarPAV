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
    internal class ContinenteService
    {
        private IContinente dao;
        public ContinenteService()
        {
            dao = new ContinenteDao();
        }
        public DataTable traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
