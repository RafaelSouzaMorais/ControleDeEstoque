namespace GUI.Modelos
{
    partial class FrmModeloFormularioConsulta
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
            this.pnChave = new System.Windows.Forms.Panel();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.pnGrade = new System.Windows.Forms.Panel();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.pnChave.SuspendLayout();
            this.pnGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnChave
            // 
            this.pnChave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnChave.Controls.Add(this.btnRecuperar);
            this.pnChave.Location = new System.Drawing.Point(12, 12);
            this.pnChave.Name = "pnChave";
            this.pnChave.Size = new System.Drawing.Size(760, 96);
            this.pnChave.TabIndex = 0;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Image = global::GUI.Properties.Resources.icons8_pesquisar_64;
            this.btnRecuperar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecuperar.Location = new System.Drawing.Point(677, 3);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 90);
            this.btnRecuperar.TabIndex = 0;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecuperar.UseVisualStyleBackColor = true;
            // 
            // pnGrade
            // 
            this.pnGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnGrade.Controls.Add(this.dgvDados);
            this.pnGrade.Location = new System.Drawing.Point(12, 118);
            this.pnGrade.Name = "pnGrade";
            this.pnGrade.Size = new System.Drawing.Size(760, 430);
            this.pnGrade.TabIndex = 1;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(3, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(749, 420);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // FrmModeloFormularioConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnGrade);
            this.Controls.Add(this.pnChave);
            this.Name = "FrmModeloFormularioConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo de Formulario de Consulta";
            this.pnChave.ResumeLayout(false);
            this.pnGrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnChave;
        protected System.Windows.Forms.Button btnRecuperar;
        protected System.Windows.Forms.Panel pnGrade;
        public System.Windows.Forms.DataGridView dgvDados;
    }
}