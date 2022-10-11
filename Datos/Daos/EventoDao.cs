using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Datos.Interfaces;

namespace TPQatarPAVI.Datos.Daos
{
    internal class EventoDao : IEvento
    {
        public void crearEvento(string id, string min, string jug, string evento)
        {
            string consulta = "insert into eventopartido values("+id+","+min+","+jug+",'"+evento+"', 0)";
            DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
