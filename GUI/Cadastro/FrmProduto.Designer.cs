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
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblUnidadeMedida = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblSubCategoria = new System.Windows.Forms.Label();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.tboxNome = new System.Windows.Forms.TextBox();
            this.tboxDescricao = new System.Windows.Forms.TextBox();
            this.cboxUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.cboxSubCategoria = new System.Windows.Forms.ComboBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pnFoto = new System.Windows.Forms.Panel();
            this.pictImagemProduto = new System.Windows.Forms.PictureBox();
            this.btnImportaImagem = new System.Windows.Forms.Button();
            this.btnExcluiImagem = new System.Windows.Forms.Button();
            this.tboxValorVenda = new System.Windows.Forms.TextBox();
            this.pnDados.SuspendLayout();
            this.pnBotões.SuspendLayout();
            this.pnFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.tboxValorVenda);
            this.pnDados.Controls.Add(this.btnExcluiImagem);
            this.pnDados.Controls.Add(this.btnImportaImagem);
            this.pnDados.Controls.Add(this.pnFoto);
            this.pnDados.Controls.Add(this.lblFoto);
            this.pnDados.Controls.Add(this.cboxSubCategoria);
            this.pnDados.Controls.Add(this.cboxCategoria);
            this.pnDados.Controls.Add(this.cboxUnidadeMedida);
            this.pnDados.Controls.Add(this.tboxDescricao);
            this.pnDados.Controls.Add(this.tboxNome);
            this.pnDados.Controls.Add(this.tboxCodigo);
            this.pnDados.Controls.Add(this.lblSubCategoria);
            this.pnDados.Controls.Add(this.lblCategoria);
            this.pnDados.Controls.Add(this.lblUnidadeMedida);
            this.pnDados.Controls.Add(this.lblValorVenda);
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
            this.lblCodigo.Location = new System.Drawing.Point(120, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 23);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(142, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(65, 23);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(87, 102);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(120, 23);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVenda.Location = new System.Drawing.Point(32, 373);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(175, 23);
            this.lblValorVenda.TabIndex = 5;
            this.lblValorVenda.Text = "Valor de Venda:";
            // 
            // lblUnidadeMedida
            // 
            this.lblUnidadeMedida.AutoSize = true;
            this.lblUnidadeMedida.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeMedida.Location = new System.Drawing.Point(-1, 222);
            this.lblUnidadeMedida.Name = "lblUnidadeMedida";
            this.lblUnidadeMedida.Size = new System.Drawing.Size(208, 23);
            this.lblUnidadeMedida.TabIndex = 6;
            this.lblUnidadeMedida.Text = "Unidade de Medida:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(87, 267);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(120, 23);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblSubCategoria
            // 
            this.lblSubCategoria.AutoSize = true;
            this.lblSubCategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategoria.Location = new System.Drawing.Point(54, 327);
            this.lblSubCategoria.Name = "lblSubCategoria";
            this.lblSubCategoria.Size = new System.Drawing.Size(153, 23);
            this.lblSubCategoria.TabIndex = 8;
            this.lblSubCategoria.Text = "Subcategoria:";
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Enabled = false;
            this.tboxCodigo.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodigo.Location = new System.Drawing.Point(213, 7);
            this.tboxCodigo.MaxLength = 95;
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(100, 31);
            this.tboxCodigo.TabIndex = 1;
            // 
            // tboxNome
            // 
            this.tboxNome.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNome.Location = new System.Drawing.Point(213, 52);
            this.tboxNome.MaxLength = 95;
            this.tboxNome.Name = "tboxNome";
            this.tboxNome.Size = new System.Drawing.Size(202, 31);
            this.tboxNome.TabIndex = 2;
            // 
            // tboxDescricao
            // 
            this.tboxDescricao.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDescricao.Location = new System.Drawing.Point(213, 99);
            this.tboxDescricao.Multiline = true;
            this.tboxDescricao.Name = "tboxDescricao";
            this.tboxDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tboxDescricao.Size = new System.Drawing.Size(202, 104);
            this.tboxDescricao.TabIndex = 3;
            // 
            // cboxUnidadeMedida
            // 
            this.cboxUnidadeMedida.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxUnidadeMedida.FormattingEnabled = true;
            this.cboxUnidadeMedida.Location = new System.Drawing.Point(213, 219);
            this.cboxUnidadeMedida.Name = "cboxUnidadeMedida";
            this.cboxUnidadeMedida.Size = new System.Drawing.Size(165, 31);
            this.cboxUnidadeMedida.Sorted = true;
            this.cboxUnidadeMedida.TabIndex = 8;
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(213, 264);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(165, 31);
            this.cboxCategoria.Sorted = true;
            this.cboxCategoria.TabIndex = 9;
            this.cboxCategoria.SelectedIndexChanged += new System.EventHandler(this.cboxCategoria_SelectedIndexChanged);
            // 
            // cboxSubCategoria
            // 
            this.cboxSubCategoria.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSubCategoria.FormattingEnabled = true;
            this.cboxSubCategoria.Location = new System.Drawing.Point(213, 324);
            this.cboxSubCategoria.Name = "cboxSubCategoria";
            this.cboxSubCategoria.Size = new System.Drawing.Size(165, 31);
            this.cboxSubCategoria.Sorted = true;
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
            this.btnImportaImagem.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnExcluiImagem.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // tboxValorVenda
            // 
            this.tboxValorVenda.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxValorVenda.Location = new System.Drawing.Point(213, 370);
            this.tboxValorVenda.MaxLength = 15;
            this.tboxValorVenda.Name = "tboxValorVenda";
            this.tboxValorVenda.Size = new System.Drawing.Size(100, 31);
            this.tboxValorVenda.TabIndex = 6;
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
        private System.Windows.Forms.TextBox tboxDescricao;
        private System.Windows.Forms.TextBox tboxNome;
        private System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.Label lblSubCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblUnidadeMedida;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnExcluiImagem;
        private System.Windows.Forms.Button btnImportaImagem;
        private System.Windows.Forms.PictureBox pictImagemProduto;
        private System.Windows.Forms.TextBox tboxValorVenda;
    }
}
