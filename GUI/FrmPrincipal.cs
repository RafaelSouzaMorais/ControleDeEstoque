using GUI.Cadastro;
using GUI.Movimentação;
using GUI.Popup.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.Modelos.FrmModeloFormularioConsulta;
using static Utils.Enums;

namespace GUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria f = new FrmCategoria();
            f.MdiParent = this;
            f.Show();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaCategoria f = new FrmPopupConsultaCategoria(TipoAberturaInterface.menu);
            f.MdiParent = this;
            f.Show();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubCategoria f = new FrmSubCategoria();
            f.MdiParent = this;
            f.Show();
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaSubCategoria f = new FrmPopupConsultaSubCategoria(TipoAberturaInterface.menu);
            f.MdiParent = this;
            f.Show();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnidadeMedida f = new FrmUnidadeMedida();
            f.MdiParent = this;
            f.Show();
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaUnidadeMedida f = new FrmPopupConsultaUnidadeMedida(TipoAberturaInterface.menu);
            f.MdiParent = this;
            f.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto f = new FrmProduto();
            f.MdiParent = this;
            f.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaProduto f = new FrmPopupConsultaProduto(TipoAberturaInterface.menu);
            f.MdiParent = this;
            f.Show();
        }

        private void registroDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroEntrada f = new FrmRegistroEntrada();
            f.MdiParent = this;
            f.Show();
        }
    }
}
