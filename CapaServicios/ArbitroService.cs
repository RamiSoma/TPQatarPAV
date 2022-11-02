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
    class ArbitroService
    {
        private IArbitro arbDao = new ArbitroDao();
        public DataTable traerTodos()
        {
            return arbDao.RecuperarTodos();
        }
        public DataTable traerFiltrado(string nombre, string pais)
        {
            return arbDao.traerFiltrado(nombre, pais);
        }
        public void crearArbitro(string nombre, string apellido, string pais, string tipoDoc, string numDoc)
        {
            arbDao.crearArbitro(nombre, apellido, pais, tipoDoc, numDoc);
        }
        public void eliminarArb(string tipoDoc, string nroDoc)
        {
            arbDao.eliminarArb(tipoDoc, nroDoc);
        }
        public DataTable traerEliminados()
        {
            return arbDao.traerEliminado();
        }
        public void restaurarArb(string tipoDoc, string nroDoc)
        {
            arbDao.restaurarArb(tipoDoc, nroDoc);
        }
        public void modificarArbitro(string nombre, string apellido, string pais, string tipoDoc, string numDoc)
        {
            arbDao.modificarArbitro(nombre, apellido, pais,tipoDoc,numDoc);
        }
        public DataTable filtrarPorCantEventos(bool tarjAmarilla, bool ascendente)
        {
            return arbDao.filtrarPorCantEventos(tarjAmarilla, ascendente);
        }
    }
}
