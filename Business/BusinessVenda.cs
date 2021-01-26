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
    public class BusinessVenda
    {
        private DALConexao _conexao;
        private TipoOperacaoRegistro operacao;

        public BusinessVenda(DALConexao conexao)
        {
            _conexao = conexao;
        }

        public void Incluir(ModelVenda modelo)
        {
            operacao = TipoOperacaoRegistro.Inserir;
            string msgErro = "";
            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }
            DALVenda DALObj = new DALVenda(_conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModelVenda modelo)
        {
            operacao = TipoOperacaoRegistro.Alterar;
            string msgErro = "";
            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }

            DALVenda DALObj = new DALVenda(_conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(ModelVenda modelo)
        {
            operacao = TipoOperacaoRegistro.Excluir;
            DALVenda DALObj = new DALVenda(_conexao);
            DALObj.Excluir(modelo);
        }

        private bool ValidaCampos(ModelVenda modelo, ref string msgErro)
        {
            if (modelo.VenDataVenda == null)
            {
                msgErro = "A data da venda é de preenchimento obrigatório.";
                return false;
            }

            if (modelo.VenValorTotal <= 0)
            {
                msgErro = "O valor da venda deve ser maior que 0.";
                return false;
            }

            //if (modelo.EstqCodigoBarra < 0)
            //{
            //    msgErro = "A quantidade do Produto não pode ser negativa.";
            //    return false;
            //}

            if (operacao.Equals(TipoOperacaoRegistro.Alterar) && modelo.VenCod <= 0)
            {
                msgErro = "O código de Venda informado é inválido.";
            }

            return true;
        }
    }
}
