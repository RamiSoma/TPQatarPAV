using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPQatarPAVI.Entidades;

namespace TPQatarPAVI.Datos.Interfaces
{
    internal interface IPartido
    {
        void crearPartido(string paisLocal, string paisVisitante, string ronda, string grupo, string estadio, string arbitro, string fecha);
        DataTable buscarPartidos(string ronda, string grupo, string estadio, string pais);
        void eliminarPartido(string idPart);
        DataTable recuperarEliminados();
        void recuperarPartido(string idPartido);
        void modificarPartido(string id, string paisLocal, string paisVisita, string ronda, string grupo, string estadio, string arbitro, string fecha);
        DataTable obtenerPartidoId(string id);
        string modificarGol(Evento evento, string operacion);
        void finalizarPartido(string id, string ganador);
        DataTable chequearFinPartido(string id);
    }
}
