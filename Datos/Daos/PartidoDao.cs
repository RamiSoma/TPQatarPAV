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
    internal class PartidoDao : IPartido
    {
        public void crearPartido(string paisLocal, string paisVisitante, string ronda, string grupo, string estadio, string arbitro, string fecha)
        {
            DataTable doc_arb = obtenerDocArb(arbitro);
            string nomEstadio = obtenerEstadio(estadio);
            int nroRonda = obtenerRonda(ronda);
            if (nroRonda != 1)
            {
                grupo = "Null";
            }
            else
            {
                grupo = "'" + grupo + "'";
            }

            string consulta = "insert into partido values('" + paisLocal + "',0,'" + paisVisitante + "',0,'"
                + Convert.ToString(doc_arb.Rows[0]["tipo_doc"]) + "'," + ((int)doc_arb.Rows[0]["nro_doc"]) + ",'"+fecha+"','" + nroRonda + "'," + grupo + ",null,'" + nomEstadio + "', 0)";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        private DataTable obtenerDocArb(string arbitro)
        {
            string consulta = "select tipo_doc, nro_doc from Arbitro where borrado = 0 and nombre +' '+apellido = '" + arbitro + "'";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        private string obtenerEstadio(string estadio)
        {
            string consulta = "select nombre from estadio where borrado = 0 and nombre + ' - ' + nombre_ciudad = '" + estadio + "'";
            return DBHelper.obtenerInstancia().consultar(consulta).Rows[0][0].ToString();
        }
        private int obtenerRonda(string ronda)
        {
            string consulta = "select id from ronda where borrado = 0 and descripcion = '" + ronda + "'";
            return (int)DBHelper.obtenerInstancia().consultar(consulta).Rows[0][0];
        }
        public DataTable buscarPartidos(string ronda, string grupo, string estadio, string pais)
        {
            string consulta = "select p.id, p.ronda, p.pais_1, p.pais_2, p.fecha, a.nombre +' '+a.apellido nombreArbitro, p.estadio, p.grupo, p.ganador " +
                "from partido p join arbitro a on (p.tipo_doc_arb = a.tipo_doc and p.nro_doc_arb = a.nro_doc) " +
                "where p.borrado = 0 and " +
                "p.ronda = " + obtenerRonda(ronda);
            if (ronda == "Fase de Grupo" && grupo != "Todos")
            {
                consulta = consulta + " and p.grupo = '" + grupo + "'";
            }
            if (estadio != "Todos")
            {
                consulta = consulta + "and p.estadio = '" + obtenerEstadio(estadio) + "'";
            }
            if (pais != "Todos")
            {
                consulta = consulta + "and (p.pais_1 = '" + pais + "' or p.pais_2 = '" + pais + "')";
            }


            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void eliminarPartido(string idPart)
        {
            string consulta = "Update partido set borrado = 1 where id = '" + idPart + "'";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable recuperarEliminados()
        {
            string consulta = "select p.id, p.ronda, p.pais_1, p.pais_2, a.nombre +' '+a.apellido nombreArbitro, p.estadio, p.grupo " +
                "from partido p join arbitro a on (p.tipo_doc_arb = a.tipo_doc and p.nro_doc_arb = a.nro_doc) " +
                "where p.borrado = 1";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void recuperarPartido(string id)
        {
            string consulta = "Update partido set borrado = 0 where id = " + id;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void modificarPartido(string id, string paisLocal, string paisVisita, string ronda, string grupo, string estadio, string arbitro, string fecha)
        {
            DataTable doc_arb = obtenerDocArb(arbitro);
            string consulta = "UPDATE partido " +
                "set pais_1 = '" + paisLocal + "'," +
                " pais_2 = '" + paisVisita + "'," +
                "ronda=" + (obtenerRonda(ronda)) + "," +
                "grupo='" + grupo + "'," +
                "fecha='"+fecha+"'," +
                "estadio='" + (obtenerEstadio(estadio)) + "'," +
                "tipo_doc_arb='" + Convert.ToString(doc_arb.Rows[0]["tipo_doc"]) + "'," +
                "nro_doc_arb=" + ((int)doc_arb.Rows[0]["nro_doc"]) +
                " where id=" + id;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable obtenerPartidoId(string id)
        {
            string consulta = "select pais_1,pais_2,tipo_doc_arb,nro_doc_arb,nombre + ' ' + apellido nombreArbitro,fecha,ronda,grupo,estadio, goles_p1,goles_p2 from partido join arbitro on (tipo_doc_arb = tipo_doc and nro_doc_arb = nro_doc) where partido.borrado = 0 and id = " + id ;
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public string modificarGol(Evento evento, string operacion)
        {
            string consulta;
            string paisLocal = obtenerPaisLocal(evento.IdPartido);
            string paisJugador = obtenerPaisJugador(evento);
            if (paisLocal == paisJugador)
            {
                consulta = "update partido set goles_p1 = goles_p1 "+operacion+" 1 where id = " + evento.IdPartido;
            }
            else
            {
                consulta = "update partido set goles_p2 = goles_p2 " + operacion + " 1 where id = " + evento.IdPartido;
            }

            return consulta;
        }
        private string obtenerPaisLocal(int idPartido)
        {
            string consulta = "select pais_1 from partido where id = " + idPartido;
            DataTable pais = DBHelper.obtenerInstancia().consultar(consulta);
            return pais.Rows[0]["pais_1"].ToString();
        }
        private string obtenerPaisJugador(Evento evento)
        {
            string consulta = "select pais from jugadores where tipo_doc = '"+evento.TipoDocJug+"' and nro_doc = "+evento.NroDocJug;
            DataTable pais = DBHelper.obtenerInstancia().consultar(consulta);
            return pais.Rows[0]["pais"].ToString();
        }
        public void finalizarPartido(string id, string ganador)
        {
            string consulta = "update Partido set ganador='"+ganador+"' where id = "+id;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable chequearFinPartido(string id)
        {
            string consulta = "select ganador from partido where id = " + id;
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}