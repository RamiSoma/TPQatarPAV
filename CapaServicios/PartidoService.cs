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
        private string transformarFecha(string fecha)
        {
            string mes = fecha.Substring(3, 2);
            string dia = fecha.Substring(0, 2);
            string anio = fecha.Substring(6, 4);
            string nFecha = mes + "/" + dia + "/" + anio;
            return nFecha;
        }
        public void crearPartido(string paisLocal, string paisVisitante, string ronda, string grupo, string estadio, string arbitro, string fecha)
        {
            if (fecha[2] != '/'){
                fecha = '0' + fecha;
            }
            string nFecha = transformarFecha(fecha);
            partDao.crearPartido(paisLocal,paisVisitante,ronda,grupo,estadio, arbitro, nFecha);    
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
        public void modificarPartido(string id,string paisLocal, string paisVisita, string ronda, string grupo, string estadio, string arbitro, string fecha)
        {
            string nFecha = transformarFecha(fecha);
            partDao.modificarPartido(id,paisLocal, paisVisita, ronda, grupo, estadio, arbitro, nFecha);
        }
    }
}
