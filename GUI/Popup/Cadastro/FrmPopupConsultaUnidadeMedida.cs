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
    public partial class FrmPopupConsultaUnidadeMedida : FrmModeloFormularioConsulta
    {
        public FrmPopupConsultaUnidadeMedida(string strConexao, TipoAberturaInterface tpAbertura) : base(strConexao, tpAbertura)
        {
            InitializeComponent();
        }

        private void FrmPopupConsultaUnidadeMedida_Load(object sender, EventArgs e)
        {
            btnRecuperar_Click(sender, e);
            dgvDados.Width = 433;
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            //dgvDados.Columns[0].Visible = false;
            dgvDados.Columns[1].HeaderText = "Unidade de Medida";
            dgvDados.Columns[1].Width = 252;
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(stringConexaoBD);
            BusinessUnidadeMedida BUnidadeMedida = new BusinessUnidadeMedida(conexao);
            dgvDados.DataSource = BUnidadeMedida.Localizar(tboxUnidadeMedida.Text);
        }
    }
}
