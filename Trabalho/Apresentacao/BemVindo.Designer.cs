namespace Trabalho.Apresentacao
{
    partial class BemVindo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btCadGesLiv = new System.Windows.Forms.Button();
            this.btCadAdm = new System.Windows.Forms.Button();
            this.btCadLiv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo, Administrador";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btCadGesLiv);
            this.panel1.Controls.Add(this.btCadAdm);
            this.panel1.Controls.Add(this.btCadLiv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 238);
            this.panel1.TabIndex = 1;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Transparent;
            this.btSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(470, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(41, 23);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Escolha o que deseja cadastrar:";
            // 
            // btCadGesLiv
            // 
            this.btCadGesLiv.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadGesLiv.Location = new System.Drawing.Point(142, 183);
            this.btCadGesLiv.Name = "btCadGesLiv";
            this.btCadGesLiv.Size = new System.Drawing.Size(177, 23);
            this.btCadGesLiv.TabIndex = 4;
            this.btCadGesLiv.Text = "Cadastrar Gestor de Livro";
            this.btCadGesLiv.UseVisualStyleBackColor = true;
            this.btCadGesLiv.Click += new System.EventHandler(this.btCadGesLiv_Click);
            // 
            // btCadAdm
            // 
            this.btCadAdm.BackColor = System.Drawing.Color.Transparent;
            this.btCadAdm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadAdm.Location = new System.Drawing.Point(142, 125);
            this.btCadAdm.Name = "btCadAdm";
            this.btCadAdm.Size = new System.Drawing.Size(177, 23);
            this.btCadAdm.TabIndex = 3;
            this.btCadAdm.Text = "Cadastrar Adminstrador";
            this.btCadAdm.UseVisualStyleBackColor = false;
            this.btCadAdm.Click += new System.EventHandler(this.btCadAdm_Click);
            // 
            // btCadLiv
            // 
            this.btCadLiv.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadLiv.Location = new System.Drawing.Point(142, 154);
            this.btCadLiv.Name = "btCadLiv";
            this.btCadLiv.Size = new System.Drawing.Size(177, 23);
            this.btCadLiv.TabIndex = 2;
            this.btCadLiv.Text = "Cadastrar Livro";
            this.btCadLiv.UseVisualStyleBackColor = true;
            this.btCadLiv.Click += new System.EventHandler(this.btCadLiv_Click);
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(547, 298);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BemVindo";
            this.Text = "BemVindo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCadGesLiv;
        private System.Windows.Forms.Button btCadAdm;
        private System.Windows.Forms.Button btCadLiv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSair;
    }
}