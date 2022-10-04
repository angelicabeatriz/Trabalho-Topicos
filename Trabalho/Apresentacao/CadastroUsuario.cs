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
            
                SqlConnection sql = new SqlConnection("Data Source=LAPTOP-R7T019C0\\MSQLBEATRIZ;Initial Catalog=GestaoLivros;Integrated Security=True");
                SqlCommand command = new SqlCommand("insert into cadUsuario(email, senha, confirmarSenha) " +
                    "values(@email, @senha, @confirmarSenha)", sql);
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = tbSenha.Text;
            command.Parameters.Add("@confirmarSenha", SqlDbType.VarChar).Value = tbConfirmarSenha.Text;
       
            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Endereço Cadastrado com Sucesso!");
                tbEmail.Clear();
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

        }

        private void lbTermoUso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TermoUso termouso = new TermoUso();
            termouso.Show();
        }
    }
}
