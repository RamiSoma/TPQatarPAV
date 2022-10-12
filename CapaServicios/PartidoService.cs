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
            if (fecha[2] != '/')
            {
                fecha = '0' + fecha;
            }
            string mes = fecha.Substring(3, 2);
            string dia = fecha.Substring(0, 2);
            string anio = fecha.Substring(6, 4);
            string nFecha = mes + "/" + dia + "/" + anio;
            return nFecha;
        }
        public void crearPartido(string paisLocal, string paisVisitante, string ronda, string grupo, string estadio, string arbitro, string fecha)
        {
            string nFecha = transformarFecha(fecha);
            partDao.crearPartido(paisLocal, paisVisitante, ronda, grupo, estadio, arbitro, nFecha);
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
        public void modificarPartido(string id, string paisLocal, string paisVisita, string ronda, string grupo, string estadio, string arbitro, string fecha)
        {
            string nFecha = transformarFecha(fecha);
            partDao.modificarPartido(id, paisLocal, paisVisita, ronda, grupo, estadio, arbitro, nFecha);
        }
        public DataTable obtenerPartidoId(string id)
        {
            return partDao.obtenerPartidoId(id);
        }
        public void modificarGol(string idPartido, string pais, string check, string accion)
        {
            string nAccion = "+";
            if (accion == "borrar")
            {
                nAccion = "-";
            }
            partDao.modificarGol(idPartido, pais, check, nAccion);
        }
        public void finalizarPartido(string id, string paisLocal, string golesLocal, string paisVisita, string golesVisita)
        {
            string ganador="";
            if (Int32.Parse(golesLocal) > Int32.Parse(golesVisita))
            {
                ganador = paisLocal;
            }
            if (Int32.Parse(golesLocal) < Int32.Parse(golesVisita))
            {
                ganador = paisVisita;
            }
            if (Int32.Parse(golesLocal) == Int32.Parse(golesVisita))
            {
                ganador = "EMPATE";
            }
            partDao.finalizarPartido(id, ganador);
        }
        public bool chequearFinPartido(string id)
        {
            DataTable partido = partDao.chequearFinPartido(id);
            string finalizoString = Convert.ToString(partido.Rows[0]["ganador"]);
            bool finalizo = true;
            if(finalizoString  == "")
            {
                finalizo = false;
            }
            return finalizo;
        }
    }
}
