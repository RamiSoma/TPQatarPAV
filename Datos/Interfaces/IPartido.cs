using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Datos.Interfaces
{
    internal interface IPartido
    {
        void crearPartido(string paisLocal, string paisVisitante, string ronda, string grupo, string estadio, string arbitro);
        DataTable buscarPartidos(string ronda, string grupo, string estadio, string pais);
        void eliminarPartido(string idPart);
        DataTable recuperarEliminados();
        void recuperarPartido(string idPartido);
        void modificarPartido(string id, string paisLocal, string paisVisita, string ronda, string grupo, string estadio, string arbitro);
    }
}
