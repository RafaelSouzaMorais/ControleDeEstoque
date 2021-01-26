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
    public class DALCategoria
    {
        private DALConexao _conexao;

        public DALCategoria(DALConexao conexao)
        {
            this._conexao = conexao;
        }
        public void Incluir(ModelCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObjetoConexao;
            cmd.CommandText = "Insert into cat_categoria(cat_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            _conexao.Conectar();
            modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());
            _conexao.Desconectar();
        }
        public void Alterar(ModelCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObjetoConexao;
            cmd.CommandText = "Update cat_categoria set cat_nome = @nome where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
            _conexao.Conectar();
            cmd.ExecuteNonQuery();
            _conexao.Desconectar();
        }
        public void Excluir(ModelCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObjetoConexao;
            cmd.CommandText = "Delete from cat_categoria where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
            _conexao.Conectar();
            cmd.ExecuteNonQuery();
            _conexao.Desconectar();
        }

        public DataTable RecuperarPorNome(String valor)
        {
            DataTable tabela = new DataTable();
            try
            {
                
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT *
                                                        FROM   cat_categoria
                                                        WHERE  cat_nome LIKE 
                                                            '%" + valor + "%'", _conexao.ObjetoConexao);
                da.Fill(tabela);
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Categoria.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return tabela;
        }
        public ModelCategoria CarregaModeloCategoria(int codigo)
        {
            ModelCategoria modelo = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"SELECT *
                                    FROM cat_categoria
                                    WHERE cat_cod = @codigo ";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                _conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo = new ModelCategoria();
                    modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                    modelo.CatNome = Convert.ToString(registro["cat_nome"]);
                }
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Categoria.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return modelo;
        }
    }
}
