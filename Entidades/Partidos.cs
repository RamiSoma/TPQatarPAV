using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Entidades
{
    internal class Partidos
    {
        public string paisLocal { get; set; }
        public string paisVisita { get; set; }
        public string nroDocArb { get; set; }
        public string tipoDocArb { get; set; }
        public string nombreArb { get; set; }
        public string fecha { get; set; }
        public string ronda { get; set; }
        public string grupo { get; set; }
        public string estadio { get; set; }
    }

}
