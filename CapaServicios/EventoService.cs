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
        public void eliminarEvento(string idEvento)
        {
            DataTable evento = eventoDao.traerEventosPorIdEvento(idEvento);
            string tipoEvento = Convert.ToString(evento.Rows[0]["evento"]);
            string jugador = Convert.ToString(evento.Rows[0]["Tipo_doc_jg"]) + "-" + Convert.ToString(evento.Rows[0]["nro_doc_jg"]);
            string idPartido = Convert.ToString(evento.Rows[0]["id_partido"]);
            string pais = Convert.ToString(evento.Rows[0]["pais"]);
            
            jug.anotar(jugador, tipoEvento, "borrar");
            if (tipoEvento == "Gol")
            {
                part.modificarGol(idPartido, pais,"borrar");
            }
            eventoDao.eliminarEvento(idEvento);
        }
    }
}
