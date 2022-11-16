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
        enum ResultadoTransaccion
        {
            exito,fracaso
        }
        enum TipoConexion
        {
            simple,transaccion
        }
        private ResultadoTransaccion miEstado = ResultadoTransaccion.exito;
        private TipoConexion miTipo = TipoConexion.simple;

        private SqlTransaction transaccion;
        private string string_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private static DBHelper instancia;

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
        public void conectarConTransaccion()
        {
            miTipo = TipoConexion.transaccion;
            miEstado = ResultadoTransaccion.exito;

            conexion.ConnectionString = string_conexion;
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            comando.Transaction = transaccion;
            comando.Connection = conexion;
        }
        public bool desconectarSQL()
        {
            if (miTipo == TipoConexion.transaccion)
            {
                if (miEstado == ResultadoTransaccion.exito)
                {
                    transaccion.Commit(); //MessageBox.Show("La trasacción resultó con éxito...");
                }
                else
                {
                    transaccion.Rollback(); //MessageBox.Show("La trasacción no pudo realizarce...");
                }
                miTipo = TipoConexion.simple;
            }
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();
            if (miEstado.Equals(ResultadoTransaccion.exito))
                return true;
            else
                return false;
        }

        public void EjecutarSQLConTransaccion(string consultaSql)
        {
            //  Se utiliza para sentencias SQL del tipo Insert, Update, Delete con transaccion.
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = consultaSql;
                comando.ExecuteNonQuery();
                miEstado = ResultadoTransaccion.exito;
            }
            catch
            {
                miEstado = ResultadoTransaccion.fracaso;
            }
        }
    }
}
