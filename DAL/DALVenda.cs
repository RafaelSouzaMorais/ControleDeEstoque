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
    public class DALVenda
    {
        private DALConexao _conexao;

        public DALVenda(DALConexao conexao)
        {
            this._conexao = conexao;
        }

        public void Incluir(ModelVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"INSERT INTO ven_venda
                                                (ven_data_venda,
                                                 ven_valor_total,
                                                 ven_valor_recebido,
                                                 ven_observacao,
                                                 ven_cod_usuario)
                                    VALUES      (@dataVenda,
                                                 @valorTotal,
                                                 @valorRecebido,
                                                 @observacao,
                                                 @codUsuario)

                                    SELECT @@IDENTITY; ";
                cmd.Parameters.AddWithValue("@dataVenda", modelo.VenDataVenda);
                cmd.Parameters.AddWithValue("@valorTotal", modelo.VenValorTotal);
                cmd.Parameters.AddWithValue("@valorRecebido", modelo.VenValorRecebido);
                cmd.Parameters.AddWithValue("@observacao", modelo.VenObservacao);
                cmd.Parameters.AddWithValue("@codUsuario", modelo.VenCodUsuario);
                _conexao.Conectar();
                modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro na Inclusão de Venda.");
            }
            finally
            {
                _conexao.Desconectar();
            }
        }

        public void Alterar(ModelVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"UPDATE ven_venda
                                    SET    ven_data_venda = @dataVenda,
                                           ven_valor_total = @valorTotal,
                                           ven_valor_recebido = @valorRecebido,
                                           ven_observacao = @observacao,
                                           ven_cod_usuario = @codUsuario
                                    WHERE  ven_cod = @codigo ";
                cmd.Parameters.AddWithValue("@dataVenda", modelo.VenDataVenda);
                cmd.Parameters.AddWithValue("@valorTotal", modelo.VenValorTotal);
                cmd.Parameters.AddWithValue("@valorRecebido", modelo.VenValorRecebido);
                cmd.Parameters.AddWithValue("@observacao", modelo.VenObservacao);
                cmd.Parameters.AddWithValue("@codUsuario", modelo.VenCodUsuario);
                cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro na Edição de Venda.");
            }
            finally
            {
                _conexao.Desconectar();
            }
        }

        public void Excluir(ModelVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"DELETE FROM ven_venda
                                    WHERE ven_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
                _conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro na Exclusão de Venda.");
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
                                                        FROM   ven_venda
                                                        WHERE  ven_cod = {codigo}
                                                        ", _conexao.ObjetoConexao);
                da.Fill(tabela);
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Venda.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return tabela;
        }

        public ModelVenda CarregaModeloVenda(int codigo)
        {
            ModelVenda modelo = null;
            try
            {                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conexao.ObjetoConexao;
                cmd.CommandText = @"SELECT *
                                FROM ven_venda
                                WHERE ven_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                _conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    modelo = new ModelVenda();
                    modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                    modelo.VenDataVenda = Convert.ToDateTime(registro["ven_data_venda"]);
                    modelo.VenValorTotal = Convert.ToDouble(registro["ven_valor_total"]);
                    modelo.VenValorRecebido = Convert.ToDouble(registro["ven_valor_recebido"]);
                    modelo.VenObservacao = Convert.ToString(registro["ven_observacao"]);
                    modelo.VenCodUsuario = Convert.ToInt32(registro["ven_cod_usuario"]);
                }
            }
            catch /*(Exception erro)*/
            {
                throw new Exception("Erro ao recuperar Venda.");
            }
            finally
            {
                _conexao.Desconectar();
            }
            return modelo;
        }

    }
}
