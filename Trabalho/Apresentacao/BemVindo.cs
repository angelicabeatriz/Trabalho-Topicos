using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho.Apresentacao
{
    public partial class BemVindo : Form
    {
        public BemVindo()
        {
            InitializeComponent();
        }

        private void btCadAdm_Click(object sender, EventArgs e)
        {
            CadastrarAdm cadAdm = new CadastrarAdm();
            cadAdm.Show();
        }

        private void btCadLiv_Click(object sender, EventArgs e)
        {
            CadastroLivros cadLiv = new CadastroLivros();
            cadLiv.Show();
        }

        private void btCadGesLiv_Click(object sender, EventArgs e)
        {
            GestorLivro gestorLivro = new GestorLivro();   
            gestorLivro.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
