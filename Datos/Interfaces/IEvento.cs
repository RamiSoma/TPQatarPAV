using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Datos.Interfaces
{
    internal interface IEvento
    {
        void crearEvento(string id, string min, string jug, string evento);
        DataTable traerEventosPorId(string id, string pais);
        void eliminarEvento(string id);
    }
}
