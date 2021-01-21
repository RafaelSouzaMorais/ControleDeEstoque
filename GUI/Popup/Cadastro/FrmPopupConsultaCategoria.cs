using Business;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI.Popup.Cadastro
{
    public partial class FrmPopupConsultaCategoria : GUI.Modelos.FrmModeloFormularioConsulta
    {
        
        public FrmPopupConsultaCategoria()
        {
            InitializeComponent();
        }

        private void FrmPopupConsultaCategoria_Load(object sender, EventArgs e)
        {
            btnRecuperar_Click(sender, e);
            dgvDados.Width = 348;
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            //dgvDados.Columns[0].Visible = false;
            dgvDados.Columns[1].HeaderText = "Produto";
            dgvDados.Columns[1].Width = 252;
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BusinessCategoria BCategoria = new BusinessCategoria(conexao);
            dgvDados.DataSource = BCategoria.Localizar(tboxCategoria.Text);
        }

        

        
    }
}
