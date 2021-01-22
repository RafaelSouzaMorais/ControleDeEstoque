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
using System.Text;
using System.Windows.Forms;
using static Utils.Enums;

namespace GUI.Cadastro
{
    public partial class FrmUnidadeMedida : FrmModeloFormularioCadastro
    {
        public FrmUnidadeMedida()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BusinessUnidadeMedida BUnidadeMedida = new BusinessUnidadeMedida(conexao);
                ModelUnidadeMedida modelo = new ModelUnidadeMedida();
                modelo.UmedNome = Convert.ToString(tboxUnidadeMedida.Text);

                if (operacao.Equals(TipoOperacaoRegistro.Inserir))
                {
                    BUnidadeMedida.Incluir(modelo);
                    MessageBox.Show("Inserção feita com sucesso!");
                    tboxCodigo.Text = Convert.ToString(modelo.UmedCod);

                }
                else
                {
                    modelo.UmedCod = Convert.ToInt32(tboxCodigo.Text);
                    BUnidadeMedida.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!");

                }
                LimparFormulario();
                ControleBotoes("IR");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na inserção de Unidade de Medida: " + erro.Message);
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaUnidadeMedida frm = new FrmPopupConsultaUnidadeMedida(TipoAberturaInterface.search);
            frm.ShowDialog();
            if (frm.retorno.Count > 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BusinessUnidadeMedida BUnidadeMedida = new BusinessUnidadeMedida(conexao);
                ModelUnidadeMedida modelo = BUnidadeMedida.CarregaModeloUnidadeMedida(Convert.ToInt32(frm.retorno["Código"]));
                tboxCodigo.Text = Convert.ToString(modelo.UmedCod);
                tboxUnidadeMedida.Text = modelo.UmedNome;
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
                    BusinessUnidadeMedida BUnidadeMedida = new BusinessUnidadeMedida(conexao);
                    ModelUnidadeMedida modelo = new ModelUnidadeMedida(Convert.ToInt32(tboxCodigo.Text), Convert.ToString(tboxUnidadeMedida.Text));
                    BUnidadeMedida.Excluir(modelo);
                    MessageBox.Show("Exclusão feita com sucesso!");
                    ControleBotoes("IR");
                    LimparFormulario();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na exclusão da Unidade de Medida: " + erro.Message);
                ControleBotoes("AEC");
            }
        }

        public override void LimparFormulario()
        {
            base.LimparFormulario();
            tboxCodigo.Clear();
            tboxUnidadeMedida.Clear();
        }
    }
}
