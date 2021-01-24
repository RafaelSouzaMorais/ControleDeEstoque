namespace GUI.Cadastro
{
    partial class FrmSubCategoria
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNomeSubCat = new System.Windows.Forms.Label();
            this.lblNomeCat = new System.Windows.Forms.Label();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.tboxNomeSubCat = new System.Windows.Forms.TextBox();
            this.cboxCatCod = new System.Windows.Forms.ComboBox();
            this.pnDados.SuspendLayout();
            this.pnBotões.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.cboxCatCod);
            this.pnDados.Controls.Add(this.tboxNomeSubCat);
            this.pnDados.Controls.Add(this.tboxCodigo);
            this.pnDados.Controls.Add(this.lblNomeCat);
            this.pnDados.Controls.Add(this.lblNomeSubCat);
            this.pnDados.Controls.Add(this.lblCodigo);
            this.pnDados.Size = new System.Drawing.Size(574, 199);
            // 
            // pnBotões
            // 
            this.pnBotões.Location = new System.Drawing.Point(12, 217);
            this.pnBotões.Size = new System.Drawing.Size(574, 96);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(483, 2);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(402, 2);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(157, 44);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 23);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNomeSubCat
            // 
            this.lblNomeSubCat.AutoSize = true;
            this.lblNomeSubCat.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSubCat.Location = new System.Drawing.Point(3, 89);
            this.lblNomeSubCat.Name = "lblNomeSubCat";
            this.lblNomeSubCat.Size = new System.Drawing.Size(241, 23);
            this.lblNomeSubCat.TabIndex = 1;
            this.lblNomeSubCat.Text = "Nome da Subcategoria:";
            // 
            // lblNomeCat
            // 
            this.lblNomeCat.AutoSize = true;
            this.lblNomeCat.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCat.Location = new System.Drawing.Point(36, 135);
            this.lblNomeCat.Name = "lblNomeCat";
            this.lblNomeCat.Size = new System.Drawing.Size(208, 23);
            this.lblNomeCat.TabIndex = 2;
            this.lblNomeCat.Text = "Nome da Categoria:";
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Enabled = false;
            this.tboxCodigo.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigo.Location = new System.Drawing.Point(275, 36);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(100, 31);
            this.tboxCodigo.TabIndex = 3;
            // 
            // tboxNomeSubCat
            // 
            this.tboxNomeSubCat.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNomeSubCat.Location = new System.Drawing.Point(275, 81);
            this.tboxNomeSubCat.MaxLength = 95;
            this.tboxNomeSubCat.Name = "tboxNomeSubCat";
            this.tboxNomeSubCat.Size = new System.Drawing.Size(250, 31);
            this.tboxNomeSubCat.TabIndex = 4;
            // 
            // cboxCatCod
            // 
            this.cboxCatCod.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCatCod.FormattingEnabled = true;
            this.cboxCatCod.Location = new System.Drawing.Point(275, 127);
            this.cboxCatCod.Name = "cboxCatCod";
            this.cboxCatCod.Size = new System.Drawing.Size(250, 31);
            this.cboxCatCod.TabIndex = 5;
            // 
            // FrmSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(591, 319);
            this.Name = "FrmSubCategoria";
            this.Text = "Cadastro de Subcategoria";
            this.Load += new System.EventHandler(this.FrmSubCategoria_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotões.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxCatCod;
        private System.Windows.Forms.TextBox tboxNomeSubCat;
        private System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.Label lblNomeCat;
        private System.Windows.Forms.Label lblNomeSubCat;
        private System.Windows.Forms.Label lblCodigo;
    }
}
