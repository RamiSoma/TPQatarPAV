using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        enum resultadoTransaccion
        {
            exito,fracaso
        }
        enum tipoConexion
        {
            simple,transaccion
        }
        private resultadoTransaccion miEstado = resultadoTransaccion.exito;
        private tipoConexion miTipo = tipoConexion.simple;
        private SqlTransaction transaccion;

        private DBHelper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            string_conexion = "Data Source=FRANFERRAROPC;Initial Catalog=TPQatarPAV;Integrated Security=True";
            //string_conexion = "Data Source=RAMIRO-PC\\SQLSERVERPRUEBA;Initial Catalog=TPQatarPAV;Integrated Security=True";
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
        public void EjecutarSQLConTransaccion(string consulta)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;
                comando.ExecuteNonQuery();

                miEstado = resultadoTransaccion.exito;
            }
            catch (Exception)
            {
                miEstado = resultadoTransaccion.fracaso;
            }
        }
        public void conectarConTransaccion()
        {
            miTipo = tipoConexion.transaccion;
            miEstado = resultadoTransaccion.exito;

            conexion.ConnectionString = string_conexion;
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            comando.Transaction = transaccion;
            comando.Connection = conexion;
        }
        public bool desconectarSQL()
        {
            if (miTipo == tipoConexion.transaccion)
            {
                if (miEstado == resultadoTransaccion.exito)
                {
                    transaccion.Commit();
                }
                else
                {
                    transaccion.Rollback();
                }
                miTipo = tipoConexion.simple;
            }
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }
            conexion.Dispose();
            if (miEstado.Equals(resultadoTransaccion.exito))
                return true;
            else
                return false;
        }
    }
}
