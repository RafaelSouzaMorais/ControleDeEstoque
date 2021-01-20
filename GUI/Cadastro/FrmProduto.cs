using System;
using System.Windows.Forms;

namespace GUI.Cadastro
{
    public partial class FrmProduto : GUI.Modelos.FrmModeloFormularioCadastro
    {
        private string foto = string.Empty;
        public FrmProduto()
        {
            InitializeComponent();
        }

        public override void PosInserir()
        {
            base.PosInserir();
            tboxNome.Focus();
        }

        private void btnImportaImagem_Click(object sender, EventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            RegistrarCampoMonetario(tboxValorVenda);
            RegistrarCampoMonetario(tboxValorPago);
        } 
    }
}
