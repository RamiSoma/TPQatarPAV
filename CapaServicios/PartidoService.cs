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
    internal class PartidoService
    {
        private IPartido partDao = new PartidoDao();
        public void crearPartido(string paisLocal, string paisVisitante, string ronda, string grupo, string estadio, string arbitro)
        {
            partDao.crearPartido(paisLocal,paisVisitante,ronda,grupo,estadio, arbitro);    
        }
        public DataTable buscarPartidos(string ronda, string grupo, string estadio, string pais)
        {
            return partDao.buscarPartidos(ronda, grupo, estadio, pais);
        }
        public void eliminarPartido(string idPart)
        {
            partDao.eliminarPartido(idPart);
        }
        public DataTable traerEliminados()
        {
            return partDao.recuperarEliminados();
        }
        public void recuperarPartido(string idPartido)
        {
            partDao.recuperarPartido(idPartido);
        }
        public void modificarPartido(string id,string paisLocal, string paisVisita, string ronda, string grupo, string estadio, string arbitro)
        {
            partDao.modificarPartido(id,paisLocal, paisVisita, ronda, grupo, estadio, arbitro);
        }
    }
}
