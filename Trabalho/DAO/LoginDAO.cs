using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.DAO
{
    public class LoginDAO
    {
        public bool tem;
        public bool encontrado;
        public String mensagem;
        public bool verificar(String login, String senha)
        {
            //comando sql para verificar
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
