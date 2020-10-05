namespace GUI.Popup.Cadastro
{
    partial class FrmPopupConsultaSubCategoria
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
            this.lblSubcategoria = new System.Windows.Forms.Label();
            this.tboxSubcategoria = new System.Windows.Forms.TextBox();
            this.pnChave.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChave
            // 
            this.pnChave.Controls.Add(this.tboxSubcategoria);
            this.pnChave.Controls.Add(this.lblSubcategoria);
            this.pnChave.Size = new System.Drawing.Size(460, 96);
            this.pnChave.Controls.SetChildIndex(this.btnRecuperar, 0);
            this.pnChave.Controls.SetChildIndex(this.lblSubcategoria, 0);
            this.pnChave.Controls.SetChildIndex(this.tboxSubcategoria, 0);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(380, 3);
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // pnGrade
            // 
            this.pnGrade.Size = new System.Drawing.Size(460, 430);
            // 
            // lblSubcategoria
            // 
            this.lblSubcategoria.AutoSize = true;
            this.lblSubcategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubcategoria.Location = new System.Drawing.Point(3, 34);
            this.lblSubcategoria.Name = "lblSubcategoria";
            this.lblSubcategoria.Size = new System.Drawing.Size(153, 23);
            this.lblSubcategoria.TabIndex = 1;
            this.lblSubcategoria.Text = "Subcategoria:";
            // 
            // tboxSubcategoria
            // 
            this.tboxSubcategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSubcategoria.Location = new System.Drawing.Point(162, 26);
            this.tboxSubcategoria.Name = "tboxSubcategoria";
            this.tboxSubcategoria.Size = new System.Drawing.Size(212, 31);
            this.tboxSubcategoria.TabIndex = 2;
            // 
            // FrmPopupConsultaSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(482, 561);
            this.Name = "FrmPopupConsultaSubCategoria";
            this.Text = "Consulta Subcategoria";
            this.Load += new System.EventHandler(this.FrmPopupConsultaSubCategoria_Load);
            this.pnChave.ResumeLayout(false);
            this.pnChave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSubcategoria;
        private System.Windows.Forms.TextBox tboxSubcategoria;
    }
}
