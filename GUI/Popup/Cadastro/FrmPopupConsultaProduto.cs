using Business;
using DAL;
using GUI.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Utils.Enums;

namespace GUI.Popup.Cadastro
{
    public partial class FrmPopupConsultaProduto : FrmModeloFormularioConsulta
    {
        public FrmPopupConsultaProduto(string strConexao, TipoAberturaInterface tpAbertura) : base(strConexao, tpAbertura)
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(stringConexaoBD);
            BusinessProduto BCategoria = new BusinessProduto(conexao);
            dgvDados.DataSource = BCategoria.Localizar(tboxProduto.Text);
        }

        private void FrmPopupConsultaProduto_Load(object sender, EventArgs e)
        {
            btnRecuperar_Click(sender, e);
            //dgvDados.Width = 348;
            //dgvDados.Columns[0].HeaderText = "Código";
            //dgvDados.Columns[0].Width = 50;
            ////dgvDados.Columns[0].Visible = false;
            //dgvDados.Columns[1].HeaderText = "Nome";
            //dgvDados.Columns[1].Width = 252;
            //dgvDados.Width = 348;
            //dgvDados.Columns[0].HeaderText = "Descrição";
            //dgvDados.Columns[0].Width = 50;
            ////dgvDados.Columns[0].Visible = false;
            //dgvDados.Columns[1].HeaderText = "Foto";
            //dgvDados.Columns[1].Width = 252;
            //dgvDados.Width = 348;
            //dgvDados.Columns[0].HeaderText = "Valor Pago";
            //dgvDados.Columns[0].Width = 50;
            ////dgvDados.Columns[0].Visible = false;
            //dgvDados.Columns[1].HeaderText = "Valor de Venda(und)";
            //dgvDados.Columns[1].Width = 252;
            //dgvDados.Width = 348;
            //dgvDados.Columns[0].HeaderText = "Código";
            //dgvDados.Columns[0].Width = 50;
            ////dgvDados.Columns[0].Visible = false;
            //dgvDados.Columns[1].HeaderText = "Nome";
            //dgvDados.Columns[1].Width = 252;
        }
    }
}
