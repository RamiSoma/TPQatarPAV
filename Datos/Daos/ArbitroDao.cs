using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    internal class ArbitroDao : IArbitro
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "select nombre + ' ' + apellido from arbitro WHERE borrado = 0";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable traerFiltrado(string nombre, string pais)
        {
            string consulta = "select * from arbitro WHERE borrado = 0 AND " +
                                    "(nombre like '%" + nombre + "%' OR apellido like '%" + nombre + "%')";
            if (pais != "Todos")
            {
                consulta = consulta + " and pais = '" + pais + "'";
            }

            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void crearArbitro(string nombre, string apellido, string pais, string tipoDoc, string numDoc)
        {
            string consulta = "insert into arbitro values('" + nombre + "','" + apellido + "','" + tipoDoc + "'," + numDoc + ",'" + pais + "',0)";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void eliminarArb(string tipoDoc, string nroDoc)
        {
            string consulta = "update arbitro set borrado = 1 where tipo_doc = '" + tipoDoc + "' and nro_doc = " + nroDoc;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable traerEliminado()
        {
            string consulta = "select * from arbitro WHERE borrado = 1";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void restaurarArb(string tipoDoc, string nroDoc)
        {
            string consulta = "update arbitro set borrado = 0 where tipo_doc = '" + tipoDoc + "' and nro_doc = " + nroDoc;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void modificarArbitro(string nombre, string apellido, string pais, string tipoDoc, string numDoc)
        {
            string consulta = "update arbitro set nombre = '" + nombre + "',apellido = '" + apellido + "', pais = '" + pais + "' where borrado=0 and tipo_doc = '" + tipoDoc + "' and nro_doc = " + numDoc;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable filtrarPorCantEventos(bool tarjAmarilla, bool ascendente)
        {
            string tarj = "'tarjetas_rojas'";
            if (tarjAmarilla)
            {
                tarj = "'tarjetas_amarillas'";
            }
            string asc = "";
            if (ascendente)
            {
                asc = "desc";
            };
            string consulta = "select ar.nombre,ar.apellido,count(ep.evento) as cantidad from Partido P " +
                "JOIN Arbitro ar on(ar.nro_doc= p.nro_doc_arb and ar.tipo_doc= p.tipo_doc_arb) " +
                "join EventoPartido ep on(ep.id_partido= p.id) " +
                "where ar.borrado = 0 and ep.evento =" + tarj +
                "group by ar.nombre,ar.apellido " +
                "order by ar.nombre " + asc;
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
