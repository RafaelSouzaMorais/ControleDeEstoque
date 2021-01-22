using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelEstoque
    {
        public ModelEstoque()
        {

        }

        private int estq_cod;
        private DateTime estq_data_validade;
        private int estq_cod_produto;
        private Double estq_quantidade;
        private String estq_codigo_barra;

        public int EstqCod { get => estq_cod; set => estq_cod = value; }
        public DateTime EstqDataValidade { get => estq_data_validade; set => estq_data_validade = value; }
        public int EstqCodProduto { get => estq_cod_produto; set => estq_cod_produto = value; }
        public double EstqQuantidade { get => estq_quantidade; set => estq_quantidade = value; }
        public string EstqCodigoBarra { get => estq_codigo_barra; set => estq_codigo_barra = value; }
    }
}
