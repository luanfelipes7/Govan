using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppVan.Controller
{
    public class LoginDao
    {
        private bool var = false;
        private string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlConnection conn = Conexao.obterConexao();
        SqlDataReader dr;
        public bool verificaLogin(string login,string senha)
        {
            cmd.CommandText = "Select  * from tb_Admin where adm_st_usuario=@user and adm_st_senha=@password";
            cmd.Parameters.AddWithValue("@user", login);
            cmd.Parameters.AddWithValue("@password", senha);
            try
            {
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    var = true;
                    mensagem = "Login encontrado";
                }
                else
                {
                    mensagem = "Login não encontrado";
                }
            }
            catch(Exception ex)
            {
                mensagem = "Erro" + ex;
            }
            Console.WriteLine(mensagem);
            return var;
        }
    }
}
