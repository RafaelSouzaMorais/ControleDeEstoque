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
            DALCategoria DALObj = new DALCategoria(_conexao);
            DALObj.Excluir(modelo);
        }
    
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
    }
}
