using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    internal class JugadorDao : IJugador
    {
        public DataTable RecuperarTodos(string fpais)
        {
            string consulta = "select * from jugadores where borrado = 0 and pais like '%" + fpais + "%'";

            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void eliminarJugador(string tipo_doc, string nro_doc)
        {
            string consulta = "Update jugadores set borrado = 1 where tipo_doc= '" + tipo_doc + "' and nro_doc = " + nro_doc;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public bool validar(string tipo_doc, string nro_doc)
        {
            string consulta = "SELECT * FROM jugadores WHERE tipo_doc='"
                                 + tipo_doc + "' AND nro_doc='"
                                 + nro_doc + "'";
            if (DBHelper.obtenerInstancia().consultar(consulta).Rows.Count == 0)
                return false;
            else
                return true;
        }
        public void crearJugador(string tipo_doc, string nro_doc, string nombre, string apellido,string pais)
        { 
            string consulta = "insert into jugadores values('" + tipo_doc +"'," + nro_doc + ",'" + nombre + "','" + apellido + "','"+pais+"',0,0,0,0,0)";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void modificarJugador(string tipo_doc,string nro_doc,string nombre,string apellido,string pais)
        {
            string consulta = "UPDATE jugadores SET nombre = '" + nombre + "', apellido = '" + apellido+"', pais = '"+pais+"'  where tipo_doc = '" + tipo_doc + "' and nro_doc = "+nro_doc;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable traerEliminados()
        {
            string consulta = "select * from jugadores where borrado = 1";

            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void recuperarJugador(string tipoDoc, string nroDoc)
        {
            string consulta = "Update jugadores set borrado = 0 where tipo_doc = '" + tipoDoc + "' and nro_doc = "+ nroDoc;
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable traerJugadoresPais(string pais)
        {
            string consulta = "select nombre + ' ' + apellido , tipo_doc +'-'+ cast(nro_doc as varchar) from jugadores where borrado = 0 and pais like '%" + pais + "%'";

            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }

}
