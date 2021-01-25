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
    public class BusinessSubCategoria
    {
        private DALConexao _conexao;
        private TipoOperacaoRegistro operacao;

        public BusinessSubCategoria(DALConexao conexao)
        {
            _conexao = conexao;
        }
        public void Incluir(ModelSubCategoria modelo)
        {
            operacao = TipoOperacaoRegistro.Inserir;
            string msgErro = "";
            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModelSubCategoria modelo)
        {
            operacao = TipoOperacaoRegistro.Alterar;
            string msgErro = "";
            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(ModelSubCategoria modelo)
        {
            operacao = TipoOperacaoRegistro.Excluir;
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            DALObj.Excluir(modelo);
        }

        public DataTable Localizar(String valor)
        {
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            return DALObj.RecuperarPorNome(valor);
        }

        public object LocalizarPorCategoria(int valor)
        {
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            return DALObj.RecuperarPorCategoria(valor);
        }

        public ModelSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            return DALObj.CarregaModeloSubCategoria(codigo);
        }

        private bool ValidaCampos(ModelSubCategoria modelo, ref string msgErro)
        {
            //Verifica se o nome da categoria está preenchido
            if (modelo.ScatNome.Trim().Length == 0)
            {
                msgErro = "O nome da SubCategoria é de preenchimento obrigatório";
            }
            //Verifica se o código da categoria está preenchido
            if (modelo.ScatCodCategoria <= 0)
            {
                msgErro = "A Categoria é de preenchimento obrigatório.";
            }

            if (operacao.Equals(TipoOperacaoRegistro.Alterar) && modelo.ScatCod <= 0)
            {
                msgErro = "O código informado é inválido";
            }

            return true;
        }

    }
}
