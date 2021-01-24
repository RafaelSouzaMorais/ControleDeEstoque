namespace GUI.Configuração
{
    partial class FrmBancoDados
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
            this.pnDados = new System.Windows.Forms.Panel();
            this.tboxSenha = new System.Windows.Forms.TextBox();
            this.tboxUsuario = new System.Windows.Forms.TextBox();
            this.tboxBancoDados = new System.Windows.Forms.TextBox();
            this.tboxServidor = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBancoDados = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.tboxSenha);
            this.pnDados.Controls.Add(this.tboxUsuario);
            this.pnDados.Controls.Add(this.tboxBancoDados);
            this.pnDados.Controls.Add(this.tboxServidor);
            this.pnDados.Controls.Add(this.lblSenha);
            this.pnDados.Controls.Add(this.lblUsuario);
            this.pnDados.Controls.Add(this.lblBancoDados);
            this.pnDados.Controls.Add(this.lblServidor);
            this.pnDados.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDados.Location = new System.Drawing.Point(8, 6);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(423, 242);
            this.pnDados.TabIndex = 0;
            // 
            // tboxSenha
            // 
            this.tboxSenha.Location = new System.Drawing.Point(165, 187);
            this.tboxSenha.Name = "tboxSenha";
            this.tboxSenha.PasswordChar = '*';
            this.tboxSenha.Size = new System.Drawing.Size(220, 31);
            this.tboxSenha.TabIndex = 7;
            // 
            // tboxUsuario
            // 
            this.tboxUsuario.Location = new System.Drawing.Point(165, 130);
            this.tboxUsuario.Name = "tboxUsuario";
            this.tboxUsuario.Size = new System.Drawing.Size(220, 31);
            this.tboxUsuario.TabIndex = 6;
            // 
            // tboxBancoDados
            // 
            this.tboxBancoDados.Location = new System.Drawing.Point(165, 73);
            this.tboxBancoDados.Name = "tboxBancoDados";
            this.tboxBancoDados.Size = new System.Drawing.Size(220, 31);
            this.tboxBancoDados.TabIndex = 5;
            // 
            // tboxServidor
            // 
            this.tboxServidor.Location = new System.Drawing.Point(165, 16);
            this.tboxServidor.Name = "tboxServidor";
            this.tboxServidor.Size = new System.Drawing.Size(220, 31);
            this.tboxServidor.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(72, 190);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(76, 23);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(50, 133);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 23);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblBancoDados
            // 
            this.lblBancoDados.AutoSize = true;
            this.lblBancoDados.Location = new System.Drawing.Point(6, 76);
            this.lblBancoDados.Name = "lblBancoDados";
            this.lblBancoDados.Size = new System.Drawing.Size(142, 23);
            this.lblBancoDados.TabIndex = 1;
            this.lblBancoDados.Text = "Banco Dados:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(39, 19);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(109, 23);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor:";
            // 
            // pnBotoes
            // 
            this.pnBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBotoes.Controls.Add(this.btnSalvar);
            this.pnBotoes.Location = new System.Drawing.Point(8, 259);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(423, 96);
            this.pnBotoes.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::GUI.Properties.Resources.icons8_ok_64;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(341, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 90);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmBancoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 359);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnDados);
            this.Name = "FrmBancoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Dados";
            this.Load += new System.EventHandler(this.FrmBancoDados_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox tboxSenha;
        private System.Windows.Forms.TextBox tboxUsuario;
        private System.Windows.Forms.TextBox tboxBancoDados;
        private System.Windows.Forms.TextBox tboxServidor;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBancoDados;
    }
}
