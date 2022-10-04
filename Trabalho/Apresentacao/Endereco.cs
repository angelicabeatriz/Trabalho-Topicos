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
    public partial class Endereco : Form
    {
        public Endereco()
        {
            InitializeComponent();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            CadastroUsuario cad = new CadastroUsuario();
            cad.Show();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            using (var ws = new Correios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(tbCep.Text);
                    tbQuadra.Text = resultado.end;
                    tbComplemento.Text = resultado.complemento2;
                    tbCidade.Text = resultado.cidade;
                 // tbBairro.Text = resultado.bairro;
                    tbUf.Text = resultado.uf;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=LAPTOP-R7T019C0\\MSQLBEATRIZ;Initial Catalog=Gestao Livros;Integrated Security=True");
            SqlCommand command = new SqlCommand("insert into Endereco(cep, quadra, numero, complemento, cidade, estado) " +
                "values(@cep, @quadra, @numero, @complemento, @cidade, @estado)", sql);
            command.Parameters.Add("@cep", SqlDbType.VarChar).Value = tbCep.Text;
            command.Parameters.Add("@quadra", SqlDbType.VarChar).Value = tbQuadra.Text;
            command.Parameters.Add("@numero", SqlDbType.VarChar).Value = tbNumero.Text;
            command.Parameters.Add("@complemento", SqlDbType.VarChar).Value = tbComplemento.Text;
            command.Parameters.Add("@cidade", SqlDbType.VarChar).Value = tbCidade.Text;
          //command.Parameters.Add("@bairro", SqlDbType.VarChar).Value = tbBairro.Text;
            command.Parameters.Add("@estado", SqlDbType.VarChar).Value = tbUf.Text;

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Endereço Cadastrado com Sucesso!");
                tbCep.Clear();
                tbQuadra.Clear();
                tbComplemento.Clear();
                tbNumero.Clear();
                tbUf.Clear();
              //tbBairro.Clear();
                tbCidade.Clear();
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
