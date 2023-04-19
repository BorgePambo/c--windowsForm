using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DAO
{
    internal class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand command = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader reader;

        public bool verificarLogin(String email, String senha) {
            command.CommandText = "select * from logins WHERE " +
                "email = @email and senha = @senha";
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@senha", senha);

            try
            {
                command.Connection = con.conectar();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    tem = true;
                }

            }
            catch (SqlException) {
                this.mensagem = "Erro ao acessar Banco de Dados";
            }
           

            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha) {
            return mensagem;
        }

    }
}
