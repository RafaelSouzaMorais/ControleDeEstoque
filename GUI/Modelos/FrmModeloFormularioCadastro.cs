using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace GUI.Modelos
{
    public partial class FrmModeloFormularioCadastro : Form
    {
        public String operacao;
        public UtilitariosForms utilitariosForms;
        public FrmModeloFormularioCadastro()
        {
            InitializeComponent();
            utilitariosForms = new UtilitariosForms();
        }
        /// <summary>
        /// Realiza o controle dos botões
        /// </summary>
        /// <param name="op">IR = Inserir e Recuperar; IA = Inserir ou alterar um registro; EA = excluir ou alterar</param>
        public void ControleBotoes(string op)
        {

            pnDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnRecuperar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            char[] opcoes = op.ToCharArray();
            foreach (char opcao in opcoes)
            {
                switch (opcao)
                {
                    case 'I':
                        btnInserir.Enabled = true;      
                        break;
                    case 'R':
                        btnRecuperar.Enabled = true;
                        break;
                    case 'S':
                        btnSalvar.Enabled = true;
                        break;
                    case 'C':
                        btnCancelar.Enabled = true;
                        break;
                    case 'A':
                        btnAlterar.Enabled = true;
                        break;
                    case 'E':
                        btnExcluir.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void FrmModeloFormularioCadastro_Load(object sender, EventArgs e)
        {
            ControleBotoes("IR");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            PreAlterar();
            operacao = "alterar";
            ControleBotoes("SC");
            pnDados.Enabled = true;
            PosAlterar();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            PreInserir();
            operacao = "inserir";
            ControleBotoes("SC");
            pnDados.Enabled = true;
            PosInserir();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControleBotoes("IR");
            LimparFormulario();
        }
        public virtual void LimparFormulario()
        {

        }
        public virtual void PosInserir()
        {

        }
        public virtual void PreInserir()
        {

        }
        public virtual void PreAlterar()
        {

        }
        public virtual void PosAlterar()
        {

        }
    }
}