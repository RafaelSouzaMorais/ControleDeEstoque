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
    public class DALRegistroEntrada
    {
        private DALConexao _conexao;

        public DALRegistroEntrada(DALConexao conexao)
        {
            this._conexao = conexao;
        }
        
        public void Incluir(ModelRegistroEntrada modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"INSERT INTO rge_registro_entrada
                                        (rge_cod_estoque,
                                        rge_quantidade,
                                        rge_data_registro,
                                        rge_cod_usuario,
                                        rge_valor_pago)
                                 VALUES
                                        (@codigoEstoque,
		                                @quantidade,
		                                { fn NOW() },
		                                @codigoUsuario,
		                                @valorPago)
                                   select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@codigoEstoque", modelo.RgeCodEstoque);
                cmd.Parameters.AddWithValue("@quantidade", modelo.RgeQuantidade);
                cmd.Parameters.AddWithValue("@codigoUsuario", modelo.RgeCodUsuario);
                cmd.Parameters.AddWithValue("@valorPago", modelo.RgeValorPago);
                _conexao.Conectar();
                modelo.RgeCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                throw new Exception("Erro na Inclusão de Registro de Entrada.");
            }
            finally
            {
                _conexao.Desconectar();
            }
        }

        public void Alterar(ModelRegistroEntrada modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"UPDATE rge_registro_entrada
                                    SET rge_cod= @codigo,
                                        rge_cod_estoque = @codigoEstoque,
                                        rge_quantidade = @quantidade,
                                        rge_data_registro = @dataRegistro,
                                        rge_cod_usuario = @codigoUsuario,
                                        rge_valor_pago = @valorPago,
                                WHERE pro_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", modelo.RgeCod);
                cmd.Parameters.AddWithValue("@codigoEstoque", modelo.RgeCodEstoque);
                cmd.Parameters.AddWithValue("@quantidade", modelo.RgeQuantidade);
                cmd.Parameters.AddWithValue("@dataRegistro", modelo.RgeDataRegistro);
                cmd.Parameters.AddWithValue("@codigoUsuario", modelo.RgeCodUsuario);
                cmd.Parameters.AddWithValue("@valorPago", modelo.RgeValorPago);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na edição do Registro de Entrada: " + erro.Message);
            }
            finally
            {
                _conexao.Desconectar();
            }
        }

        public void Excluir(ModelRegistroEntrada modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = "Delete from rge_registro_entrada where rge_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", modelo.RgeCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro na Exclusão do Registro de Entrada.");
            }
            finally
            {
                _conexao.Desconectar();
            }
        }     
    }
}
