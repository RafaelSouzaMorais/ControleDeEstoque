using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao;
        private SqlConnection _conexao;

        public string StringConexao { get => _stringConexao; set => _stringConexao = value; }
        public SqlConnection ObjetoConexao { get => _conexao; set => _conexao = value; }

        public DALConexao(String dadosConexao)
        {
            if (string.IsNullOrWhiteSpace(dadosConexao))
            {
                throw new ArgumentException("String de conexão inválida.", nameof(dadosConexao));
            }
            this._conexao = new SqlConnection(dadosConexao);
            this.StringConexao = dadosConexao;
        }

        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            if (this._conexao.State != System.Data.ConnectionState.Closed)
            {
                this._conexao.Close();
            }
        }

        public bool TesteConexao()
        {
            try
            {
                _conexao.Open();
                _conexao.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }
    }
}
