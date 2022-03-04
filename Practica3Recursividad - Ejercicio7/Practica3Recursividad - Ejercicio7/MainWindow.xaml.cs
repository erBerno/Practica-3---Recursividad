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

namespace Practica3Recursividad___Ejercicio7
{
    /// <summary>
    /// ¿Cuál es el resultado de esta función para distintos valores de x?
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int f(int x) 
        {
            if (x > 100)
            {
                int o1 = (x - 10);
                return o1;
            }
            else
            {
                int o2 = (f(f(x + 11)));
                return o2;
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            lstShow.Items.Clear();

            for (int i = 0; i < 200; i++)
            {
                lstShow.Items.Add("---------------------------------------------");
                lstShow.Items.Add("Número " + i);
                lstShow.Items.Add("Resultado: " + f(i));
            }                    
        }
    }
}
