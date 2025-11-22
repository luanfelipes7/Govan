using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;
using System.Data;

namespace AppVan.Controller
{
    public class Conexao
    {
        private static string conexao = @"Data Source=govan.database.windows.net;Initial Catalog=GoVan;User ID=govan.banco;Password=2020ehl*";
        private static SqlConnection conn = null;
        public static SqlConnection obterConexao()
        {
            conn = new SqlConnection(conexao);
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                conn = null;
                Console.WriteLine("Não foi possivel conectar");
            }
            return conn;
        }
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}

