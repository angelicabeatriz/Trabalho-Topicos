using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho.Modelo;

namespace Trabalho.Apresentacao
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            Endereco end = new Endereco();
            end.Show();
        }
        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btCad_Click(object sender, EventArgs e)
        {
            
                SqlConnection sql = new SqlConnection("Data Source=LAPTOP-R7T019C0\\MSQLBEATRIZ;Initial Catalog=Gestao Livros;Integrated Security=True");
                SqlCommand command = new SqlCommand("insert into CadastroUsuario(IDUsuario, Login, Senha, ConfirmarSenha) " +
                    "values(@IDUsuario, @Login, @Senha, @ConfirmarSenha)", sql);
                command.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = 0;
                command.Parameters.Add("@Login", SqlDbType.VarChar).Value = tbLogin.Text;
                command.Parameters.Add("@Senha", SqlDbType.VarChar).Value = tbSenha.Text;
                command.Parameters.Add("@ConfirmarSenha", SqlDbType.VarChar).Value = tbConfirmarSenha.Text;

                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Endereço Cadastrado com Sucesso!");
                    tbLogin.Clear();
                    tbSenha.Clear();
                    tbConfirmarSenha.Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Olha o erro: " + ex);
                }
                finally
                {
                    sql.Close();
                }
            Controle controle = new Controle();
            controle.cadastrar(tbLogin.Text, tbSenha.Text, tbConfirmarSenha.Text);
            if (controle.mensagem.Equals(" "))
            {

                if (controle.encontrado)
                {
                    MessageBox.Show("Cadastrado com Sucesso", "Cadastrando",
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

        private void lbTermoUso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TermoUso termouso = new TermoUso();
            termouso.Show();
        }
    }
}
