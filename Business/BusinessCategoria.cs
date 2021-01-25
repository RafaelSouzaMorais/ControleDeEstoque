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
    public class BusinessCategoria
    {
        private DALConexao _conexao;
        private TipoOperacaoRegistro operacao;

        public BusinessCategoria(DALConexao conexao)
        {
            _conexao = conexao;
        }
        public void Incluir(ModelCategoria modelo)
        {
            operacao = TipoOperacaoRegistro.Inserir;
            string msgErro = "";
            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }
            DALCategoria DALObj = new DALCategoria(_conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModelCategoria modelo)
        {
            operacao = TipoOperacaoRegistro.Alterar;
            string msgErro = "";
            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }
            DALCategoria DALObj = new DALCategoria(_conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(ModelCategoria modelo)
        {
            operacao = TipoOperacaoRegistro.Excluir;
            /*verifica se existe registro em subcategoria*/
            if (VerificaRegistroSubCategoria(modelo.CatCod))
            {
                throw new Exception("Não é possivel excluir essa Categoria pois ainda existe Subcategoria cadastrada para ela.");
            }
            DALCategoria DALObj = new DALCategoria(_conexao);
            DALObj.Excluir(modelo);
        }

        /// <summary>
        /// Recupera o DataTable da Subcategoria
        /// </summary>
        /// <param name="valor">Valor referente ao nome da Subcategoria</param>
        /// <returns>Retorna o DataTable da Subcategoria mais o nome da categoria</returns>
        public DataTable Localizar(String valor)
        {
            DALCategoria DALObj = new DALCategoria(_conexao);
            return DALObj.RecuperarPorNome(valor);
        }

        public ModelCategoria CarregaModeloCategoria(int codigo)
        {
            DALCategoria DALObj = new DALCategoria(_conexao);
            return DALObj.CarregaModeloCategoria(codigo);
        }

        /// <summary>
        /// Verifica se existe registro em SubCategoria referenciando a Categoria
        /// </summary>
        /// /// <param name="valor">Valor referente ao código da categoria</param>
        /// <returns>Retorna true caso exista registro em SubCategoria referenciando Categoria</returns>
        public bool VerificaRegistroSubCategoria(int valor)
        {
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            int rowCount = DALObj.RecuperarPorCategoria(valor).Rows.Count;
            if (rowCount > 0)
            {
                return true;
            }
            return false;
        }

        private bool ValidaCampos(ModelCategoria modelo, ref string msgErro)
        {

            if (modelo.CatNome.Trim().Length == 0)
            {
                msgErro = "O nome da Categoria é de preenchimento obrigatório";
            }

            if (operacao.Equals(TipoOperacaoRegistro.Alterar) && modelo.CatCod <= 0)
            {
                msgErro = "O código informado é inválido";
            }

            return true;
        }
    }
}
