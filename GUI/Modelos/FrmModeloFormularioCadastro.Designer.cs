namespace GUI.Modelos
{
    partial class FrmModeloFormularioCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModeloFormularioCadastro));
            this.pnDados = new System.Windows.Forms.Panel();
            this.pnBotões = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.pnBotões.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDados.Location = new System.Drawing.Point(12, 12);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(760, 435);
            this.pnDados.TabIndex = 0;
            // 
            // pnBotões
            // 
            this.pnBotões.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBotões.Controls.Add(this.btnCancelar);
            this.pnBotões.Controls.Add(this.btnSalvar);
            this.pnBotões.Controls.Add(this.btnExcluir);
            this.pnBotões.Controls.Add(this.btnRecuperar);
            this.pnBotões.Controls.Add(this.btnAlterar);
            this.pnBotões.Controls.Add(this.btnInserir);
            this.pnBotões.Location = new System.Drawing.Point(12, 453);
            this.pnBotões.Name = "pnBotões";
            this.pnBotões.Size = new System.Drawing.Size(760, 96);
            this.pnBotões.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(682, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 90);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(601, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 90);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(246, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 90);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecuperar.Image")));
            this.btnRecuperar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecuperar.Location = new System.Drawing.Point(165, 2);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 90);
            this.btnRecuperar.TabIndex = 2;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(84, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 90);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Editar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserir.Location = new System.Drawing.Point(3, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 90);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir Novo";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // FrmModeloFormularioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnBotões);
            this.Controls.Add(this.pnDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModeloFormularioCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo de Formulário de Cadastro";
            this.Load += new System.EventHandler(this.FrmModeloFormularioCadastro_Load);
            this.pnBotões.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnDados;
        protected System.Windows.Forms.Panel pnBotões;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnExcluir;
        protected System.Windows.Forms.Button btnRecuperar;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnInserir;
    }
}