using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Datos
{
    internal class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();

        private DBHelper()
        {
            string_conexion = "Data Source=RAMIRO-PC\\SQLSERVERPRUEBA;Initial Catalog=TPQatarPAV;Integrated Security=TrueData Source = RAMIRO - PC\\SQLSERVERPRUEBA;Initial Catalog = TPQatarPAV; Integrated Security = True";
        }

        public static DBHelper getDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        public string obtenerConexionString()
        {
            return string_conexion;
        }
    }
}
