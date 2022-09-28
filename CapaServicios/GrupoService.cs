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
    internal class GrupoService
    {
        private IGrupo dao;
        public GrupoService()
        {
            dao = new GrupoDao();
        }
        public DataTable traerTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
