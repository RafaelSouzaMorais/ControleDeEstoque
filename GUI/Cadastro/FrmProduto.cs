using Business;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;
using static Utils.Enums;

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

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            RegistrarCampoMonetario(tboxValorVenda);
            RegistrarCampoMonetario(tboxValorPago);
            RegistrarComboBoxUnidadeMedida();
            RegistrarComboBoxCategoria();
            RegistrarComboBoxSubCategoria();
        }
        private void RegistrarComboBoxUnidadeMedida()
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BusinessUnidadeMedida BUnidadeMedida = new BusinessUnidadeMedida(conexao);
            cboxUnidadeMedida.DataSource = BUnidadeMedida.Localizar("");
            cboxUnidadeMedida.DisplayMember = "umed_nome";
            cboxUnidadeMedida.ValueMember = "umed_cod";
        }
        private void RegistrarComboBoxCategoria()
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BusinessCategoria BCategoria = new BusinessCategoria(conexao);
            cboxCategoria.DataSource = BCategoria.Localizar("");
            cboxCategoria.DisplayMember = "cat_nome";
            cboxCategoria.ValueMember = "cat_cod";
        }
        private void RegistrarComboBoxSubCategoria()
        {
            int codCategoria;
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BusinessSubCategoria BSubCategoria = new BusinessSubCategoria(conexao);
            try
            {
                codCategoria = Convert.ToInt32(cboxCategoria.SelectedValue);
            }
            catch
            {
                codCategoria = 0;
            }
            cboxSubCategoria.ResetText();
            cboxSubCategoria.DataSource = BSubCategoria.LocalizarPorCategoria(codCategoria);
            cboxSubCategoria.DisplayMember = "scat_nome";
            cboxSubCategoria.ValueMember = "scat_cod";
        }
        private void cboxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrarComboBoxSubCategoria();
        }
        private void btnImportaImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImagem = new OpenFileDialog();
            ofdImagem.ShowDialog();
            if(!string.IsNullOrEmpty(ofdImagem.FileName))
            {
                foto = ofdImagem.FileName;
                pictImagemProduto.Load(foto);
            }
        }
        private void btnExcluiImagem_Click(object sender, EventArgs e)
        {
            //ShowDialog()
            LimparFoto(pictImagemProduto);
        }
        public override void LimparFormulario()
        {
            base.LimparFormulario();
            tboxCodigo.Clear();
            tboxNome.Clear();
            tboxDescricao.Clear();
            tboxQuantidade.Clear();
            tboxValorPago.Clear();
            tboxValorVenda.Clear();
            tboxCodigoBarra.Clear();
            tboxDataValidade.Clear();
            LimparFoto(pictImagemProduto);
        }
        public void LimparFoto(PictureBox pictImg)
        {
            foto = "";
            pictImg.Image = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BusinessProduto BProduto = new BusinessProduto(conexao);
                ModeloProduto modelo = new ModeloProduto();

                modelo.ProNome = Convert.ToString(tboxNome.Text);
                modelo.ProDescricao = Convert.ToString(tboxDescricao.Text);
                modelo.ProValorPago = Convert.ToDouble(utilitariosForms.RemoverStringCamposMonetarios(tboxValorPago.Text));
                modelo.ProValorVenda = Convert.ToDouble(utilitariosForms.RemoverStringCamposMonetarios(tboxValorVenda.Text));
                modelo.ProQtde = Convert.ToDouble(tboxQuantidade.Text);
                modelo.ProCodUnidadeMedida = Convert.ToInt32(cboxUnidadeMedida.SelectedValue);
                modelo.ProCodSubCategoria = Convert.ToInt32(cboxSubCategoria.SelectedValue);
                modelo.ProCodCategoria = Convert.ToInt32(cboxCategoria.SelectedValue);
                modelo.ProCodigoBarra = Convert.ToString(tboxCodigoBarra.Text);
                modelo.CarregaImagem(foto);
                //modelo.ProDataValidade = Convert.ToDateTime(tboxDataValidade);

                if (operacao.Equals(TipoOperacaoRegistro.Inserir))
                {
                    BProduto.Incluir(modelo);
                    MessageBox.Show("Inserção feita com sucesso!");
                    tboxCodigo.Text = Convert.ToString(modelo.ProCod);
                }
                else
                {
                    modelo.ProCod = Convert.ToInt32(tboxCodigo.Text);
                    BProduto.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                LimparFormulario();
                ControleBotoes("IR");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (resposta.ToString().Equals("Yes"))
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BusinessProduto BProduto= new BusinessProduto(conexao);
                    ModeloProduto modelo = new ModeloProduto();
                    modelo.ProCod = Convert.ToInt32(tboxCodigo.Text);
                    BProduto.Excluir(modelo);
                    MessageBox.Show("Exclusão feita com sucesso!");
                    ControleBotoes("IR");
                    LimparFormulario();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na exclusão do Produto: " + erro.Message);
                ControleBotoes("AEC");
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            /*FrmPopupConsultaCategoria frm = new FrmPopupConsultaCategoria();
            frm.ShowDialog();
            if (frm.retorno.Count > 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BusinessCategoria BCategoria = new BusinessCategoria(conexao);
                ModeloCategoria modelo = BCategoria.CarregaModeloCategoria(Convert.ToInt32(frm.retorno["Código"]));
                tboxCodigo.Text = Convert.ToString(modelo.CatCod);
                tboxNome.Text = modelo.CatNome;
                ControleBotoes("AEC");
            }
            else
            {
                ControleBotoes("IR");
                LimparFormulario();
            }
            frm.Dispose();*/
        }
    }
}
