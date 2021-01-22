using Business;
using DAL;
using GUI.Popup.Cadastro;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Utils.Enums;

namespace GUI.Cadastro
{
    public partial class FrmSubCategoria : GUI.Modelos.FrmModeloFormularioCadastro
    {
        public FrmSubCategoria()
        {
            InitializeComponent();
        }

        private void FrmSubCategoria_Load(object sender, EventArgs e)
        {
            PopulaComboBox();
        }

        private void PopulaComboBox()
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BusinessCategoria BCategoria = new BusinessCategoria(conexao);
            cboxCatCod.DataSource = BCategoria.Localizar("");
            cboxCatCod.DisplayMember = "cat_nome";
            cboxCatCod.ValueMember = "cat_cod";
        }

        public override void PosInserir()
        {
            base.PosInserir();
            tboxNomeSubCat.Focus();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaSubCategoria frm = new FrmPopupConsultaSubCategoria(TipoAberturaInterface.search);
            frm.ShowDialog();
            if (frm.retorno.Count > 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BusinessSubCategoria BSubcategoria = new BusinessSubCategoria(conexao);
                ModelSubCategoria modelo = BSubcategoria.CarregaModeloSubCategoria(Convert.ToInt32(frm.retorno["Código"]));
                tboxCodigo.Text = Convert.ToString(modelo.ScatCod);
                tboxNomeSubCat.Text = modelo.ScatNome;
                cboxCatCod.SelectedValue = modelo.ScatCodCategoria;
                ControleBotoes("AEC");
            }
            else
            {
                ControleBotoes("IR");
                LimparFormulario();
            }
            frm.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (resposta.ToString().Equals("Yes"))
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BusinessSubCategoria BSubCategoria = new BusinessSubCategoria(conexao);
                    ModelSubCategoria modelo = new ModelSubCategoria();
                    modelo.ScatCod = Convert.ToInt32(tboxCodigo);
                    modelo.ScatNome = Convert.ToString(tboxNomeSubCat);
                    modelo.ScatCodCategoria = Convert.ToInt32(cboxCatCod.SelectedValue);
                    BSubCategoria.Excluir(modelo);
                    MessageBox.Show("Exclusão feita com sucesso!");
                    ControleBotoes("IR");
                    LimparFormulario();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na exclusão da categoria: " + erro.Message);
                ControleBotoes("AEC");
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BusinessSubCategoria BSubCategoria = new BusinessSubCategoria(conexao);
                ModelSubCategoria modelo = new ModelSubCategoria();
                modelo.ScatNome = Convert.ToString(tboxNomeSubCat.Text);
                modelo.ScatCodCategoria = Convert.ToInt32(cboxCatCod.SelectedValue);

                if (operacao.Equals(TipoOperacaoRegistro.Inserir))
                {
                    BSubCategoria.Incluir(modelo);
                    MessageBox.Show("Inserção feita com sucesso!");
                    tboxCodigo.Text = Convert.ToString(modelo.ScatCod);

                }
                else
                {
                    modelo.ScatCod = Convert.ToInt32(tboxCodigo.Text);
                    BSubCategoria.Alterar(modelo);
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

        public override void LimparFormulario()
        {
            base.LimparFormulario();
            tboxCodigo.Clear();
            tboxNomeSubCat.Clear();
        }
    }
}
