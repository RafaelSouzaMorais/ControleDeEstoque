using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelVenda
    {
        public ModelVenda()
        {
            this.VenCod = 0;
            this.VenDataVenda = null;
            this.VenValorTotal = 0;
            this.VenValorRecebido = 0;
            this.VenObservacao = "";
            this.VenCodUsuario = 0;
        }

        private int ven_cod;
        private DateTime? ven_data_venda;
        private Double ven_valor_total;
        private Double ven_valor_recebido;
        private String ven_observacao;
        private int ven_cod_usuario;

        public int VenCod { get => ven_cod; set => ven_cod = value; }
        public DateTime?  VenDataVenda { get => ven_data_venda; set => ven_data_venda = value; }
        public double VenValorTotal { get => ven_valor_total; set => ven_valor_total = value; }
        public double VenValorRecebido { get => ven_valor_recebido; set => ven_valor_recebido = value; }
        public string VenObservacao { get => ven_observacao; set => ven_observacao = value; }
        public int VenCodUsuario { get => ven_cod_usuario; set => ven_cod_usuario = value; }
    }
}
