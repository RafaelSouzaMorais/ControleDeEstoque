namespace GUI.Movimentação
{
    partial class FrmRegistroEntrada
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
            this.tboxQuantidade = new System.Windows.Forms.TextBox();
            this.tboxValorPago = new System.Windows.Forms.TextBox();
            this.tboxCodigoBarra = new System.Windows.Forms.TextBox();
            this.tboxProduto = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.lvlValorPago = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dtpDataValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.gboxProduto = new System.Windows.Forms.GroupBox();
            this.tboxPctLucro = new System.Windows.Forms.TextBox();
            this.tboxValorVenda = new System.Windows.Forms.TextBox();
            this.lblPctLucro = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.pictImagemProduto = new System.Windows.Forms.PictureBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnBotões.SuspendLayout();
            this.gboxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btnPesquisarProduto);
            this.pnDados.Controls.Add(this.gboxProduto);
            this.pnDados.Controls.Add(this.lblDataValidade);
            this.pnDados.Controls.Add(this.dtpDataValidade);
            this.pnDados.Controls.Add(this.lvlValorPago);
            this.pnDados.Controls.Add(this.lblCodigoBarra);
            this.pnDados.Controls.Add(this.lblQuantidade);
            this.pnDados.Controls.Add(this.tboxCodigoBarra);
            this.pnDados.Controls.Add(this.tboxValorPago);
            this.pnDados.Controls.Add(this.tboxQuantidade);
            this.pnDados.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tboxQuantidade
            // 
            this.tboxQuantidade.Location = new System.Drawing.Point(165, 328);
            this.tboxQuantidade.Name = "tboxQuantidade";
            this.tboxQuantidade.Size = new System.Drawing.Size(135, 31);
            this.tboxQuantidade.TabIndex = 0;
            // 
            // tboxValorPago
            // 
            this.tboxValorPago.Location = new System.Drawing.Point(165, 379);
            this.tboxValorPago.Name = "tboxValorPago";
            this.tboxValorPago.Size = new System.Drawing.Size(135, 31);
            this.tboxValorPago.TabIndex = 1;
            // 
            // tboxCodigoBarra
            // 
            this.tboxCodigoBarra.Location = new System.Drawing.Point(527, 328);
            this.tboxCodigoBarra.Name = "tboxCodigoBarra";
            this.tboxCodigoBarra.Size = new System.Drawing.Size(135, 31);
            this.tboxCodigoBarra.TabIndex = 2;
            // 
            // tboxProduto
            // 
            this.tboxProduto.Location = new System.Drawing.Point(395, 60);
            this.tboxProduto.Name = "tboxProduto";
            this.tboxProduto.Size = new System.Drawing.Size(136, 31);
            this.tboxProduto.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(28, 331);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(131, 23);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.Location = new System.Drawing.Point(335, 331);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(186, 23);
            this.lblCodigoBarra.TabIndex = 5;
            this.lblCodigoBarra.Text = "Código de barra:";
            // 
            // lvlValorPago
            // 
            this.lvlValorPago.AutoSize = true;
            this.lvlValorPago.Location = new System.Drawing.Point(28, 382);
            this.lvlValorPago.Name = "lvlValorPago";
            this.lvlValorPago.Size = new System.Drawing.Size(131, 23);
            this.lvlValorPago.TabIndex = 6;
            this.lvlValorPago.Text = "Valor Pago:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(293, 63);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(98, 23);
            this.lblProduto.TabIndex = 7;
            this.lblProduto.Text = "Produto:";
            // 
            // dtpDataValidade
            // 
            this.dtpDataValidade.CustomFormat = "dd/MM/yyyy";
            this.dtpDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataValidade.Location = new System.Drawing.Point(527, 376);
            this.dtpDataValidade.Name = "dtpDataValidade";
            this.dtpDataValidade.Size = new System.Drawing.Size(135, 31);
            this.dtpDataValidade.TabIndex = 8;
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Location = new System.Drawing.Point(357, 382);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(164, 23);
            this.lblDataValidade.TabIndex = 9;
            this.lblDataValidade.Text = "Data Validade:";
            // 
            // gboxProduto
            // 
            this.gboxProduto.Controls.Add(this.tboxPctLucro);
            this.gboxProduto.Controls.Add(this.tboxValorVenda);
            this.gboxProduto.Controls.Add(this.lblPctLucro);
            this.gboxProduto.Controls.Add(this.lblValorVenda);
            this.gboxProduto.Controls.Add(this.pictImagemProduto);
            this.gboxProduto.Controls.Add(this.tboxProduto);
            this.gboxProduto.Controls.Add(this.lblProduto);
            this.gboxProduto.Location = new System.Drawing.Point(3, 22);
            this.gboxProduto.Name = "gboxProduto";
            this.gboxProduto.Size = new System.Drawing.Size(537, 242);
            this.gboxProduto.TabIndex = 10;
            this.gboxProduto.TabStop = false;
            this.gboxProduto.Text = "Informações do produto";
            // 
            // tboxPctLucro
            // 
            this.tboxPctLucro.Location = new System.Drawing.Point(395, 134);
            this.tboxPctLucro.Name = "tboxPctLucro";
            this.tboxPctLucro.Size = new System.Drawing.Size(136, 31);
            this.tboxPctLucro.TabIndex = 12;
            // 
            // tboxValorVenda
            // 
            this.tboxValorVenda.Location = new System.Drawing.Point(395, 97);
            this.tboxValorVenda.Name = "tboxValorVenda";
            this.tboxValorVenda.Size = new System.Drawing.Size(136, 31);
            this.tboxValorVenda.TabIndex = 11;
            // 
            // lblPctLucro
            // 
            this.lblPctLucro.AutoSize = true;
            this.lblPctLucro.Location = new System.Drawing.Point(313, 137);
            this.lblPctLucro.Name = "lblPctLucro";
            this.lblPctLucro.Size = new System.Drawing.Size(76, 23);
            this.lblPctLucro.TabIndex = 10;
            this.lblPctLucro.Text = "Lucro:";
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(216, 100);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(175, 23);
            this.lblValorVenda.TabIndex = 9;
            this.lblValorVenda.Text = "Valor de Venda:";
            // 
            // pictImagemProduto
            // 
            this.pictImagemProduto.Location = new System.Drawing.Point(24, 30);
            this.pictImagemProduto.Name = "pictImagemProduto";
            this.pictImagemProduto.Size = new System.Drawing.Size(186, 186);
            this.pictImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictImagemProduto.TabIndex = 8;
            this.pictImagemProduto.TabStop = false;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(546, 33);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(141, 65);
            this.btnPesquisarProduto.TabIndex = 11;
            this.btnPesquisarProduto.Text = "Pesquisar Produto";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // FrmRegistroEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "FrmRegistroEntrada";
            this.Text = "Registro de entrada";
            this.Load += new System.EventHandler(this.FrmRegistroEntrada_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotões.ResumeLayout(false);
            this.gboxProduto.ResumeLayout(false);
            this.gboxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImagemProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataValidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lvlValorPago;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox tboxProduto;
        private System.Windows.Forms.TextBox tboxCodigoBarra;
        private System.Windows.Forms.TextBox tboxValorPago;
        private System.Windows.Forms.TextBox tboxQuantidade;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.GroupBox gboxProduto;
        private System.Windows.Forms.PictureBox pictImagemProduto;
        private System.Windows.Forms.TextBox tboxPctLucro;
        private System.Windows.Forms.TextBox tboxValorVenda;
        private System.Windows.Forms.Label lblPctLucro;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Button btnPesquisarProduto;
    }
}
