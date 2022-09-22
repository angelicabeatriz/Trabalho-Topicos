namespace Trabalho
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.btCadastro = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btEntrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFacaLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(18, 137);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(38, 16);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Login";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(18, 192);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(44, 16);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(21, 156);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(237, 20);
            this.tbLogin.TabIndex = 3;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(21, 211);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(237, 20);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.TextChanged += new System.EventHandler(this.tbSenha_TextChanged);
            // 
            // btCadastro
            // 
            this.btCadastro.BackColor = System.Drawing.Color.White;
            this.btCadastro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.Location = new System.Drawing.Point(102, 275);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(75, 23);
            this.btCadastro.TabIndex = 5;
            this.btCadastro.Text = "Cadastro";
            this.btCadastro.UseVisualStyleBackColor = false;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.White;
            this.btSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(183, 275);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.White;
            this.btEntrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrar.Location = new System.Drawing.Point(21, 275);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(75, 23);
            this.btEntrar.TabIndex = 7;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbFacaLogin);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.btEntrar);
            this.panel1.Controls.Add(this.btCadastro);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tbLogin);
            this.panel1.Controls.Add(this.lbLogin);
            this.panel1.Controls.Add(this.lbSenha);
            this.panel1.Controls.Add(this.tbSenha);
            this.panel1.Location = new System.Drawing.Point(29, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 329);
            this.panel1.TabIndex = 8;
            // 
            // lbFacaLogin
            // 
            this.lbFacaLogin.AutoSize = true;
            this.lbFacaLogin.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacaLogin.Location = new System.Drawing.Point(130, 16);
            this.lbFacaLogin.Name = "lbFacaLogin";
            this.lbFacaLogin.Size = new System.Drawing.Size(172, 27);
            this.lbFacaLogin.TabIndex = 1;
            this.lbFacaLogin.Text = "Faça seu Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(489, 477);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFacaLogin;
    }
}

