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
    public class DALProduto
    {
        private DALConexao _conexao;

        public DALProduto(DALConexao conexao)
        {
            this._conexao = conexao;
        }
        public void Incluir(ModelProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"INSERT INTO pro_produto
                                       (pro_nome,
                                       pro_descricao,
                                       pro_foto,
                                       pro_valor_venda,
                                       pro_cod_und_medida,
                                       pro_cod_categoria,
                                       pro_cod_subcategoria)
                                 VALUES
                                       (@nome,
		                               @descricao,
		                               @foto,
		                               @valorVenda,
		                               @codigoUnidadeMedida,
		                               @codigoCategoria,
		                               @codigoSubCategoria)
                                   select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.ProNome);
                cmd.Parameters.AddWithValue("@descricao", modelo.ProDescricao);
                cmd.Parameters.Add("@foto", SqlDbType.Image);
                if (modelo.ProFoto == null)
                {
                    cmd.Parameters["@foto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@foto"].Value = modelo.ProFoto;
                }
                cmd.Parameters.AddWithValue("@valorVenda", modelo.ProValorVenda);
                cmd.Parameters.AddWithValue("@codigoUnidadeMedida", modelo.ProCodUnidadeMedida);
                cmd.Parameters.AddWithValue("@codigoCategoria", modelo.ProCodCategoria);
                cmd.Parameters.AddWithValue("@codigoSubCategoria", modelo.ProCodSubCategoria);
                _conexao.Conectar();
                modelo.ProCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro na Inclusão de produto.");
            }
            finally
            {
                _conexao.Desconectar();
            }
        }
        public void Alterar(ModelProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"UPDATE pro_produto
                                SET pro_nome = @nome,
                                    pro_descricao = @descricao,
                                    pro_foto = @foto,
                                    pro_valor_venda = @valorVenda,
                                    pro_cod_und_medida = @codigoUnidadeMedida,
                                    pro_cod_categoria = @codigoCategoria,
                                    pro_cod_subcategoria = @codigoSubCategoria
                                WHERE pro_cod = @codigo";
                cmd.Parameters.AddWithValue("@nome", modelo.ProNome);
                cmd.Parameters.AddWithValue("@descricao", modelo.ProDescricao);
                cmd.Parameters.Add("@foto", SqlDbType.Image);
                if (modelo.ProFoto == null)
                {
                    cmd.Parameters["@foto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@foto"].Value = modelo.ProFoto;
                }
                cmd.Parameters.AddWithValue("@valorVenda", modelo.ProValorVenda);
                cmd.Parameters.AddWithValue("@codigoUnidadeMedida", modelo.ProCodUnidadeMedida);
                cmd.Parameters.AddWithValue("@codigoCategoria", modelo.ProCodCategoria);
                cmd.Parameters.AddWithValue("@codigoSubCategoria", modelo.ProCodSubCategoria);
                cmd.Parameters.AddWithValue("@codigo", modelo.ProCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na edição do Produto: " + erro.Message);
            }
            finally
            {
                _conexao.Desconectar();
            }
        }
        public void Excluir(ModelProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Delete from pro_produto where pro_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", modelo.ProCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro na Exclusão de produto.");
            }
            finally
            {
                _conexao.Desconectar();
            }
        }

        public DataTable RecuperarPorNome(String valor)
        {
            DataTable tabela = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from pro_produto where pro_nome like '%" + valor + "%'", _conexao.ObjetoConexao);
                da.Fill(tabela);
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Produto.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return tabela;
        }
        public ModelProduto CarregaModeloProduto(int codigo)
        {
            ModelProduto modelo = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Select * from pro_produto where pro_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                _conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo = new ModelProduto();
                    modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                    modelo.ProNome = Convert.ToString(registro["pro_nome"]);
                    modelo.ProDescricao = Convert.ToString(registro["pro_descricao"]);
                    modelo.ProValorVenda = Convert.ToDouble(registro["pro_valor_venda"]);
                    try
                    {
                        modelo.ProFoto = (byte[])registro["pro_foto"];
                    }
                    catch { }
                    modelo.ProCodUnidadeMedida = Convert.ToInt32(registro["pro_cod_und_medida"]);
                    modelo.ProCodCategoria = Convert.ToInt32(registro["pro_cod_categoria"]);
                    modelo.ProCodSubCategoria = Convert.ToInt32(registro["pro_cod_subcategoria"]);
                }
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Produto.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return modelo;
        }
    }
}
