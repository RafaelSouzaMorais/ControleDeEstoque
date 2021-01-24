using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI.Configuração
{
    public partial class FrmBancoDados : Form //: GUI.Modelos.FrmModeloFormularioCadastro
    {
        public FrmBancoDados()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("system.config", false);
                arquivo.WriteLine(tboxServidor.Text);
                arquivo.WriteLine(tboxBancoDados.Text);
                arquivo.WriteLine(tboxUsuario.Text);
                arquivo.WriteLine(tboxSenha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo de configuração do Banco de Dados atualizado com sucesso.");
            }
            catch
            {
                MessageBox.Show("Erro ao atualizar arquivo de configuração do Banco de Dados.");
            }
        }

        private void FrmBancoDados_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("system.config");
                tboxServidor.Text = arquivo.ReadLine();
                tboxBancoDados.Text = arquivo.ReadLine();
                tboxUsuario.Text = arquivo.ReadLine();
                tboxSenha.Text = arquivo.ReadLine();
                arquivo.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao carregarr arquivo de configuração do Banco de Dados.");
            }
        }
    }
}
