using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    internal class PaisDao : IPais
    {
        public DataTable RecuperarTodos(string fNombre, string fContinente)
        {
            int idContinente;
            if (fContinente == "")
            {
                idContinente = 1;
            }
            else
            {
                idContinente = obtenerNombreContId(fContinente);
            }
            string consulta = "select p.nombre, c.nombre continente, p.ranking_fifa, p.id_grupo from pais p join continente c on (p.id_continente = c.id) where p.borrado = 0 and p.nombre like '%"+fNombre+"%' and p.id_continente = "+idContinente;

            return DBHelper.obtenerInstancia().consultar(consulta);
        }

        private int obtenerNombreContId(string fContinente)
        {
            string consulta = "select id from continente where nombre='" + fContinente + "'";
            return (int)DBHelper.obtenerInstancia().consultar(consulta).Rows[0][0];
        }
        public void crearPais(string nNombre, string nRanking, string nContinente, string nGrupo)
        {
            int continenteId = obtenerNombreContId(nContinente);
            string consulta = "insert into pais values('" + nNombre + "','" + continenteId + "','" + nGrupo + "',0,'" + nRanking + "',0)";
            DBHelper.obtenerInstancia().consultar(consulta);
        }

        public void eliminarPais(string id)
        {
            string consulta = "Update pais set borrado = 1 where nombre = '" + id +"'";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void modificarPais(string nombre, string continente, string ranking, string grupo)
        {
            string consulta = "UPDATE pais SET id_continente = '" + obtenerNombreContId(continente) + "', ranking_fifa = " + ranking + ", id_grupo = '" + grupo + "' where nombre = '"+nombre+"'";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
        public bool validar(string nombre, string ranking)
        {
            string consulta = "SELECT * FROM Pais WHERE nombre='"
                                 + nombre + "' AND ranking_fifa='"
                                 + ranking + "'";
            if (DBHelper.obtenerInstancia().consultar(consulta).Rows.Count == 0)
                return false;
            else
                return true;
        }
        public DataTable recuperarEliminados()
        {
            string consulta = "select p.nombre, c.nombre continente, p.ranking_fifa, p.id_grupo from pais p join continente c on (p.id_continente = c.id) where p.borrado = 1";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
        public void recuperarPais(string nombre)
        {
            string consulta = "Update pais set borrado = 0 where nombre = '" + nombre+"'";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
