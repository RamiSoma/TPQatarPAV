using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    internal class EventoDao : IEvento
    {
        public void crearEvento(string id, string min, string jug, string evento)
        {
            string consulta = "insert into eventopartido values("+id+","+min+","+jug+",'"+evento+"', 0)";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable traerEventosPorId(string id, string pais)
        {
            string consulta = "select e.minuto,e.nro_doc_jg,j.nombre + ' ' + j.apellido nombreCompleto ,e.evento, e.id_evento " +
                                    "from EventoPartido e join jugadores j on(j.tipo_doc = e.tipo_doc_jg and j.nro_doc = e.nro_doc_jg) " +
                                    "join partido p on (e.id_partido = p.id)" +
                                    " where e.id_partido = " + id + "and e.borrado = 0 and j.pais like '%"+pais+"%'";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void eliminarEvento(string id)
        {
            string consulta = "Update eventoPartido set borrado = 1 where id_evento = '" + id + "'";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable traerEventosPorIdEvento(string id)
        {
            string consulta = "select * from eventoPartido where id_evento = " + id;
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
