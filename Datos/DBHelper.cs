using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPQatarPAVI.Datos
{
    internal class DBHelper
    {
        private string string_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private static DBHelper instancia;

        private DBHelper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            //string_conexion = "Data Source=FRANFERRAROPC\\MSSQLSERVER01;Initial Catalog=Qatar2022;Integrated Security=True";
            string_conexion = "Data Source=RAMIRO-PC\\SQLSERVERPRUEBA;Initial Catalog=TPQatarPAV;Integrated Security=True";
        }

        public static DBHelper obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new DBHelper();
            }
            return instancia;
        }

        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = string_conexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }
    }
}
