using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho.Apresentacao;
using Trabalho.Modelo;

namespace Trabalho
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(tbLogin.Text, tbSenha.Text);
            if (controle.mensagem.Equals(" "))
            {

                if (controle.encontrado)
                {
                    MessageBox.Show("Logado com Sucesso", "Logando",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bem = new BemVindo();
                    bem.Show();
                }
                else
                {
                    MessageBox.Show("Verifique login e senha", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }
        private void btAjuda_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
        }
        private void btSobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbGestaoLivros_Click(object sender, EventArgs e)
        {

        }

        private void lbFacaLogin_Click(object sender, EventArgs e)
        {

        }

        private void lbCPFCNPJ_Click(object sender, EventArgs e)
        {

        }
    }
}
