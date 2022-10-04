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

namespace Trabalho.Apresentacao
{
    public partial class GestorLivro : Form
    {
        public GestorLivro()
        {
            InitializeComponent();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            BemVindo bemVindo = new BemVindo();
            bemVindo.Show();
        }

        private void tbSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=LAPTOP-R7T019C0\\MSQLBEATRIZ;Initial Catalog=GestaoLivros;Integrated Security=True");
            SqlCommand command = new SqlCommand("insert into cadAdm(nome, endereco, dataNascimento, rg, cpf, email, senha) " +
                "values(@nome, @endereco, @dataNascimento, @rg, @cpf, @email, @senha)", sql);
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = tbNome.Text; 
            command.Parameters.Add("@endereco", SqlDbType.VarChar).Value = tbEnd.Text;
            command.Parameters.Add("@dataNascimento", SqlDbType.VarChar).Value = tbDtNasc.Text;
            command.Parameters.Add("@rg", SqlDbType.VarChar).Value = tbRG.Text;
            command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = tbCPF.Text;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = tbSenha.Text;


            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Endereço Cadastrado com Sucesso!");
                tbNome.Clear();
                tbEnd.Clear();
                tbDtNasc.Clear();
                tbRG.Clear();
                tbCPF.Clear();
                tbEmail.Clear();
                tbSenha.Clear();

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

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
