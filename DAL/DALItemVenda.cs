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
    public class DALItemVenda
    {
        private DALConexao _conexao;

        public DALItemVenda(DALConexao conexao)
        {
            this._conexao = conexao;
        }

        public void Incluir(ModelItemVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"INSERT INTO itv_itens_venda
                                                (itv_quantidade,
                                                 itv_valor,
                                                 itv_cod_venda,
                                                 itv_cod_produto)
                                    VALUES      (@quantidade,
                                                 @valor,
                                                 @codVenda,
                                                 @codProduto)

                                    SELECT @@IDENTITY;  ";
                cmd.Parameters.AddWithValue("@quantidade", modelo.ItvQuantidade);
                cmd.Parameters.AddWithValue("@valor", modelo.ItvValor);
                cmd.Parameters.AddWithValue("@codVenda", modelo.ItvCodVenda);
                cmd.Parameters.AddWithValue("@codProduto", modelo.ItvCodProduto);
                _conexao.Conectar();
                modelo.ItvCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro na Inclusão de Item da Venda.");
            }
            finally
            {
                _conexao.Desconectar();
            }
        }

        public void Alterar(ModelItemVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"UPDATE itv_itens_venda
                                    SET    itv_quantidade = quantidade,
                                           itv_valor = @valor,
                                           itv_cod_venda = @codVenda,
                                           itv_cod_produto = @codProduto
                                    WHERE  itv_cod = @codigo ";
                cmd.Parameters.AddWithValue("@quantidade", modelo.ItvQuantidade);
                cmd.Parameters.AddWithValue("@valor", modelo.ItvValor);
                cmd.Parameters.AddWithValue("@codVenda", modelo.ItvCodVenda);
                cmd.Parameters.AddWithValue("@codProduto", modelo.ItvCodProduto);
                cmd.Parameters.AddWithValue("@codigo", modelo.ItvCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro na Edição do Item da Venda.");
            }
            finally
            {
                _conexao.Desconectar();
            }
        }

        public void Excluir(ModelItemVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"DELETE FROM itv_itens_venda
                                    WHERE itv_cod = @codigo ";
                cmd.Parameters.AddWithValue("@codigo", modelo.ItvCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro na Exclusão de Item da Venda.");
            }
            finally
            {
                _conexao.Desconectar();
            }
        }

        public DataTable RecuperarPorCodigo(int codigo)
        {
            DataTable tabela = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter($@"  SELECT *
                                                        FROM   itv_itens_venda
                                                        WHERE  itv_cod = {codigo} 
                                                        ", _conexao.ObjetoConexao);
                da.Fill(tabela);
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Item da Venda.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return tabela;
        }
        
        public ModelItemVenda CarregaModeloProduto(int codigo)
        {
            ModelItemVenda modelo = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"SELECT *
                                FROM itv_itens_venda
                                WHERE itv_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                _conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    modelo = new ModelItemVenda();
                    modelo.ItvCod = Convert.ToInt32(registro["itv_cod"]);
                    modelo.ItvValor = Convert.ToDouble(registro["itv_valor"]);
                    modelo.ItvQuantidade = Convert.ToSingle(registro["itv_quantidade"]);
                    modelo.ItvCodVenda = Convert.ToInt32(registro["itv_cod_venda"]);
                    modelo.ItvCodProduto = Convert.ToInt32(registro["itv_cod_produto"]);
                }
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Item da Venda.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return modelo;
        }

    }
}
