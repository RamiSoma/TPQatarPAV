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
    internal class EventoService
    {
        private IEvento eventoDao = new EventoDao();

        public void crearEvento(string id, string min, string jug, string evento)
        {
            string jugador = "'" + jug.Replace("-", "',");
            eventoDao.crearEvento(id, min, jugador, evento);
        }
        public DataTable traerEventosPorId(string id, string pais)
        {
            return eventoDao.traerEventosPorId(id, pais);
        }
        public void eliminarEvento(string id)
        {
            eventoDao.eliminarEvento(id);
        }
    }
}
