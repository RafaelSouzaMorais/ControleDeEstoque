namespace GUI.Popup.Cadastro
{
    partial class FrmPopupConsultaCategoria
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tboxCategoria = new System.Windows.Forms.TextBox();
            this.pnChave.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChave
            // 
            this.pnChave.Controls.Add(this.tboxCategoria);
            this.pnChave.Controls.Add(this.lblCategoria);
            this.pnChave.Size = new System.Drawing.Size(357, 100);
            this.pnChave.Controls.SetChildIndex(this.btnRecuperar, 0);
            this.pnChave.Controls.SetChildIndex(this.lblCategoria, 0);
            this.pnChave.Controls.SetChildIndex(this.tboxCategoria, 0);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(275, 3);
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // pnGrade
            // 
            this.pnGrade.Size = new System.Drawing.Size(357, 431);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(3, 34);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(120, 23);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria:";
            // 
            // tboxCategoria
            // 
            this.tboxCategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCategoria.Location = new System.Drawing.Point(129, 26);
            this.tboxCategoria.Name = "tboxCategoria";
            this.tboxCategoria.Size = new System.Drawing.Size(131, 31);
            this.tboxCategoria.TabIndex = 2;
            // 
            // FrmPopupConsultaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(380, 561);
            this.Name = "FrmPopupConsultaCategoria";
            this.Text = "Consulta Categoria";
            this.Load += new System.EventHandler(this.FrmPopupConsultaCategoria_Load);
            this.pnChave.ResumeLayout(false);
            this.pnChave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tboxCategoria;
        private System.Windows.Forms.Label lblCategoria;
    }
}
