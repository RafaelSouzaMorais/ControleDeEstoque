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
    public class BusinessSubCategoria
    {
        private DALConexao _conexao;

        public BusinessSubCategoria(DALConexao conexao)
        {
            _conexao = conexao;
        }
        public void Incluir(ModeloSubCategoria modelo)
        {
            //Verifica se o nome da categoria está preenchido
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da SubCategoria é de preenchimento obrigatório");
            }
            //Verifica se o código da categoria está preenchido
            if (modelo.ScatCodCategoria <= 0)
            {
                throw new Exception("O nome da SubCategoria é de preenchimento obrigatório");
            }
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModeloSubCategoria modelo)
        {
            //Verifica se o nome da categoria está preenchido
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da SubCategoria é de preenchimento obrigatório");
            }
            //Verifica se o código da categoria está preenchido
            if (modelo.ScatCodCategoria <= 0)
            {
                throw new Exception("O nome da SubCategoria é de preenchimento obrigatório");
            }
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(ModeloSubCategoria modelo)
        {
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            DALObj.Excluir(modelo);
        }

        public DataTable Localizar(String valor)
        {
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            return DALObj.RecuperarPorNome(valor);
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            DALSubCategoria DALObj = new DALSubCategoria(_conexao);
            return DALObj.CarregaModeloSubCategoria(codigo);
        }

    }
}
