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
    public class DALUnidadeMedida
    {
        private DALConexao _conexao;

        public DALUnidadeMedida(DALConexao conexao)
        {
            this._conexao = conexao;
        }
        public void Incluir(ModelUnidadeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Insert into umed_und_medida ( umed_nome) values (@nome); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.UmedNome);
                _conexao.Conectar();
                modelo.UmedCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na inserção de Unidade de Medida: " + erro.Message);
            }
            finally
            {
                _conexao.Desconectar();
            }

        }
        public void Alterar(ModelUnidadeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Update umed_und_medida set umed_nome = @nome where umed_cod = @codigo";
                cmd.Parameters.AddWithValue("@nome", modelo.UmedNome);
                cmd.Parameters.AddWithValue("@codigo", modelo.UmedCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na alteração de Unidade de Medida: " + erro.Message);
            }
            finally
            {
                _conexao.Desconectar();
            }

        }
        public void Excluir(ModelUnidadeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Delete from umed_und_medida where umed_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", modelo.UmedCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na exclusão de Unidade de Medida: " + erro.Message);
            }
            finally
            {
                _conexao.Desconectar();
            }

        }
        public bool ConsultaUnidadeMedidaPorNome(String nome)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Select 1 from umed_und_medida where umed_nome = @nome";
                cmd.Parameters.AddWithValue("@nome", nome);
                _conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    return true;
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na consulta de Unidade de Medida por nome: " + erro.Message);
            }
            finally
            {
                _conexao.Desconectar();

            }
            return false;
        }
        public DataTable RecuperarPorNome(String valor)
        {
            DataTable tabela = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(@"select * from umed_und_medida where umed_nome like '%" + valor + "%'", _conexao.ObjetoConexao);
                da.Fill(tabela);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na recuperação de Unidade de Medida: " + erro.Message);
            }
            return tabela;
        }
        public ModelUnidadeMedida CarregaModeloUnidadeMedida(int codigo)
        {
            ModelUnidadeMedida modelo = new ModelUnidadeMedida();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Select * from umed_und_medida where umed_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                _conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo.UmedCod = Convert.ToInt32(registro["umed_cod"]);
                    modelo.UmedNome = Convert.ToString(registro["umed_nome"]);
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro no carregamento do modelo de Unidade de Medida: " + erro.Message);
            }
            finally
            {
                _conexao.Desconectar();

            }
            return modelo;
        }
    }

}
