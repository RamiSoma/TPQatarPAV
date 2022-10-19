using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Entidades;

namespace TPQatarPAVI.Datos.Interfaces
{
    internal interface IEvento
    {
        bool crearEvento(Evento evento);
        DataTable traerEventosPorId(string id, string pais);
        void eliminarEvento(Evento evento, string pais);
        DataTable traerEventosPorIdEvento(string id);
    }
}
