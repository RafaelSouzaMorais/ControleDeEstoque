using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        public ModeloProduto()
        {
            this.ProCod = 0;
            this.ProNome = "";
            this.ProDescricao = "";
            this.ProValorPago = 0;
            this.ProValorVenda = 0;
            this.ProQtde = 0;
            this.ProCodUnidadeMedida = 0;
            this.ProCodCategoria = 0;
            this.ProCodSubCategoria = 0;
        }

        public ModeloProduto(int proCod, String proNome, String proDescricao,
            String proFoto, Double proValorPago, Double proValorVenda, Double proQtde,
            int proCodUnidadeMedida, int proCodCategoria, int proCodSubCategoria)
        {
            this.ProCod = proCod;
            this.ProNome = proNome;
            this.ProDescricao = proDescricao;
            this.CarregaImagem(proFoto);
            this.ProValorPago = proValorPago;
            this.ProValorVenda = proValorVenda;
            this.ProQtde = proQtde;
            this.ProCodUnidadeMedida = proCodUnidadeMedida;
            this.ProCodCategoria = proCodCategoria;
            this.ProCodSubCategoria = proCodSubCategoria;
        }

        public ModeloProduto(int proCod, String proNome, String proDescricao,
           Byte[] proFoto, Double proValorPago, Double proValorVenda, Double proQtde,
            int proCodUnidadeMedida, int proCodCategoria, int proCodSubCategoria)
        {
            this.ProCod = proCod;
            this.ProNome = proNome;
            this.ProDescricao = proDescricao;
            this.ProFoto = proFoto;
            this.ProValorPago = proValorPago;
            this.ProValorVenda = proValorVenda;
            this.ProQtde = proQtde;
            this.ProCodUnidadeMedida = proCodUnidadeMedida;
            this.ProCodCategoria = proCodCategoria;
            this.ProCodSubCategoria = proCodSubCategoria;
        }

        private int pro_cod;
        private String pro_nome;
        private String pro_descricao;
        private byte[] pro_foto;
        private Double pro_valor_pago;
        private Double pro_valor_venda;
        private Double pro_qtde;
        private int pro_cod_und_medida;
        private int pro_cod_categoria;
        private int pro_cod_subcategoria;

        public int ProCod { get => pro_cod; set => pro_cod = value; }
        public String ProNome { get => pro_nome; set => pro_nome = value; }
        public String ProDescricao { get => pro_descricao; set => pro_descricao = value; }
        public byte[] ProFoto { get => pro_foto; set => pro_foto = value; }
        public Double ProValorPago { get => pro_valor_pago; set => pro_valor_pago = value; }
        public Double ProValorVenda { get => pro_valor_venda; set => pro_valor_venda = value; }
        public Double ProQtde { get => pro_qtde; set => pro_qtde = value; }
        public int ProCodUnidadeMedida { get => pro_cod_und_medida; set => pro_cod_und_medida = value; }
        public int ProCodCategoria { get => pro_cod_categoria; set => pro_cod_categoria = value; }
        public int ProCodSubCategoria { get => pro_cod_subcategoria; set => pro_cod_subcategoria = value; }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedadese métodos de instância para criar, copiar,
                //excluir, mover, e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.ProFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.ProFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

    }
}
