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
    
    internal class JugadorService
    {
        private IJugador jugadorDao = new JugadorDao();

        public DataTable traerTodos(string fpais)
        {
            return jugadorDao.RecuperarTodos(fpais);
        }
        public void eliminarjugador(string tipo_doc,string nro_doc)
        {
            jugadorDao.eliminarJugador(tipo_doc, nro_doc);
        }
        public void crearJugador(string tipo_doc, string nro_doc, string nombre, string apellido, string pais) { 
            jugadorDao.crearJugador(tipo_doc, nro_doc, nombre, apellido,pais);
        }
        public void modificarJugador(string tipo_doc, string nro_doc, string nombre, string apellido, string pais)
        {
            jugadorDao.modificarJugador(tipo_doc, nro_doc, nombre, apellido, pais);
        }
        public bool validar(string tipo_doc, string nro_doc)
        {
            return jugadorDao.validar(tipo_doc, nro_doc);
        }
        public DataTable traerEliminados()
        {
            return jugadorDao.traerEliminados();
        }
        public void recuperarJugador(string tipoDoc, string nroDoc)
        {
            jugadorDao.recuperarJugador(tipoDoc, nroDoc);
        }
        public DataTable traerJugadoresPais(string pais)
        {
            return jugadorDao.traerJugadoresPais(pais);
        }
        public string transformarAEventoBD(string evento)
        {
            string nEvento =evento;
            if (evento == "Gol")
            {
                nEvento = "gol";
            }
            if (evento == "Tarjeta Amarilla")
            {
                nEvento = "tarjetas_amarillas";
            }
            if (evento == "Tarjeta Roja")
            {
                nEvento = "tarjetas_rojas";
            }
            if (evento == "Asistencia")
            {
                nEvento = "asistencias";
            }
            return nEvento;
        }
        public string[] obtenerDoc(string docJugador)
        {
            DataTable dtDocJug = jugadorDao.obtenerDoc(docJugador);
            string[] docJug = new string[2] { dtDocJug.Rows[0]["tipo_doc"].ToString(), dtDocJug.Rows[0]["nro_doc"].ToString() };
            return docJug;
        }
    }
}
