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
    public partial class FrmCategoria : FrmModeloFormularioCadastro
    {
        public FrmCategoria(string strConexao) : base(strConexao)
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            tboxNome.Focus();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Deseja realmente excluir o registro?","Aviso",MessageBoxButtons.YesNo);
                if(resposta.ToString().Equals("Yes"))
                {                    
                    DALConexao conexao = new DALConexao(stringConexaoBD);
                    BusinessCategoria BCategoria = new BusinessCategoria(conexao);
                    ModelCategoria modelo = new ModelCategoria(Convert.ToInt32(tboxCodigo.Text), Convert.ToString(tboxNome.Text));
                    BCategoria.Excluir(modelo);
                    MessageBox.Show("Exclusão feita com sucesso!");
                    ControleBotoes("IR");
                    LimparFormulario();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na exclusão da categoria: "+erro.Message);
                ControleBotoes("AEC"); 
            }
        }
       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(stringConexaoBD);
                BusinessCategoria BCategoria = new BusinessCategoria(conexao);
                ModelCategoria modelo = new ModelCategoria();
                modelo.CatNome = Convert.ToString(tboxNome.Text);

                if (operacao.Equals(TipoOperacaoRegistro.Inserir))
                {
                    BCategoria.Incluir(modelo);
                    MessageBox.Show("Inserção feita com sucesso!");
                    tboxCodigo.Text = Convert.ToString(modelo.CatCod);
                   
                }
                else
                {
                    modelo.CatCod = Convert.ToInt32(tboxCodigo.Text);
                    BCategoria.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                   
                }
                LimparFormulario();
                ControleBotoes("IR");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaCategoria frm = new FrmPopupConsultaCategoria(stringConexaoBD, TipoAberturaInterface.search);
            frm.ShowDialog();
            if(frm.retorno.Count > 0)
            {
                DALConexao conexao = new DALConexao(stringConexaoBD);
                BusinessCategoria BCategoria = new BusinessCategoria(conexao);
                ModelCategoria modelo = BCategoria.CarregaModeloCategoria(Convert.ToInt32(frm.retorno["Código"]));
                tboxCodigo.Text = Convert.ToString(modelo.CatCod);
                tboxNome.Text = modelo.CatNome;
                ControleBotoes("AEC");
            }
            else
            {
                ControleBotoes("IR");
                LimparFormulario();
            }
            frm.Dispose();
        }

        public override void LimparFormulario()
        {
            base.LimparFormulario();
            tboxCodigo.Clear();
            tboxNome.Clear();
        }
    }
}
