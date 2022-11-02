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
    internal class EstadioService
    {
        private IEstadio dao;
        public EstadioService()
        {
            dao = new EstadioDao();
        }
        public DataTable traerTodos()
        {
            return dao.traerTodos();
        }
        public DataTable traerPartidosPorEstadio(bool asc)
        {
            return dao.traerPartidoPorEstadio(asc);
        }
    }
}
