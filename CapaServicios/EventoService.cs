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
        JugadorService jug = new JugadorService();
        PartidoService part = new PartidoService();

        public void crearEvento(string id, string min, string jug, string evento)
        {
            string jugador = "'" + jug.Replace("-", "',");
            eventoDao.crearEvento(id, min, jugador, evento);
        }
        public DataTable traerEventosPorId(string id, string pais)
        {
            return eventoDao.traerEventosPorId(id, pais);
        }
        public void eliminarEvento(string idEvento, string idPartido, string jugador,string pais, string check)
        {
            DataTable evento = eventoDao.traerEventosPorIdEvento(idEvento);
            string tipoEvento = Convert.ToString(evento.Rows[0]["evento"]);
            jug.anotar(jugador, tipoEvento, "borrar");
            if (tipoEvento == "Gol")
            {
                part.modificarGol(idPartido, pais, check, "borrar");
            }
            eventoDao.eliminarEvento(idEvento);
        }
    }
}
