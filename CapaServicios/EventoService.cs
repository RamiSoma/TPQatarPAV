using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Daos;
using TPQatarPAVI.Datos.Interfaces;
using TPQatarPAVI.Entidades;

namespace TPQatarPAVI.CapaServicios
{
    internal class EventoService
    {
        private IEvento eventoDao = new EventoDao();
        JugadorService jug = new JugadorService();
        PartidoService part = new PartidoService();

        public bool crearEvento(Evento evento)
        {
            return eventoDao.crearEvento(evento);
        }
        public DataTable traerEventosPorId(string id, string pais)
        {
            return eventoDao.traerEventosPorId(id, pais);
        }
        public void eliminarEvento(string idEvento)
        {
            DataTable evento = eventoDao.traerEventosPorIdEvento(idEvento);
            Evento eventoEliminar = new Evento();
            eventoEliminar.IdEvento = Convert.ToInt32(idEvento);
            eventoEliminar.IdPartido = Convert.ToInt32(evento.Rows[0]["id_partido"]);
            eventoEliminar.TipoEvento = Convert.ToString(evento.Rows[0]["evento"]);
            eventoEliminar.TipoDocJug = Convert.ToString(evento.Rows[0]["Tipo_doc_jg"]);
            eventoEliminar.NroDocJug = Convert.ToInt32(evento.Rows[0]["nro_doc_jg"]);

            string pais = Convert.ToString(evento.Rows[0]["pais"]);

            eventoDao.eliminarEvento(eventoEliminar, pais);
        }
    }
}
