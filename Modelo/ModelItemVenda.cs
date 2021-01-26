using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelItemVenda
    {
        public ModelItemVenda()
        {
            this.ItvCod = 0;
            this.ItvQuantidade = 0;
            this.ItvValor = 0;
            this.ItvCodVenda = 0;
            this.ItvCodProduto = 0;
        }

        private int itv_cod;
        private float itv_quantidade;
        private Double itv_valor;
        private int itv_cod_venda;
        private int itv_cod_produto;

        public int ItvCod { get => itv_cod; set => itv_cod = value; }
        public float ItvQuantidade { get => itv_quantidade; set => itv_quantidade = value; }
        public double ItvValor { get => itv_valor; set => itv_valor = value; }
        public int ItvCodVenda { get => itv_cod_venda; set => itv_cod_venda = value; }
        public int ItvCodProduto { get => itv_cod_produto; set => itv_cod_produto = value; }
    }
}
