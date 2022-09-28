using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Datos.Interfaces
{
    internal interface IPais
    {
        DataTable RecuperarTodos(string fNombre, string fRegion);
        void crearPais(string nNombre, string nRanking, string nContinente, string nGrupo);
        void eliminarPais(string pais);

        void modificarPais(string nombre, string continente, string ranking, string grupo);
        bool validar(string nombre, string ranking);
        DataTable recuperarEliminados();
        void recuperarPais(string nombre);
    }
}
