using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public String StringDeConexao { get => String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", servidor, banco, usuario, senha); }
        
        public String Servidor { get => servidor; set => servidor = value; }
        public String Banco { get => banco; set => banco = value; }
        public String Usuario { get => usuario; set => usuario = value; }
        public String Senha { get => senha; set => senha = value; }

        private String servidor;
        private String banco;
        private String usuario;
        private String senha;

        public DadosDaConexao(String servidor, String banco, String usuario, String senha)
        {
            this.Servidor = servidor;
            this.Banco = banco;
            this.Usuario = usuario;
            this.Senha = senha;
        }

    }

}
