using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Datos.Daos
{
    class PerfilDao : IPerfil
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Perfiles WHERE borrado = 0 order by 2";
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
