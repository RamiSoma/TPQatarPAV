using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;
using TPQatarPAVI.Entidades;

namespace TPQatarPAVI.Datos.Daos
{
    internal class EventoDao : IEvento
    {
        public bool crearEvento(Evento evento)
        {
            PartidoDao partDao = new PartidoDao();
            string consultaGol = partDao.modificarGol(evento, "+");
            bool aux;

            string consultaEvento = "insert into eventoPartido (id_partido,minuto, tipo_doc_jg, nro_doc_jg, evento, borrado) " +
                                "values(" + evento.IdPartido + "," + evento.Minuto + "," +
                                "'" + evento.TipoDocJug + "'," + evento.NroDocJug + 
                                ",'" + evento.TipoEvento +
                                "', 0)";
            DBHelper.obtenerInstancia().conectarConTransaccion();
            DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaEvento);

            string consultaJugadores = "update jugadores set " + evento.TipoEvento + " = " 
                                    + evento.TipoEvento + " + 1 where tipo_doc = '"+
                                    evento.TipoDocJug+"' and nro_doc = "+
                                    evento.NroDocJug;
            DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaJugadores);

            if (evento.TipoEvento == "gol")
            {
                DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaGol);
            }

            aux = DBHelper.obtenerInstancia().desconectarSQL();
            return aux;
        }
        public DataTable traerEventosPorId(string id, string pais)
        {
            string consulta = "select e.minuto,e.nro_doc_jg,j.nombre + ' ' + j.apellido nombreCompleto ,e.evento, e.id_evento " +
                                    "from EventoPartido e join jugadores j on(j.tipo_doc = e.tipo_doc_jg and j.nro_doc = e.nro_doc_jg) " +
                                    "join partido p on (e.id_partido = p.id)" +
                                    " where e.id_partido = " + id + "and e.borrado = 0 and j.pais like '%"+pais+"%'";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void eliminarEvento(Evento evento, string pais)
        {
            PartidoDao partDao = new PartidoDao();
            string consultaGol = partDao.modificarGol(evento, "-");

            string consulta = "Update eventoPartido set borrado = 1 " +
                                    "where id_evento = '" + evento.IdEvento.ToString() + "'";
            DBHelper.obtenerInstancia().conectarConTransaccion();
            DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(consulta);

            string consultaJugadores = "update jugadores set " + evento.TipoEvento + " = "
                                   + evento.TipoEvento + " - 1 where tipo_doc = '" +
                                   evento.TipoDocJug + "' and nro_doc = " +
                                   evento.NroDocJug;
            DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaJugadores);

            if (evento.TipoEvento == "gol")
            {
                DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaGol);
            }
            DBHelper.obtenerInstancia().desconectarSQL();
        }
        public DataTable traerEventosPorIdEvento(string id)
        {
            string consulta = "select id_evento,id_partido,minuto,tipo_doc_jg,nro_doc_jg, evento, pais from eventoPartido join jugadores on (tipo_doc_jg=tipo_doc and nro_doc_jg=nro_doc) where id_evento = " + id;
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
