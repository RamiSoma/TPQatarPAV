using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Datos.Interfaces
{
    internal interface IPartido
    {
        void crearPartido(string paisLocal, string paisVisitante, string ronda, string grupo, string estadio);
    }
}
