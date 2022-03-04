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

namespace Practica3Recursividad___Ejercicio6
{
    /// <summary>
    /// Dado el siguiente algoritmo recursivo, Y dado un número cualquiera x, ¿qué nos muestra por pantalla la llamada 
    /// a la función recursiva f(x,2)? ¿Cuál sería un nombre más adecuadopara la función f?
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            lstShow.Items.Clear();
            f(int.Parse(txbNum.Text), 2);
        }

        void f(int num, int div) 
        {
            if (num > 1)
            {
                if ((num % div) == 0)
                {
                    lstShow.Items.Add(div);
                    f(num / div, div);
                }
                else
                {
                    f(num, div + 1);
                }
            }                     
        }
    }
}
