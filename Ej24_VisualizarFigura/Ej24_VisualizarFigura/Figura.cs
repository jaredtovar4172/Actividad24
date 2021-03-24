using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ej24_VisualizarFigura
{
    class Figura
    {
        public void ImprimirFigura(ListBox lista)
        {
            string cadena = "";
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    cadena = cadena + "*";
                }
                lista.Items.Add(cadena);
                cadena = "";
            }
        }
    }
}
