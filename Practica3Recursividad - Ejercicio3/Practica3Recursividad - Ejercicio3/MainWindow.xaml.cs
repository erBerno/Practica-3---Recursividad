using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica3Recursividad___Ejercicio3
{
    /// <summary>
    /// Sumartodos los números pares positivos desde el 0 hasta n.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, RoutedEventArgs e)
        {
            lstShow.Items.Clear();

            int res = SumarDigitos(int.Parse(txbNumero.Text));
            lstShow.Items.Add("Resultado: " + res);
        }

        int SumarDigitos(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                int numPar;
                int res;

                if (n % 2 == 0)
                {
                    numPar = SumarDigitos(n - 2);
                    res = numPar + n;
                    lstShow.Items.Add("Resultado: " + res);
                    return res;
                }
                else
                {
                    numPar = SumarDigitos(n - 1);
                    return numPar;
                }            
            }
        }
    }
}
