namespace GUI.Cadastro
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblUnidadeMedida = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblSubCategoria = new System.Windows.Forms.Label();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.tboxNome = new System.Windows.Forms.TextBox();
            this.tboxDescricao = new System.Windows.Forms.TextBox();
            this.tboxQuantidade = new System.Windows.Forms.TextBox();
            this.cboxUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.cboxSubCategoria = new System.Windows.Forms.ComboBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pnFoto = new System.Windows.Forms.Panel();
            this.pictImagemProduto = new System.Windows.Forms.PictureBox();
            this.btnImportaImagem = new System.Windows.Forms.Button();
            this.btnExcluiImagem = new System.Windows.Forms.Button();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.tboxDataValidade = new System.Windows.Forms.MaskedTextBox();
            this.tboxValorPago = new System.Windows.Forms.TextBox();
            this.tboxValorVenda = new System.Windows.Forms.TextBox();
            this.tboxCodigoBarra = new System.Windows.Forms.TextBox();
            this.pnDados.SuspendLayout();
            this.pnBotões.SuspendLayout();
            this.pnFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.tboxCodigoBarra);
            this.pnDados.Controls.Add(this.tboxValorVenda);
            this.pnDados.Controls.Add(this.tboxValorPago);
            this.pnDados.Controls.Add(this.tboxDataValidade);
            this.pnDados.Controls.Add(this.lblCodigoBarra);
            this.pnDados.Controls.Add(this.lblDataValidade);
            this.pnDados.Controls.Add(this.btnExcluiImagem);
            this.pnDados.Controls.Add(this.btnImportaImagem);
            this.pnDados.Controls.Add(this.pnFoto);
            this.pnDados.Controls.Add(this.lblFoto);
            this.pnDados.Controls.Add(this.cboxSubCategoria);
            this.pnDados.Controls.Add(this.cboxCategoria);
            this.pnDados.Controls.Add(this.cboxUnidadeMedida);
            this.pnDados.Controls.Add(this.tboxQuantidade);
            this.pnDados.Controls.Add(this.tboxDescricao);
            this.pnDados.Controls.Add(this.tboxNome);
            this.pnDados.Controls.Add(this.tboxCodigo);
            this.pnDados.Controls.Add(this.lblSubCategoria);
            this.pnDados.Controls.Add(this.lblCategoria);
            this.pnDados.Controls.Add(this.lblUnidadeMedida);
            this.pnDados.Controls.Add(this.lblValorVenda);
            this.pnDados.Controls.Add(this.lblValorPago);
            this.pnDados.Controls.Add(this.lblQuantidade);
            this.pnDados.Controls.Add(this.lblDescricao);
            this.pnDados.Controls.Add(this.lblNome);
            this.pnDados.Controls.Add(this.lblCodigo);
            this.pnDados.Size = new System.Drawing.Size(708, 405);
            // 
            // pnBotões
            // 
            this.pnBotões.Location = new System.Drawing.Point(12, 423);
            this.pnBotões.Size = new System.Drawing.Size(708, 96);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(625, 2);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(544, 2);
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
            this.lblCodigo.Location = new System.Drawing.Point(102, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 23);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(124, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(65, 23);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(69, 102);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(120, 23);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(58, 226);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(131, 23);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.Location = new System.Drawing.Point(58, 271);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(131, 23);
            this.lblValorPago.TabIndex = 4;
            this.lblValorPago.Text = "Valor Pago:";
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVenda.Location = new System.Drawing.Point(14, 316);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(175, 23);
            this.lblValorVenda.TabIndex = 5;
            this.lblValorVenda.Text = "Valor de Venda:";
            // 
            // lblUnidadeMedida
            // 
            this.lblUnidadeMedida.AutoSize = true;
            this.lblUnidadeMedida.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeMedida.Location = new System.Drawing.Point(311, 226);
            this.lblUnidadeMedida.Name = "lblUnidadeMedida";
            this.lblUnidadeMedida.Size = new System.Drawing.Size(208, 23);
            this.lblUnidadeMedida.TabIndex = 6;
            this.lblUnidadeMedida.Text = "Unidade de Medida:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(399, 271);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(120, 23);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblSubCategoria
            // 
            this.lblSubCategoria.AutoSize = true;
            this.lblSubCategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategoria.Location = new System.Drawing.Point(366, 316);
            this.lblSubCategoria.Name = "lblSubCategoria";
            this.lblSubCategoria.Size = new System.Drawing.Size(153, 23);
            this.lblSubCategoria.TabIndex = 8;
            this.lblSubCategoria.Text = "Subcategoria:";
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Enabled = false;
            this.tboxCodigo.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigo.Location = new System.Drawing.Point(195, 7);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(100, 31);
            this.tboxCodigo.TabIndex = 1;
            // 
            // tboxNome
            // 
            this.tboxNome.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNome.Location = new System.Drawing.Point(195, 52);
            this.tboxNome.Name = "tboxNome";
            this.tboxNome.Size = new System.Drawing.Size(202, 31);
            this.tboxNome.TabIndex = 2;
            // 
            // tboxDescricao
            // 
            this.tboxDescricao.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDescricao.Location = new System.Drawing.Point(195, 99);
            this.tboxDescricao.Multiline = true;
            this.tboxDescricao.Name = "tboxDescricao";
            this.tboxDescricao.Size = new System.Drawing.Size(202, 104);
            this.tboxDescricao.TabIndex = 3;
            // 
            // tboxQuantidade
            // 
            this.tboxQuantidade.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxQuantidade.Location = new System.Drawing.Point(195, 218);
            this.tboxQuantidade.Name = "tboxQuantidade";
            this.tboxQuantidade.Size = new System.Drawing.Size(100, 31);
            this.tboxQuantidade.TabIndex = 4;
            // 
            // cboxUnidadeMedida
            // 
            this.cboxUnidadeMedida.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxUnidadeMedida.FormattingEnabled = true;
            this.cboxUnidadeMedida.Location = new System.Drawing.Point(525, 218);
            this.cboxUnidadeMedida.Name = "cboxUnidadeMedida";
            this.cboxUnidadeMedida.Size = new System.Drawing.Size(165, 31);
            this.cboxUnidadeMedida.TabIndex = 8;
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(525, 263);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(165, 31);
            this.cboxCategoria.TabIndex = 9;
            this.cboxCategoria.SelectedIndexChanged += new System.EventHandler(this.cboxCategoria_SelectedIndexChanged);
            // 
            // cboxSubCategoria
            // 
            this.cboxSubCategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSubCategoria.FormattingEnabled = true;
            this.cboxSubCategoria.Location = new System.Drawing.Point(524, 308);
            this.cboxSubCategoria.Name = "cboxSubCategoria";
            this.cboxSubCategoria.Size = new System.Drawing.Size(165, 31);
            this.cboxSubCategoria.TabIndex = 10;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(431, 15);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(65, 23);
            this.lblFoto.TabIndex = 18;
            this.lblFoto.Text = "Foto:";
            // 
            // pnFoto
            // 
            this.pnFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFoto.Controls.Add(this.pictImagemProduto);
            this.pnFoto.Location = new System.Drawing.Point(502, 15);
            this.pnFoto.Name = "pnFoto";
            this.pnFoto.Size = new System.Drawing.Size(188, 188);
            this.pnFoto.TabIndex = 19;
            // 
            // pictImagemProduto
            // 
            this.pictImagemProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictImagemProduto.Location = new System.Drawing.Point(0, 0);
            this.pictImagemProduto.Name = "pictImagemProduto";
            this.pictImagemProduto.Size = new System.Drawing.Size(186, 186);
            this.pictImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictImagemProduto.TabIndex = 0;
            this.pictImagemProduto.TabStop = false;
            // 
            // btnImportaImagem
            // 
            this.btnImportaImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnImportaImagem.Image")));
            this.btnImportaImagem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportaImagem.Location = new System.Drawing.Point(435, 41);
            this.btnImportaImagem.Name = "btnImportaImagem";
            this.btnImportaImagem.Size = new System.Drawing.Size(61, 65);
            this.btnImportaImagem.TabIndex = 12;
            this.btnImportaImagem.Text = "Inserir Imagem";
            this.btnImportaImagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImportaImagem.UseVisualStyleBackColor = true;
            this.btnImportaImagem.Click += new System.EventHandler(this.btnImportaImagem_Click);
            // 
            // btnExcluiImagem
            // 
            this.btnExcluiImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiImagem.Image")));
            this.btnExcluiImagem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluiImagem.Location = new System.Drawing.Point(435, 112);
            this.btnExcluiImagem.Name = "btnExcluiImagem";
            this.btnExcluiImagem.Size = new System.Drawing.Size(61, 65);
            this.btnExcluiImagem.TabIndex = 21;
            this.btnExcluiImagem.Text = "Remover Imagem";
            this.btnExcluiImagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluiImagem.UseVisualStyleBackColor = true;
            this.btnExcluiImagem.Click += new System.EventHandler(this.btnExcluiImagem_Click);
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.Location = new System.Drawing.Point(300, 359);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(197, 23);
            this.lblDataValidade.TabIndex = 22;
            this.lblDataValidade.Text = "Data de Validade:";
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarra.Location = new System.Drawing.Point(3, 359);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(186, 23);
            this.lblCodigoBarra.TabIndex = 23;
            this.lblCodigoBarra.Text = "Código de barra:";
            // 
            // tboxDataValidade
            // 
            this.tboxDataValidade.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDataValidade.Location = new System.Drawing.Point(525, 351);
            this.tboxDataValidade.Mask = "00/00/0000";
            this.tboxDataValidade.Name = "tboxDataValidade";
            this.tboxDataValidade.Size = new System.Drawing.Size(100, 31);
            this.tboxDataValidade.TabIndex = 11;
            this.tboxDataValidade.ValidatingType = typeof(System.DateTime);
            // 
            // tboxValorPago
            // 
            this.tboxValorPago.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxValorPago.Location = new System.Drawing.Point(195, 263);
            this.tboxValorPago.Name = "tboxValorPago";
            this.tboxValorPago.Size = new System.Drawing.Size(100, 31);
            this.tboxValorPago.TabIndex = 5;
            // 
            // tboxValorVenda
            // 
            this.tboxValorVenda.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxValorVenda.Location = new System.Drawing.Point(195, 308);
            this.tboxValorVenda.Name = "tboxValorVenda";
            this.tboxValorVenda.Size = new System.Drawing.Size(100, 31);
            this.tboxValorVenda.TabIndex = 6;
            // 
            // tboxCodigoBarra
            // 
            this.tboxCodigoBarra.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigoBarra.Location = new System.Drawing.Point(195, 351);
            this.tboxCodigoBarra.Name = "tboxCodigoBarra";
            this.tboxCodigoBarra.Size = new System.Drawing.Size(100, 31);
            this.tboxCodigoBarra.TabIndex = 7;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(730, 524);
            this.Name = "FrmProduto";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotões.ResumeLayout(false);
            this.pnFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictImagemProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.ComboBox cboxSubCategoria;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.ComboBox cboxUnidadeMedida;
        private System.Windows.Forms.TextBox tboxQuantidade;
        private System.Windows.Forms.TextBox tboxDescricao;
        private System.Windows.Forms.TextBox tboxNome;
        private System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.Label lblSubCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblUnidadeMedida;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnExcluiImagem;
        private System.Windows.Forms.Button btnImportaImagem;
        private System.Windows.Forms.PictureBox pictImagemProduto;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.TextBox tboxCodigoBarra;
        private System.Windows.Forms.TextBox tboxValorVenda;
        private System.Windows.Forms.TextBox tboxValorPago;
        private System.Windows.Forms.MaskedTextBox tboxDataValidade;
    }
}
