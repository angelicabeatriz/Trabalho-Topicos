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
    public partial class CadastroLivros : Form
    {
        public CadastroLivros()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            BemVindo bemVindo = new BemVindo();
            bemVindo.Show();
        }

        private void tbSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=LAPTOP-R7T019C0\\MSQLBEATRIZ;Initial Catalog=GestaoLivros;Integrated Security=True");
            SqlCommand command = new SqlCommand("insert into cadAdm(tituloLivro, editora, anoPlubi, autores, quantExemplar) " +
                "values(@tituloLivro, @editora, @anoPlubi, @autores, @quantExemplar)", sql);
            command.Parameters.Add("@tituloLivro", SqlDbType.VarChar).Value = tbTitLiv.Text;
            command.Parameters.Add("@editora", SqlDbType.VarChar).Value = tbEditora.Text;
            command.Parameters.Add("@anoPlubi", SqlDbType.VarChar).Value = tbAnoPlub.Text;
            command.Parameters.Add("@autores", SqlDbType.VarChar).Value = tbAutores.Text;
            command.Parameters.Add("@quantExemplar", SqlDbType.VarChar).Value = tbQuantLiv.Text;

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Endereço Cadastrado com Sucesso!");
                tbTitLiv.Clear();
                tbEditora.Clear();
                tbAnoPlub.Clear();
                tbAutores.Clear();
                tbQuantLiv.Clear();
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
