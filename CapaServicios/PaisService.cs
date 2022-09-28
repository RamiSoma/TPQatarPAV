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
    internal class PaisService
    {
        private IPais paisDao = new PaisDao();

        public DataTable traerTodos(string fNombre, string fContinente)
        {
            return paisDao.RecuperarTodos(fNombre, fContinente);
        }
        public void crearPais(string nNombre, string nRanking, string nContinente, string nGrupo)
        {
            paisDao.crearPais(nNombre, nRanking, nContinente, nGrupo);
        }
        public void eliminarUsr(string pais)
        {
            paisDao.eliminarPais(pais);
        }
        public void modificarPais(string nombre, string continente, string ranking, string grupo)
        {
            paisDao.modificarPais(nombre, continente, ranking, grupo);
        }
        public bool validar(string nombre, string ranking)
        {
            return paisDao.validar(nombre, ranking);
        }
    }
}
