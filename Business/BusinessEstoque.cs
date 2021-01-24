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
            string msgErro = "";
            if (ValidaeCampos(modelo, ref msgErro))
            {
                DALEstoque DALObj = new DALEstoque(_conexao);
                DALObj.Incluir(modelo);
            }
            else
            {
                throw new Exception(msgErro);
            }
        }

        public void Alterar(ModelEstoque modelo)
        {
            operacao = TipoOperacaoRegistro.Alterar;
            string msgErro = "";
            if (ValidaeCampos(modelo, ref msgErro))
            {
                DALEstoque DALObj = new DALEstoque(_conexao);
                DALObj.Alterar(modelo);
            }
            else
            {
                throw new Exception(msgErro);
            }
        }

        public void Excluir(ModelEstoque modelo)
        {
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
        private bool ValidaeCampos(ModelEstoque modelo, ref string msgErro)
        {
            //if (modelo.ProNome.Trim().Length == 0)
            //{
            //    msgErro = "O nome do Produto é de preenchimento obrigatório.";
            //    return false;
            //}
            //if (modelo.ProDescricao.Trim().Length == 0)
            //{
            //    msgErro = "A descrição do Produto é de preenchimento obrigatório.";
            //    return false;
            //}
            ////if (modelo.ProValorVenda <= 0)
            ////{
            ////    msgErro = "O Valor de venda do Produto é de preenchimento obrigatório.";
            ////    return false;
            ////}
            ////if (modelo.ProQtde < 0)
            ////{
            ////    msgErro = "A quantidade do Produto não pode ser negativa.";
            ////    return false;
            ////}
            //if (modelo.ProCodUnidadeMedida <= 0)
            //{
            //    msgErro = "A Unidade de Medidado Produto é de preenchimento obrigatório.";
            //    return false;
            //}
            //if (modelo.ProCodCategoria <= 0)
            //{
            //    msgErro = "A Categoria do Produto é de preenchimento obrigatório.";
            //    return false;
            //}
            //if (modelo.ProCodSubCategoria <= 0)
            //{
            //    msgErro = "A Subcategoria do Produto é de preenchimento obrigatório.";
            //    return false;
            //}
            if (operacao.Equals(TipoOperacaoRegistro.Alterar) && modelo.EstqCod <= 0)
            {
                throw new Exception("O código informado é inválido");
            }
            return true;
        }
    }
}
