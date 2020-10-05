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
    public partial class FrmPopupConsultaSubCategoria : GUI.Modelos.FrmModeloFormularioConsulta
    {
        public FrmPopupConsultaSubCategoria()
        {
            InitializeComponent();
        }

        private void FrmPopupConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            btnRecuperar_Click(sender, e);
            dgvDados.Width = 450;
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            //dgvDados.Columns[0].Visible = false;
            dgvDados.Columns[1].HeaderText = "SubCategoria";
            dgvDados.Columns[1].Width = 100;
            dgvDados.Columns[2].Visible = false;
            dgvDados.Columns[3].HeaderText = "Categoria";
            dgvDados.Columns[3].Width = 100;
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BusinessSubCategoria BSubcategoria = new BusinessSubCategoria(conexao);
            dgvDados.DataSource = BSubcategoria.Localizar(tboxSubcategoria.Text);
        }
    }
}
