using DAL;
using GUI.Cadastro;
using GUI.Configuração;
using GUI.Movimentação;
using GUI.Popup.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        string stringDeConexao;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            StringConexaoBanco();
            TesteConexao();
        }

        private void StringConexaoBanco()
        {
            try
            {
                StreamReader arquivo = new StreamReader("system.config");
                string servidor = arquivo.ReadLine();
                string bancoDados = arquivo.ReadLine();
                string usuario = arquivo.ReadLine();
                string senha = arquivo.ReadLine();

                DadosDaConexao dadosDaConexao = new DadosDaConexao(servidor, bancoDados, usuario, senha);
                stringDeConexao = dadosDaConexao.StringDeConexao;

                arquivo.Close();
                
            }
            catch
            {
                MessageBox.Show("Erro ao carregarr arquivo de configuração do Banco de Dados.");
                // Mantém stringDeConexao nula/vazia para validação posterior
            }
        }

        private void TesteConexao()
        {
            // Evita quebra ao iniciar quando não existe configuração
            if (string.IsNullOrWhiteSpace(stringDeConexao))
            {
                MessageBox.Show("Configuração do Banco de Dados não encontrada ou inválida. Abra Configuração > Banco de Dados para configurar.");
                return;
            }

            try
            {
                DALConexao dalConexao = new DALConexao(stringDeConexao);
                if (!dalConexao.TesteConexao())
                {
                    MessageBox.Show("Erro de acesso ao Banco de Dados. Verifique as configurações em Configuração > Banco de Dados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar conexão com o Banco de Dados: {ex.Message}");
            }
        }
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria f = new FrmCategoria(stringDeConexao);
            f.MdiParent = this;
            f.Show();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaCategoria f = new FrmPopupConsultaCategoria(stringDeConexao, TipoAberturaInterface.menu);
            f.MdiParent = this;
            f.Show();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubCategoria f = new FrmSubCategoria(stringDeConexao);
            f.MdiParent = this;
            f.Show();
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaSubCategoria f = new FrmPopupConsultaSubCategoria(stringDeConexao, TipoAberturaInterface.menu);
            f.MdiParent = this;
            f.Show();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnidadeMedida f = new FrmUnidadeMedida(stringDeConexao);
            f.MdiParent = this;
            f.Show();
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaUnidadeMedida f = new FrmPopupConsultaUnidadeMedida(stringDeConexao, TipoAberturaInterface.menu);
            f.MdiParent = this;
            f.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto f = new FrmProduto(stringDeConexao);
            f.MdiParent = this;
            f.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPopupConsultaProduto f = new FrmPopupConsultaProduto(stringDeConexao, TipoAberturaInterface.menu);
            f.MdiParent = this;
            f.Show();
        }

        private void registroDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroEntrada f = new FrmRegistroEntrada(stringDeConexao);
            f.MdiParent = this;
            f.Show();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBancoDados f = new FrmBancoDados();
            f.MdiParent = this;
            f.Show();
        }
    }
}
