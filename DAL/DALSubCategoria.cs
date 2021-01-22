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
    public class DALSubCategoria
    {
        private DALConexao _conexao;

        public DALSubCategoria(DALConexao conexao)
        {
            this._conexao = conexao;
        }
        public void Incluir(ModelSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Insert into scat_subcategoria (scat_nome, scat_cod_categoria) values (@nome, @codigoCategoria); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.ScatNome);
                cmd.Parameters.AddWithValue("@codigoCategoria", modelo.ScatCodCategoria);
                _conexao.Conectar();
                modelo.ScatCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na inserção de Subcategoria: " + erro.Message);
            }
            finally
            {
                _conexao.Desconectar();
            }

        }
        public void Alterar(ModelSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Update scat_subcategoria set scat_nome = @nome, scat_cod_categoria = @codigoCategoria where scat_cod = @codigo";
                cmd.Parameters.AddWithValue("@nome", modelo.ScatNome);
                cmd.Parameters.AddWithValue("@codigo", modelo.ScatCod);
                cmd.Parameters.AddWithValue("@codigoCategoria", modelo.ScatCodCategoria);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na alteração de Subcategoria: " + erro.Message);
            }
            finally
            {
                _conexao.Desconectar();
            }

        }
        public void Excluir(ModelSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Delete from scat_subcategoria where scat_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", modelo.ScatCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na exclusão de Subcategoria: " + erro.Message);
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
                SqlDataAdapter da = new SqlDataAdapter(@"select scat_cod, scat_nome,scat_cod_categoria, cat_nome
                                                            from scat_subcategoria inner join cat_categoria on scat_cod_categoria = cat_cod where scat_nome like '%" + valor + "%'", _conexao.ObjetoConexao);
                da.Fill(tabela);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na recuperação de Subcategoria: " + erro.Message);
            }
            return tabela;
        }
        public DataTable RecuperarPorCategoria(int valor)
        {
            DataTable tabela = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(@"select scat_cod, scat_nome,scat_cod_categoria                                                            
                                                            from scat_subcategoria where scat_cod_categoria =  "+valor, _conexao.ObjetoConexao);
                da.Fill(tabela);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na recuperação de Subcategoria: " + erro.Message);
            }
            return tabela;
        }
        public ModelSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            ModelSubCategoria modelo = new ModelSubCategoria();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Select * from scat_subcategoria where scat_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                _conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);
                    modelo.ScatNome = Convert.ToString(registro["scat_nome"]);
                    modelo.ScatCodCategoria = Convert.ToInt32(registro["scat_cod_categoria"]);
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro no carregamento do modelo de Subcategoria: " + erro.Message);
            }
            finally
            {
                _conexao.Desconectar();

            }
            return modelo;
        }
    }
}
