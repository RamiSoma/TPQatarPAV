using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    internal class PartidoDao : IPartido
    {
        public void crearPartido(string paisLocal, string paisVisitante, string ronda, string grupo, string estadio, string arbitro)
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

            string consulta = "insert into partido values('" + paisLocal + "',Null,'" + paisVisitante + "',Null,'"
                + Convert.ToString(doc_arb.Rows[0]["tipo_doc"]) + "'," + ((int)doc_arb.Rows[0]["nro_doc"]) + ",sysdatetime(),'" + nroRonda + "'," + grupo + ",null,'" + nomEstadio + "', 0)";
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
            string consulta = "select p.id, p.ronda, p.pais_1, p.pais_2, a.nombre +' '+a.apellido nombreArbitro, p.estadio, p.grupo " +
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
            string consulta = "Update partido set borrado = 0 where id = '" + id + "'";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void modificarPartido(string id, string paisLocal, string paisVisita, string ronda, string grupo, string estadio, string arbitro)
        {
            DataTable doc_arb = obtenerDocArb(arbitro);
            string consulta = "UPDATE partido " +
                "set pais_1 = '" + paisLocal + "'," +
                " pais_2 = '" + paisVisita + "'," +
                "ronda=" + (obtenerRonda(ronda)) + "," +
                "grupo='" + grupo + "'," +
                "estadio='" + (obtenerEstadio(estadio)) + "'," +
                "tipo_doc_arb='" + Convert.ToString(doc_arb.Rows[0]["tipo_doc"]) + "'," +
                "nro_doc_arb=" + ((int)doc_arb.Rows[0]["nro_doc"]) +
                " where id=" + id;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}