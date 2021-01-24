using Business;
using DAL;
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
using static Utils.Enums;

namespace GUI.Movimentação
{
    public partial class FrmRegistroEntrada : GUI.Modelos.FrmModeloFormularioCadastro
    {
        public FrmRegistroEntrada(string strConexao) : base(strConexao)
        {
            InitializeComponent();
        }

        private void FrmRegistroEntrada_Load(object sender, EventArgs e)
        {
            RegistrarCampoMonetario(tboxValorPago);
            gboxProduto.Enabled = false;
            dtpDataValidade.Value = DateTime.Now;
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
            }
            else
            {
                //emitir msg
            }
            frm.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(stringConexaoBD);
                BusinessRegistroEntrada BRegistroEntrada = new BusinessRegistroEntrada(conexao);
                BusinessEstoque BEstoque = new BusinessEstoque(conexao);
                ModelRegistroEntrada modeloRegistroEntrada = CarregaModeloRegistroEntradaByForm();
                ModelEstoque modeloEstoque = CarregaModeloEstoqueByForm();

                if (operacao.Equals(TipoOperacaoRegistro.Inserir))
                {
                    BEstoque.Incluir(modeloEstoque);
                    modeloRegistroEntrada.RgeCodEstoque = modeloEstoque.EstqCod;
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

        private void DescarregaModeloProdutoInForm(ModelProduto modelo)
        {
            tboxProduto.Text = Convert.ToString(modelo.ProNome);

            tboxValorVenda.Text = Convert.ToString(modelo.ProValorVenda);
            utilitariosForms.ConsistenciaCamposMonetarios(tboxValorVenda);

            try
            {
                MemoryStream ms = new MemoryStream(modelo.ProFoto);
                pictImagemProduto.Image = Image.FromStream(ms);
            }
            catch { }
        }       

        private ModelRegistroEntrada CarregaModeloRegistroEntradaByForm()
        {
            throw new NotImplementedException();
        }
        
        private ModelEstoque CarregaModeloEstoqueByForm()
        {
            throw new NotImplementedException();
        }
    }
}
