using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUnidadeMedida
    {
        public ModeloUnidadeMedida()
        {
            UmedCod = 0;
            UmedNome = "";
        }

        public ModeloUnidadeMedida(int umedCod, string umedNome)
        {
            UmedCod = umedCod;
            UmedNome = umedNome;
        }

        private int umed_cod;
        private String umed_nome;

        public int UmedCod { get => umed_cod; set => umed_cod = value; }
        public string UmedNome { get => umed_nome; set => umed_nome = value; }
    }
}
