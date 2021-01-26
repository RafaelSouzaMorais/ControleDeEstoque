using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALEstoque
    {
        private DALConexao _conexao;

        public DALEstoque(DALConexao conexao)
        {
            this._conexao = conexao;
        }

        public void Incluir(ModelEstoque modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"INSERT INTO estq_estoque
                                                (estq_data_validade,
                                                 estq_cod_produto,
                                                 estq_quantidade,
                                                 estq_codigo_barra)
                                    VALUES      (@dataValidade,
                                                 @codigoProduto,
                                                 @quantidade,
                                                 @codigoBarra)

                                    SELECT @@IDENTITY; ";
                cmd.Parameters.AddWithValue("@dataValidade", modelo.EstqDataValidade);
                cmd.Parameters.AddWithValue("@codigoProduto", modelo.EstqCodProduto);
                cmd.Parameters.AddWithValue("@quantidade", modelo.EstqQuantidade);
                cmd.Parameters.AddWithValue("@codigoBarra", modelo.EstqCodigoBarra);
                _conexao.Conectar();
                modelo.EstqCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro na Inclusão de Estoque.");
            }
            finally
            {
                _conexao.Desconectar();
            }
        }

        public void Alterar(ModelEstoque modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"UPDATE estq_estoque
                                    SET    estq_data_validade = @dataValidade,
                                            estq_cod_produto = @codigoProduto,
                                            estq_quantidade = @quantidade,
                                            estq_codigo_barra = @codigoBarra
                                    WHERE  estq_cod = @codigo ";
                cmd.Parameters.AddWithValue("@dataValidade", modelo.EstqDataValidade);
                cmd.Parameters.AddWithValue("@codigoProduto", modelo.EstqCodProduto);
                cmd.Parameters.AddWithValue("@quantidade", modelo.EstqQuantidade);
                cmd.Parameters.AddWithValue("@codigoBarra", modelo.EstqCodigoBarra);
                cmd.Parameters.AddWithValue("@codigo", modelo.EstqCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na Edição do Estoque: " + erro.Message);
            }
            finally
            {
                _conexao.Desconectar();
            }
        }

        public void Excluir(ModelEstoque modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Delete from estq_estoque where estq_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", modelo.EstqCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro na Exclusão de Estoque.");
            }
            finally
            {
                _conexao.Desconectar();
            }
        }

        public DataTable RecuperarPorCodigo(String valor)
        {
            DataTable tabela = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from estq_estoque where estq_cod = " + valor, _conexao.ObjetoConexao);
                da.Fill(tabela);
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Estoque.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return tabela;
        }

        public ModelEstoque CarregaModeloProduto(int codigo)
        {
            ModelEstoque modelo = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"SELECT *
                                FROM estq_estoque
                                WHERE estq_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                _conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    modelo = new ModelEstoque();
                    modelo.EstqCod = Convert.ToInt32(registro["estq_cod"]);
                    modelo.EstqDataValidade = Convert.ToDateTime(registro["estq_data_validade"]);
                    modelo.EstqCodProduto = Convert.ToInt32(registro["estq_cod_produto"]);
                    modelo.EstqQuantidade = Convert.ToDouble(registro["estq_quantidade"]);
                    modelo.EstqCodigoBarra = Convert.ToString(registro["estq_codigo_barra"]);
                }
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Estoque.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return modelo;
        }

        public int RecuperaCodEstoque(ModelEstoque modelo)
        {
            int codEstoque = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = $@"SELECT estq_cod
                                FROM   estq_estoque
                                WHERE  Cast(estq_data_validade AS DATE) = Cast('{modelo.EstqDataValidade.ToString()}' AS DATE)
                                       AND estq_codigo_barra = '{modelo.EstqCodigoBarra}'
                                       AND estq_cod_produto = {modelo.EstqCodProduto}";
                _conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    codEstoque = Convert.ToInt32(registro["estq_cod"]);
                }
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Estoque.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return codEstoque;
        }

        public int RecuperaQuantidadeEstoque(int codEstoque)
        {
            int quantidadeEstoque = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"SELECT estq_quantidade
                                FROM   estq_estoque
                                WHERE  estq_cod = @codigo ";
                cmd.Parameters.AddWithValue("@codigo", codEstoque);
                _conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    quantidadeEstoque = Convert.ToInt32(registro["estq_quantidade"]);
                }
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Estoque.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return quantidadeEstoque;
        }

    }
}
