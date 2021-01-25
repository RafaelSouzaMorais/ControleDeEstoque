using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Enums;

namespace Business
{
    public class BusinessEstoque
    {
        private DALConexao _conexao;
        private TipoOperacaoRegistro operacao;

        public BusinessEstoque(DALConexao conexao)
        {
            _conexao = conexao;
        }

        public void Incluir(ModelEstoque modelo)
        {
            operacao = TipoOperacaoRegistro.Inserir;
            string msgErro = "";
            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }
            DALEstoque DALObj = new DALEstoque(_conexao);
            if (VerificaEstoqueExistente(modelo))
            {
                modelo.EstqQuantidade += RecuperaQuantidadeEstoque(modelo.EstqCod);
                
                DALObj.Alterar(modelo);
            }
            else
            {
                DALObj.Incluir(modelo);
            }
        }

        public void Alterar(ModelEstoque modelo)
        {
            operacao = TipoOperacaoRegistro.Alterar;
            string msgErro = "";
            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }

            DALEstoque DALObj = new DALEstoque(_conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(ModelEstoque modelo)
        {
            operacao = TipoOperacaoRegistro.Excluir;
            DALEstoque DALObj = new DALEstoque(_conexao);
            DALObj.Excluir(modelo);
        }

        //public DataTable Localizar(String valor)
        //{
        //    DALEstoque DALObj = new DALEstoque(_conexao);
        //    return DALObj.RecuperarPorCodigo(valor);
        //}

        public ModelEstoque CarregaModeloProduto(int codigo)
        {
            DALEstoque DALObj = new DALEstoque(_conexao);
            return DALObj.CarregaModeloProduto(codigo);
        }

        private bool ValidaCampos(ModelEstoque modelo, ref string msgErro)
        {
            if (modelo.EstqDataValidade <= DateTime.Today)
            {
                msgErro = "A data de validade deve ser superior ã data de hoje.";
                return false;
            }

            if (modelo.EstqQuantidade == 0)
            {
                msgErro = "A quantidade do Produto deve ser maior que 0.";
                return false;
            }

            if (modelo.EstqCodProduto <= 0)
            {
                msgErro = "O Produto é de preenchimento obrigatório.";
                return false;
            }

            //if (modelo.EstqCodigoBarra < 0)
            //{
            //    msgErro = "A quantidade do Produto não pode ser negativa.";
            //    return false;
            //}

            if (operacao.Equals(TipoOperacaoRegistro.Alterar) && modelo.EstqCod <= 0)
            {
                msgErro = "O código informado é inválido";
            }

            return true;
        }
        
        private bool VerificaEstoqueExistente(ModelEstoque modelo)
        {
            int codEstoque;
            DALEstoque DALObj = new DALEstoque(_conexao);
            codEstoque = DALObj.RecuperaCodEstoque(modelo);

            if(codEstoque == 0)
            {
                return false;
            }
            modelo.EstqCod = codEstoque;
            return true;
        }

        private Double RecuperaQuantidadeEstoque(int codEstoque)
        {
            DALEstoque DALObj = new DALEstoque(_conexao);
            return  DALObj.RecuperaQuantidadeEstoque(codEstoque);
        }
    }
}
