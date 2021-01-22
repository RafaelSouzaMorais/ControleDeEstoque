using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelCategoria
    {
        public ModelCategoria()
        {
            CatCod = 0;
            CatNome = "";
        }

        public ModelCategoria(int catCod, string catNome)
        {
            CatCod = catCod;
            CatNome = catNome;
        }

        private int cat_cod;
        private String cat_nome;

        public int CatCod{ get => cat_cod; set => cat_cod = value; }
        public string CatNome{ get => cat_nome; set => cat_nome = value; }
    }
}
