using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public class UtilitariosForms
    {
        public void ControleCamposMonetarios(object sender, KeyPressEventArgs e, TextBox tboxValor)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!tboxValor.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        public void ConsistenciaCamposMonetarios(TextBox tboxValor)
        {
            try
            {
                tboxValor.Text = RemoverStringCamposMonetarios(tboxValor.Text);
                tboxValor.Text = Convert.ToDouble(tboxValor.Text).ToString("C");
            }
            catch
            {
                tboxValor.Text = "";
            }
        }

        public string RemoverStringCamposMonetarios(string tboxValor)
        {
            String x = "";
            for (int i = 0; i <= tboxValor.Length - 1; i++)
            {
                if ((tboxValor[i] >= '0' &&
                    tboxValor[i] <= '9') ||
                    tboxValor[i] == ',')
                {
                    x += tboxValor[i];
                }
            }
            tboxValor = x;
            return tboxValor;
            //tboxValor.SelectAll();
        }

    }
}
