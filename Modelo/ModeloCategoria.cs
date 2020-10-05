using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
        public ModeloCategoria()
        {
            CatCod = 0;
            CatNome = "";
        }

        public ModeloCategoria(int catCod, string catNome)
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
