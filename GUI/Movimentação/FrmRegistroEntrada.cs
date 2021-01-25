using Business;
using DAL;
using GUI.Modelos;
using GUI.Popup.Cadastro;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Utils;
using static Utils.Enums;

namespace GUI.Movimentação
{
    public partial class FrmRegistroEntrada : FrmModeloFormularioCadastro
    {
        private int codProduto = 0;
        private int codEstoque = 0;
        public FrmRegistroEntrada(string strConexao) : base(strConexao)
        {
            InitializeComponent();
        }

        private void FrmRegistroEntrada_Load(object sender, EventArgs e)
        {
            RegistrarCampoMonetario(tboxValorPago);
            gboxProduto.Enabled = false;
            dtpDataValidade.Value = DateTime.Now;
            RegistrarCampoNumerico(tboxQuantidade);
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaProduto frm = new FrmPopupConsultaProduto(stringConexaoBD, TipoAberturaInterface.search);
            frm.ShowDialog();
            if (frm.retorno.Count > 0)
            {
                DALConexao conexao = new DALConexao(stringConexaoBD);
                BusinessProduto BProdutos = new BusinessProduto(conexao);
                DescarregaModeloProdutoInForm(BProdutos.CarregaModeloProduto(Convert.ToInt32(frm.retorno["pro_cod"])));
                PreencheCamposLucro();
            }
            else
            {
                //emitir msg
            }
            frm.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Não será possível alterar os dados de Registro de Entrada após a inserção. Confirma os dados que estão sendo inseridos?", "Aviso", MessageBoxButtons.YesNo);
            if (resposta.ToString().Equals("Yes"))
            {

                try
                {
                    DALConexao conexao = new DALConexao(stringConexaoBD);
                    BusinessRegistroEntrada BRegistroEntrada = new BusinessRegistroEntrada(conexao);
                    BusinessEstoque BEstoque = new BusinessEstoque(conexao);
                    ModelRegistroEntrada modeloRegistroEntrada;
                    ModelEstoque modeloEstoque;

                    if (operacao.Equals(TipoOperacaoRegistro.Inserir))
                    {
                        modeloEstoque = CarregaModeloEstoqueByForm();
                        BEstoque.Incluir(modeloEstoque);
                        codEstoque = modeloEstoque.EstqCod;

                        modeloRegistroEntrada = CarregaModeloRegistroEntradaByForm();
                        BRegistroEntrada.Incluir(modeloRegistroEntrada);

                        MessageBox.Show("Inserção feita com sucesso!");
                        //tbox .Text = Convert.ToString(modelo.RgeCod);
                    }
                    LimparFormulario();
                    ControleBotoes("I");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void DescarregaModeloProdutoInForm(ModelProduto modelo)
        {
            tboxProduto.Text = Convert.ToString(modelo.ProNome);

            tboxValorVenda.Text = Convert.ToString(modelo.ProValorVenda);
            utilitariosForms.ConsistenciaCamposMonetarios(tboxValorVenda);
            codProduto = modelo.ProCod;
            try
            {
                MemoryStream ms = new MemoryStream(modelo.ProFoto);
                pictImagemProduto.Image = Image.FromStream(ms);
            }
            catch { }
        }

        private ModelRegistroEntrada CarregaModeloRegistroEntradaByForm()
        {
            ModelRegistroEntrada modelo = new ModelRegistroEntrada();

            modelo.RgeCodEstoque = codEstoque;

            modelo.RgeQuantidade = Convert.ToDouble(tboxQuantidade.Text);
            if (string.IsNullOrEmpty(utilitariosForms.RemoverStringCamposMonetarios(tboxValorPago.Text).Trim()))
            {
                modelo.RgeValorPago = 0;
            }
            else
            {
                modelo.RgeValorPago = Convert.ToDouble(utilitariosForms.RemoverStringCamposMonetarios(tboxValorPago.Text));
            }
            return modelo;

        }

        private ModelEstoque CarregaModeloEstoqueByForm()
        {
            ModelEstoque modelo = new ModelEstoque();

            modelo.EstqCodProduto = codProduto;
            modelo.EstqQuantidade = Convert.ToDouble(tboxQuantidade.Text);
            modelo.EstqCodigoBarra = tboxCodigoBarra.Text;
            modelo.EstqDataValidade = dtpDataValidade.Value;
            return modelo;
        }

        public override void LimparFormulario()
        {
            base.LimparFormulario();
            tboxProduto.Text = "";
            tboxValorVenda.Text = "";
            tboxLucroUnitario.Text = "";
            tboxLucroTotal.Text = "";
            tboxQuantidade.Text = "";
            tboxValorPago.Text = "";
            tboxCodigoBarra.Text = "";
            dtpDataValidade.Value = DateTime.Now;
            pictImagemProduto.Image = null;

        }

        public override void EventLeaveCampoNumerico(TextBox tboxValor)
        {
            base.EventLeaveCampoNumerico(tboxValor);
            if (tboxValor.Name.Equals("tboxQuantidade"))
            {
                PreencheCamposLucro();
            }
        }
        public override void EventLeaveCampoMonetario(TextBox tboxValor)
        {
            base.EventLeaveCampoMonetario(tboxValor);
            if (tboxValor.Name.Equals("tboxValorPago"))
            {
                PreencheCamposLucro();
            }

        }
        private void PreencheCamposLucro()
        {
            Double valorPago, valorVenda, quantidade;
            Double lucroUnitario, lucroTotal;
            if (string.IsNullOrEmpty(utilitariosForms.RemoverStringCamposMonetarios(tboxValorPago.Text).Trim()))
            {
                valorPago = 0;
            }
            else
            {
                valorPago = Convert.ToDouble(utilitariosForms.RemoverStringCamposMonetarios(tboxValorPago.Text));
            }
            if (string.IsNullOrEmpty(utilitariosForms.RemoverStringCamposMonetarios(tboxValorVenda.Text).Trim()))
            {
                valorVenda = 0;
            }
            else
            {
                valorVenda = Convert.ToDouble(utilitariosForms.RemoverStringCamposMonetarios(tboxValorVenda.Text));
            }
            quantidade = string.IsNullOrEmpty(tboxQuantidade.Text) ? 0 : Convert.ToDouble(tboxQuantidade.Text);
            lucroTotal = (valorVenda - (valorPago / quantidade)) * quantidade;
            lucroUnitario = (valorVenda - (valorPago / quantidade));
            tboxLucroTotal.Text = Convert.ToString(lucroTotal);
            tboxLucroUnitario.Text = Convert.ToString(lucroUnitario);
            utilitariosForms.ConsistenciaCamposMonetarios(tboxLucroTotal);
            utilitariosForms.ConsistenciaCamposMonetarios(tboxLucroUnitario);
        }
    }
}
