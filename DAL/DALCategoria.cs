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
        public void Incluir (ModelCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObjetoConexao;
            cmd.CommandText = "Insert into cat_categoria(cat_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            _conexao.Conectar();
            modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());
            _conexao.Desconectar();
        }
        public void Alterar (ModelCategoria modelo)
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
        public void Excluir (ModelCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObjetoConexao;
            cmd.CommandText = "Delete from cat_categoria where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
            _conexao.Conectar();
            cmd.ExecuteNonQuery();
            _conexao.Desconectar();
        }

        public DataTable RecuperarPorNome (String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from cat_categoria where cat_nome like '%" + valor+"%'", _conexao.ObjetoConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModelCategoria CarregaModeloCategoria (int codigo)
        {
            ModelCategoria modelo = new ModelCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObjetoConexao;
            cmd.CommandText = "Select * from cat_categoria where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            _conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if(registro.HasRows)
            {
                registro.Read();
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.CatNome = Convert.ToString(registro["cat_nome"]);
            }
            _conexao.Desconectar();
            return modelo;
        }
    }
}
