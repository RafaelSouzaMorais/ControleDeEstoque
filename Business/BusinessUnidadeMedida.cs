using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessUnidadeMedida
    {
        private DALConexao _conexao;

        public BusinessUnidadeMedida(DALConexao conexao)
        {
            _conexao = conexao;
        }

        public void Incluir(ModelUnidadeMedida modelo)
        {
            //Verifica se o nome da categoria está preenchido
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Unidade de Medida é de preenchimento obrigatório");
            }
            DALUnidadeMedida DALObj = new DALUnidadeMedida(_conexao);
            if(DALObj.ConsultaUnidadeMedidaPorNome(modelo.UmedNome.Trim()))
            {
                throw new Exception("A Unidade de Medida já está cadastrado no sistema.");
            }
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModelUnidadeMedida modelo)
        {
            //Verifica se o nome da categoria está preenchido
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da Unidade de Medida é de preenchimento obrigatório.");
            }
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O código informado é inválido.");
            }
            DALUnidadeMedida DALObj = new DALUnidadeMedida(_conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(ModelUnidadeMedida modelo)
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(_conexao);
            DALObj.Excluir(modelo);
        }

        public DataTable Localizar(String valor)
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(_conexao);
            return DALObj.RecuperarPorNome(valor);
        }

        public ModelUnidadeMedida CarregaModeloUnidadeMedida(int codigo)
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(_conexao);
            return DALObj.CarregaModeloUnidadeMedida(codigo);
        }
    }
}
