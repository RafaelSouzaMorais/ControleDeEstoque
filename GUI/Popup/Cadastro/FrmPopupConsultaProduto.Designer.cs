namespace GUI.Popup.Cadastro
{
    partial class FrmPopupConsultaProduto
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
            this.tboxProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.pnChave.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChave
            // 
            this.pnChave.Controls.Add(this.lblProduto);
            this.pnChave.Controls.Add(this.tboxProduto);
            this.pnChave.Controls.SetChildIndex(this.btnRecuperar, 0);
            this.pnChave.Controls.SetChildIndex(this.tboxProduto, 0);
            this.pnChave.Controls.SetChildIndex(this.lblProduto, 0);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // tboxProduto
            // 
            this.tboxProduto.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxProduto.Location = new System.Drawing.Point(107, 26);
            this.tboxProduto.Name = "tboxProduto";
            this.tboxProduto.Size = new System.Drawing.Size(350, 31);
            this.tboxProduto.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(3, 34);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(98, 23);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "Produto:";
            // 
            // FrmPopupConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "FrmPopupConsultaProduto";
            this.Text = "Consulta Produto";
            this.Load += new System.EventHandler(this.FrmPopupConsultaProduto_Load);
            this.pnChave.ResumeLayout(false);
            this.pnChave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tboxProduto;
        private System.Windows.Forms.Label lblProduto;
    }
}
