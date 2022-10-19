using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Entidades
{
    internal class Evento
    {
        private int idEvento;
        private int idPartido;
        private int minuto;
        private string tipoDocJug;
        private int nroDocJug;
        private string tipoEvento;

        public int IdEvento { get => idEvento; set => idEvento = value; }
        public int IdPartido { get => idPartido; set => idPartido = value; }
        public int Minuto { get => minuto; set => minuto = value; }
        public string TipoDocJug{ get => tipoDocJug; set => tipoDocJug = value; }
        public int NroDocJug { get => nroDocJug; set => nroDocJug = value; }
        public string TipoEvento{ get => tipoEvento; set => tipoEvento= value; }
    }
}
