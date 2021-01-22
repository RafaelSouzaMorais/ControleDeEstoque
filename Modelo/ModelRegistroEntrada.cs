using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelRegistroEntrada
    {
        public ModelRegistroEntrada()
        {

        }

        private int rge_cod;
        private int rge_cod_estoque;
        private Double rge_quantidade;
        private DateTime rge_data_registro;
        private int rge_cod_usuario;
        private double rge_valor_pago;

        public int RgeCod { get => rge_cod; set => rge_cod = value; }
        public int RgeCodEstoque { get => rge_cod_estoque; set => rge_cod_estoque = value; }
        public double RgeQuantidade { get => rge_quantidade; set => rge_quantidade = value; }
        public DateTime RgeDataRegistro { get => rge_data_registro; set => rge_data_registro = value; }
        public int RgeCodUsuario { get => rge_cod_usuario; set => rge_cod_usuario = value; }
        public double RgeValorPago { get => rge_valor_pago; set => rge_valor_pago = value; }
    }
}
