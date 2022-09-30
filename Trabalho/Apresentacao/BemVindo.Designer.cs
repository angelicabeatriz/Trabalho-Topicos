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
            this.btCadLiv = new System.Windows.Forms.Button();
            this.btCadAdm = new System.Windows.Forms.Button();
            this.btCadGesLiv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo, Administrador";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btCadGesLiv);
            this.panel1.Controls.Add(this.btCadAdm);
            this.panel1.Controls.Add(this.btCadLiv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(341, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 287);
            this.panel1.TabIndex = 1;
            // 
            // btCadLiv
            // 
            this.btCadLiv.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadLiv.Location = new System.Drawing.Point(27, 173);
            this.btCadLiv.Name = "btCadLiv";
            this.btCadLiv.Size = new System.Drawing.Size(177, 23);
            this.btCadLiv.TabIndex = 2;
            this.btCadLiv.Text = "Cadastrar Livro";
            this.btCadLiv.UseVisualStyleBackColor = true;
            // 
            // btCadAdm
            // 
            this.btCadAdm.BackColor = System.Drawing.Color.Transparent;
            this.btCadAdm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadAdm.Location = new System.Drawing.Point(27, 131);
            this.btCadAdm.Name = "btCadAdm";
            this.btCadAdm.Size = new System.Drawing.Size(177, 23);
            this.btCadAdm.TabIndex = 3;
            this.btCadAdm.Text = "Cadastrar Adminstrador";
            this.btCadAdm.UseVisualStyleBackColor = false;
            // 
            // btCadGesLiv
            // 
            this.btCadGesLiv.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadGesLiv.Location = new System.Drawing.Point(27, 214);
            this.btCadGesLiv.Name = "btCadGesLiv";
            this.btCadGesLiv.Size = new System.Drawing.Size(177, 23);
            this.btCadGesLiv.TabIndex = 4;
            this.btCadGesLiv.Text = "Cadastrar Gestor de Livro";
            this.btCadGesLiv.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Escolha o que deseja cadastrar:";
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1185, 605);
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
    }
}