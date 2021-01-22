using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelSubCategoria
    {
        public ModelSubCategoria()
        {
            ScatCod = 0;
            ScatNome = "";
            ScatCodCategoria = 0;
        }

        public ModelSubCategoria(int scatCod, int scatCodCategoria, string scatNome)
        {
            ScatCod = scatCod;
            ScatNome = scatNome;
            ScatCodCategoria = scatCodCategoria;
        }

        private int scat_cod;
        private String scat_nome;
        private int scat_cod_categoria;


        public int ScatCod { get => scat_cod; set => scat_cod = value; }
        public string ScatNome { get => scat_nome; set => scat_nome = value; }
        public int ScatCodCategoria { get => scat_cod_categoria; set => scat_cod_categoria = value; }
    }

}
