namespace appTeste2
{
    partial class Form1
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
            this.txtbox_nome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbox_idade = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtbox_usuario = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtbox_senha = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.bnt_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_nome
            // 
            this.txtbox_nome.AutoSize = true;
            this.txtbox_nome.Location = new System.Drawing.Point(138, 125);
            this.txtbox_nome.Name = "txtbox_nome";
            this.txtbox_nome.Size = new System.Drawing.Size(123, 20);
            this.txtbox_nome.TabIndex = 0;
            this.txtbox_nome.Text = "Nome Completo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 26);
            this.textBox1.TabIndex = 1;
            // 
            // txtbox_idade
            // 
            this.txtbox_idade.AutoSize = true;
            this.txtbox_idade.Location = new System.Drawing.Point(209, 162);
            this.txtbox_idade.Name = "txtbox_idade";
            this.txtbox_idade.Size = new System.Drawing.Size(50, 20);
            this.txtbox_idade.TabIndex = 2;
            this.txtbox_idade.Text = "Idade";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 26);
            this.textBox2.TabIndex = 3;
            // 
            // txtbox_email
            // 
            this.txtbox_email.AutoSize = true;
            this.txtbox_email.Location = new System.Drawing.Point(208, 206);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(53, 20);
            this.txtbox_email.TabIndex = 4;
            this.txtbox_email.Text = "E-mail";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(276, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 26);
            this.textBox3.TabIndex = 5;
            // 
            // txtbox_usuario
            // 
            this.txtbox_usuario.AutoSize = true;
            this.txtbox_usuario.Location = new System.Drawing.Point(195, 249);
            this.txtbox_usuario.Name = "txtbox_usuario";
            this.txtbox_usuario.Size = new System.Drawing.Size(64, 20);
            this.txtbox_usuario.TabIndex = 6;
            this.txtbox_usuario.Text = "Usuario";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(276, 243);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(218, 26);
            this.textBox4.TabIndex = 7;
            // 
            // txtbox_senha
            // 
            this.txtbox_senha.AutoSize = true;
            this.txtbox_senha.Location = new System.Drawing.Point(203, 296);
            this.txtbox_senha.Name = "txtbox_senha";
            this.txtbox_senha.Size = new System.Drawing.Size(56, 20);
            this.txtbox_senha.TabIndex = 8;
            this.txtbox_senha.Text = "Senha";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(276, 290);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(152, 26);
            this.textBox5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Comfirmar Senha";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(276, 333);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(152, 26);
            this.textBox6.TabIndex = 11;
            // 
            // bnt_cadastrar
            // 
            this.bnt_cadastrar.Location = new System.Drawing.Point(441, 403);
            this.bnt_cadastrar.Name = "bnt_cadastrar";
            this.bnt_cadastrar.Size = new System.Drawing.Size(104, 31);
            this.bnt_cadastrar.TabIndex = 12;
            this.bnt_cadastrar.Text = "Cadastrar";
            this.bnt_cadastrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 700);
            this.Controls.Add(this.bnt_cadastrar);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtbox_senha);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtbox_usuario);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtbox_idade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtbox_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtbox_nome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtbox_idade;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtbox_email;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtbox_usuario;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtbox_senha;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button bnt_cadastrar;
    }
}

