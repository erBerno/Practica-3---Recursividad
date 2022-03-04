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

namespace Practica3Recursividad___Ejercicio5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            funcionRecursiva(3, 2);
        }

        int funcionRecursiva(int a, int b)
        {
            if (a < b)
            {
                return 0;
            } 
            else
            {
                int res = funcionRecursiva(a - b, b) + 1;
                txtResultado.Text = res.ToString();
                return res;
            }          
        }
    }
}
