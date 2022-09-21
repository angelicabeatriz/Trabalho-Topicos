using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.DAO
{
    public class LoginDAO
    {
        public bool tem = false;
        public bool encontrado;
        public String mensagem = " ";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificar(String login, String senha)
        {
            //comando sql para verificar
            cmd.CommandText = "select * from nomeTabela where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }

            }

            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }

        public String inserir(String email, String senha, String ConfirmarSenha)
        {
            //comando sql para inserir
            return mensagem;
        }

        public bool acessar(String login, String senha)
        {
            LoginDAO loginDAO = new LoginDAO();

            encontrado = loginDAO.verificar(login, senha);
            
            if(!loginDAO.mensagem.Equals(" "))
            {
                this.mensagem = loginDAO.mensagem;
            }

            return encontrado;
        }
    }
}
