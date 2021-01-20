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

        public void ConsistenciaCamposMonetarios(object sender, EventArgs e, TextBox tboxValor)
        {
            try
            {
                tboxValor.Text = Convert.ToDouble(tboxValor.Text).ToString("C");
            }
            catch
            {
                tboxValor.Text = "";
            }
        }

        public void EnterCamposMonetarios(object sender, EventArgs e, TextBox tboxValor)
        {
            String x = "";
            for (int i = 0; i <= tboxValor.Text.Length - 1; i++)
            {
                if ((tboxValor.Text[i] >= '0' &&
                    tboxValor.Text[i] <= '9') ||
                    tboxValor.Text[i] == ',')
                {
                    x += tboxValor.Text[i];
                }
            }
            tboxValor.Text = x;
            tboxValor.SelectAll();
        }

    }
}
