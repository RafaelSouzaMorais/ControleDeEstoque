namespace GUI.Popup.Cadastro
{
    partial class FrmPopupConsultaUnidadeMedida
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
            this.tboxUnidadeMedida = new System.Windows.Forms.TextBox();
            this.lblUnidadeMedida = new System.Windows.Forms.Label();
            this.pnChave.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnChave
            // 
            this.pnChave.Controls.Add(this.tboxUnidadeMedida);
            this.pnChave.Controls.Add(this.lblUnidadeMedida);
            this.pnChave.Size = new System.Drawing.Size(443, 100);
            this.pnChave.Controls.SetChildIndex(this.btnRecuperar, 0);
            this.pnChave.Controls.SetChildIndex(this.lblUnidadeMedida, 0);
            this.pnChave.Controls.SetChildIndex(this.tboxUnidadeMedida, 0);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(360, 3);
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // pnGrade
            // 
            this.pnGrade.Size = new System.Drawing.Size(443, 430);
            // 
            // tboxUnidadeMedida
            // 
            this.tboxUnidadeMedida.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUnidadeMedida.Location = new System.Drawing.Point(213, 23);
            this.tboxUnidadeMedida.Name = "tboxUnidadeMedida";
            this.tboxUnidadeMedida.Size = new System.Drawing.Size(131, 31);
            this.tboxUnidadeMedida.TabIndex = 4;
            // 
            // lblUnidadeMedida
            // 
            this.lblUnidadeMedida.AutoSize = true;
            this.lblUnidadeMedida.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeMedida.Location = new System.Drawing.Point(-1, 31);
            this.lblUnidadeMedida.Name = "lblUnidadeMedida";
            this.lblUnidadeMedida.Size = new System.Drawing.Size(208, 23);
            this.lblUnidadeMedida.TabIndex = 3;
            this.lblUnidadeMedida.Text = "Unidade de Medida:";
            // 
            // FrmPopupConsultaUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(459, 561);
            this.Name = "FrmPopupConsultaUnidadeMedida";
            this.Text = "Consulta Unidade de Medida";
            this.Load += new System.EventHandler(this.FrmPopupConsultaUnidadeMedida_Load);
            this.pnChave.ResumeLayout(false);
            this.pnChave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tboxUnidadeMedida;
        private System.Windows.Forms.Label lblUnidadeMedida;
    }
}
