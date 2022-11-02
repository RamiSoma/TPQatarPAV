using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Datos.Interfaces
{
    interface IArbitro
    {
        DataTable RecuperarTodos();
        DataTable traerFiltrado(string nombre, string pais);
        void crearArbitro(string Nombre, string Apellido, string Pais, string tipoDoc, string numDoc);
        void eliminarArb(string tipoDoc, string nroDoc);
        DataTable traerEliminado();
        void restaurarArb(string tipoDoc, string nroDoc);
        void modificarArbitro(string nombre, string apellido, string pais, string tipoDoc, string numDoc);
        DataTable filtrarPorCantEventos(bool tarjAmarilla, bool ascendente);
        }
}
