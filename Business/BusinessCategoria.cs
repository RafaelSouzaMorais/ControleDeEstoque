using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessCategoria
    {
        private DALConexao _conexao;

        public BusinessCategoria (DALConexao conexao)
        {
            _conexao = conexao;
        }
        public void Incluir(ModeloCategoria modelo)
        {
            //Verifica se o nome da categoria está preenchido
            if(modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Categoria é de preenchimento obrigatório");
            }
            DALCategoria DALObj = new DALCategoria(_conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloCategoria modelo)
        {
            //Verifica se o nome da categoria está preenchido
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Categoria é de preenchimento obrigatório");
            }
            if(modelo.CatCod <= 0)
            {
                throw new Exception("O código informado é inválido");
            }
            DALCategoria DALObj = new DALCategoria(_conexao);
            DALObj.Alterar(modelo);
        }
        
        public void Excluir(ModeloCategoria modelo)
        {
            /*verifica se existe registro em subcategoria*/
            if(VerificaRegistroSubCategoria(modelo.CatCod))
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

        public ModeloCategoria CarregaModeloCategoria(int codigo)
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
            if(rowCount > 0)
            {
                return true;
            }
            return false;
        }
    }
}
