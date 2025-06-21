using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace tp_logica_robles.Datos
{
    public class AccesoDatos
    {
        private string CadenaConexion = $"Data Source=LUCAS-PADULA\\MSSQLSERVER1;Initial Catalog=TP_ROBLES;User ID=sa;Password=autotrader;Persist Security Info=True";
        //$"Data Source=FACUNDOBALLS;Initial Catalog=TP_ROBLES;Integrated Security=True";
        //Properties.Resources.CadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public AccesoDatos()
        {
            conexion = new SqlConnection(CadenaConexion);
        }
        private void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void Desconectar()
        {
            conexion.Close();
        }
        public DataTable ConsultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            this.Conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            this.Desconectar();
            return tabla;
        }
        public DataTable ConsultarBD(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            this.Conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            this.Desconectar();
            return tabla;
        }
        public int ActualizarBD(string consultaSQL)
        {
            int filasAfectadas = 0;
            this.Conectar();
            comando.CommandText = consultaSQL;
            filasAfectadas = comando.ExecuteNonQuery();
            this.Desconectar();
            return filasAfectadas;
        }
        public int ActualizarBD(string consultaSQL, List<Parametro> lista)
        {
            int filasAfectadas = 0;
            this.Conectar();
            comando.CommandText = consultaSQL;
            foreach (Parametro p in lista)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            filasAfectadas = comando.ExecuteNonQuery();
            this.Desconectar();
            return filasAfectadas;
        }
        public DataTable ConsultarBD(string consultaSQL, List<Parametro> lista)
        {
            DataTable tabla = new DataTable();
            this.Conectar();
            comando.CommandText = consultaSQL;
            foreach (Parametro p in lista)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
                Debug.WriteLine($"Parámetro: {p.Nombre} = {p.Valor} (Tipo: {p.Valor?.GetType().Name ?? "null"})");
            }
            Debug.WriteLine("Consulta FINAL aproximada: " + comando.CommandText);
            tabla.Load(comando.ExecuteReader());

            this.Desconectar();
            return tabla;
        }



    }
}
