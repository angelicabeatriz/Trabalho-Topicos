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
    public partial class CadastrarAdm : Form
    {
        public CadastrarAdm()
        {
            InitializeComponent();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            BemVindo bemVindo = new BemVindo();
            bemVindo.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=LAPTOP-R7T019C0\\MSQLBEATRIZ;Initial Catalog=GestaoLivros;Integrated Security=True");
            SqlCommand command = new SqlCommand("insert into cadAdm(nome, email, senha) " +
                "values(@nome, @email, @senha, @confirmarSenha)", sql);
            command.Parameters.Add("@cnome", SqlDbType.VarChar).Value = tbNome.Text;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = tbSenha.Text;


            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Endereço Cadastrado com Sucesso!");
                tbNome.Clear();
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
    }
}
