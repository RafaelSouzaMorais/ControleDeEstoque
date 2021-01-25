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
    public class BusinessUnidadeMedida
    {
        private DALConexao _conexao;
        private TipoOperacaoRegistro operacao;

        public BusinessUnidadeMedida(DALConexao conexao)
        {
            _conexao = conexao;
        }

        public void Incluir(ModelUnidadeMedida modelo)
        {
            operacao = TipoOperacaoRegistro.Inserir;
            string msgErro = "";

            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }

            if (!VerificaUnidadeMedidaExistente(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }

            DALUnidadeMedida DALObj = new DALUnidadeMedida(_conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModelUnidadeMedida modelo)
        {
            operacao = TipoOperacaoRegistro.Alterar;
            string msgErro = "";

            if (!ValidaCampos(modelo, ref msgErro))
            {
                throw new Exception(msgErro);
            }

            DALUnidadeMedida DALObj = new DALUnidadeMedida(_conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(ModelUnidadeMedida modelo)
        {
            operacao = TipoOperacaoRegistro.Excluir;
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

        public bool VerificaUnidadeMedidaExistente(ModelUnidadeMedida modelo, ref string msgErro)
        {
            DALUnidadeMedida DALObj = new DALUnidadeMedida(_conexao);
            if (DALObj.ConsultaUnidadeMedidaPorNome(modelo.UmedNome.Trim()))
            {
                msgErro = "A Unidade de Medida já está cadastrado no sistema.";
                return false;
            }
            return true;
        }

        private bool ValidaCampos(ModelUnidadeMedida modelo, ref string msgErro)
        {
            if (modelo.UmedNome.Trim().Length == 0)
            {
                msgErro = "O nome da Unidade de Medida é de preenchimento obrigatório";
            }

            if (operacao.Equals(TipoOperacaoRegistro.Alterar) && modelo.UmedCod <= 0)
            {
                msgErro = "O código informado é inválido";
            }

            return true;
        }
    }
}
