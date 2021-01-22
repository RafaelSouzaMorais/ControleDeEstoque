using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Utils.Enums;

namespace GUI.Modelos
{
    public partial class FrmModeloFormularioConsulta : Form
    {
        
        public TipoAberturaInterface tipoAbertura = TipoAberturaInterface.menu;
        public Dictionary<string, object> retorno = new Dictionary<string, object>();

        public FrmModeloFormularioConsulta()
        {            
            InitializeComponent();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipoAbertura.Equals(TipoAberturaInterface.search))
            {
                int linhaSelecionada = e.RowIndex;
                for (int contadorColunas = 0; contadorColunas < dgvDados.Columns.Count; contadorColunas++)
                {
                    retorno.Add(dgvDados.Columns[contadorColunas].HeaderText, dgvDados.Rows[linhaSelecionada].Cells[contadorColunas].Value);
                }
                this.Close();
            }
        }
    }
}
