using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelProduto
    {
        public ModelProduto()
        {
            this.ProCod = 0;
            this.ProNome = "";
            this.ProDescricao = "";
            this.ProCodUnidadeMedida = 0;
            this.ProCodCategoria = 0;
            this.ProCodSubCategoria = 0;
        }

        public ModelProduto(int proCod, String proNome, String proDescricao,
            String proFoto, int proCodUnidadeMedida, int proCodCategoria, int proCodSubCategoria)
        {
            this.ProCod = proCod;
            this.ProNome = proNome;
            this.ProDescricao = proDescricao;
            this.CarregaImagem(proFoto);
            this.ProCodUnidadeMedida = proCodUnidadeMedida;
            this.ProCodCategoria = proCodCategoria;
            this.ProCodSubCategoria = proCodSubCategoria;
        }

        public ModelProduto(int proCod, String proNome, String proDescricao,
           Byte[] proFoto, int proCodUnidadeMedida, int proCodCategoria, int proCodSubCategoria)
        {
            this.ProCod = proCod;
            this.ProNome = proNome;
            this.ProDescricao = proDescricao;
            this.ProFoto = proFoto;
            this.ProCodUnidadeMedida = proCodUnidadeMedida;
            this.ProCodCategoria = proCodCategoria;
            this.ProCodSubCategoria = proCodSubCategoria;

        }

        private int pro_cod;
        private String pro_nome;
        private String pro_descricao;
        private byte[] pro_foto;
        private int pro_cod_und_medida;
        private int pro_cod_categoria;
        private int pro_cod_subcategoria;
        private Double pro_valor_venda;

        public int ProCod { get => pro_cod; set => pro_cod = value; }
        public String ProNome { get => pro_nome; set => pro_nome = value; }
        public String ProDescricao { get => pro_descricao; set => pro_descricao = value; }
        public byte[] ProFoto { get => pro_foto; set => pro_foto = value; }
        public int ProCodUnidadeMedida { get => pro_cod_und_medida; set => pro_cod_und_medida = value; }
        public int ProCodCategoria { get => pro_cod_categoria; set => pro_cod_categoria = value; }
        public int ProCodSubCategoria { get => pro_cod_subcategoria; set => pro_cod_subcategoria = value; }
        public double ProValorVenda { get => pro_valor_venda; set => pro_valor_venda = value; }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedades e métodos de instância para criar, copiar,
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
