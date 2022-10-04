namespace Trabalho.Apresentacao
{
    partial class CadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCad = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.lbTermoUso = new System.Windows.Forms.LinkLabel();
            this.cbTermoUso = new System.Windows.Forms.CheckBox();
            this.btProximo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Senha";
            // 
            // btCad
            // 
            this.btCad.BackColor = System.Drawing.Color.White;
            this.btCad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCad.Location = new System.Drawing.Point(113, 249);
            this.btCad.Name = "btCad";
            this.btCad.Size = new System.Drawing.Size(75, 23);
            this.btCad.TabIndex = 3;
            this.btCad.Text = "Cadastrar";
            this.btCad.UseVisualStyleBackColor = false;
            this.btCad.Click += new System.EventHandler(this.btCad_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(32, 97);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(226, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(32, 154);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(226, 20);
            this.tbSenha.TabIndex = 5;
            // 
            // tbConfirmarSenha
            // 
            this.tbConfirmarSenha.Location = new System.Drawing.Point(32, 211);
            this.tbConfirmarSenha.Name = "tbConfirmarSenha";
            this.tbConfirmarSenha.PasswordChar = '*';
            this.tbConfirmarSenha.Size = new System.Drawing.Size(226, 20);
            this.tbConfirmarSenha.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.lbTermoUso);
            this.panel1.Controls.Add(this.cbTermoUso);
            this.panel1.Controls.Add(this.btProximo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btCad);
            this.panel1.Controls.Add(this.tbConfirmarSenha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbSenha);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 348);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Transparent;
            this.btSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(284, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(41, 23);
            this.btSair.TabIndex = 10;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbTermoUso
            // 
            this.lbTermoUso.AutoSize = true;
            this.lbTermoUso.Location = new System.Drawing.Point(3, 302);
            this.lbTermoUso.Name = "lbTermoUso";
            this.lbTermoUso.Size = new System.Drawing.Size(116, 13);
            this.lbTermoUso.TabIndex = 9;
            this.lbTermoUso.TabStop = true;
            this.lbTermoUso.Text = "Leia os Termos de Uso";
            this.lbTermoUso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbTermoUso_LinkClicked);
            // 
            // cbTermoUso
            // 
            this.cbTermoUso.AutoSize = true;
            this.cbTermoUso.Location = new System.Drawing.Point(6, 282);
            this.cbTermoUso.Name = "cbTermoUso";
            this.cbTermoUso.Size = new System.Drawing.Size(93, 17);
            this.cbTermoUso.TabIndex = 8;
            this.cbTermoUso.Text = "Termo de Uso";
            this.cbTermoUso.UseVisualStyleBackColor = true;
            // 
            // btProximo
            // 
            this.btProximo.BackColor = System.Drawing.Color.Transparent;
            this.btProximo.Location = new System.Drawing.Point(273, 292);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(52, 23);
            this.btProximo.TabIndex = 7;
            this.btProximo.Text = "Proximo";
            this.btProximo.UseVisualStyleBackColor = false;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cadastrar Usuario";
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 397);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastroUsuario";
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCad;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbConfirmarSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.LinkLabel lbTermoUso;
        private System.Windows.Forms.CheckBox cbTermoUso;
        private System.Windows.Forms.Button btSair;
    }
}