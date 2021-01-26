using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Enums;

namespace Business
{
    public class BusinessItemVenda
    {
        private DALConexao _conexao;
        private TipoOperacaoRegistro operacao;

        public BusinessItemVenda(DALConexao conexao)
        {
            _conexao = conexao;
        }

        public void Incluir(ModelItemVenda modelo)
        {
            operacao = TipoOperacaoRegistro.Inserir;
            string msgErro = "";
            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }

            DALItemVenda DALObj = new DALItemVenda(_conexao);
            DALObj.Incluir(modelo);
            
        }

        public void Alterar(ModelItemVenda modelo)
        {
            operacao = TipoOperacaoRegistro.Alterar;
            string msgErro = "";
            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }

            DALItemVenda DALObj = new DALItemVenda(_conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(ModelItemVenda modelo)
        {
            operacao = TipoOperacaoRegistro.Excluir;
            DALItemVenda DALObj = new DALItemVenda(_conexao);
            DALObj.Excluir(modelo);
        }

        private bool ValidaCampos(ModelItemVenda modelo, ref string msgErro)
        {
            if (modelo.ItvValor <= 0)
            {
                msgErro = "A valor do item de venda deve ser maior que 0.";
                return false;
            }

            if (modelo.ItvCodVenda == 0)
            {
                msgErro = "A Venda é de preenchimento obrigatório.";
                return false;
            }

            if (modelo.ItvCodProduto <= 0)
            {
                msgErro = "O Produto é de preenchimento obrigatório.";
                return false;
            }

            if (modelo.ItvQuantidade <= 0)
            {
                msgErro = "O quantidade do Item de Venda é de preenchimento obrigatório.";
                return false;
            }
            //if (modelo.EstqCodigoBarra < 0)
            //{
            //    msgErro = "A quantidade do Produto não pode ser negativa.";
            //    return false;
            //}

            if (operacao.Equals(TipoOperacaoRegistro.Alterar) && modelo.ItvCod <= 0)
            {
                msgErro = "O código de Item de Venda informado é inválido.";
            }

            return true;
        }

    }
}
