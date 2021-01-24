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
    public class BusinessRegistroEntrada
    {
        private DALConexao _conexao;
        private TipoOperacaoRegistro operacao;

        public BusinessRegistroEntrada(DALConexao conexao)
        {
            _conexao = conexao;
        }
        public void Incluir(ModelRegistroEntrada modelo)
        {
            string msgErro = "";
            if (ValidaeCampos(modelo, ref msgErro))
            {
                DALRegistroEntrada DALObj = new DALRegistroEntrada(_conexao);
                DALObj.Incluir(modelo);
            }
            else
            {
                throw new Exception(msgErro);
            }
        }

        public void Alterar(ModelRegistroEntrada modelo)
        {
            operacao = TipoOperacaoRegistro.Alterar;
            string msgErro = "";
            if (ValidaeCampos(modelo, ref msgErro))
            {
                DALRegistroEntrada DALObj = new DALRegistroEntrada(_conexao);
                DALObj.Alterar(modelo);
            }
            else
            {
                throw new Exception(msgErro);
            }
        }

        public void Excluir(ModelRegistroEntrada modelo)
        {
            DALRegistroEntrada DALObj = new DALRegistroEntrada(_conexao);
            DALObj.Excluir(modelo);
        }

        //public DataTable Localizar(String valor)
        //{
        //    DALRegistroEntrada DALObj = new DALRegistroEntrada(_conexao);
        //    return DALObj.RecuperarPorNome(valor);
        //}

        //public ModelRegistroEntrada CarregaModeloProduto(int codigo)
        //{
        //    DALRegistroEntrada DALObj = new DALRegistroEntrada(_conexao);
        //    return DALObj.CarregaModeloProduto(codigo);
        //}

        private bool ValidaeCampos(ModelRegistroEntrada modelo, ref string msgErro)
        {
            //if (modelo.ProNome.Trim().Length == 0)
            //{
            //    msgErro = "O nome do Produto é de preenchimento obrigatório.";
            //    return false;
            //}
            if (operacao.Equals(TipoOperacaoRegistro.Alterar) && modelo.RgeCod <= 0)
            {
                throw new Exception("O código informado é inválido");
            }
            return true;
        }
    }
}
