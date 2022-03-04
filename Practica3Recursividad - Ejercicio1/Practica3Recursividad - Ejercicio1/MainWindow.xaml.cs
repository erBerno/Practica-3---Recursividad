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

namespace Practica3Recursividad___Ejercicio1
{
    /// <summary>
    /// Crear una función recursiva para calcular el capital al cabo de años a partir de un monto inicial el cual gana un interésde x% anual.
    /// Nombre: Bernardo Garcia
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            int monto, porcentaje, años;

            monto = int.Parse(txbMonto.Text);
            porcentaje = int.Parse(txbPorcentaje.Text);
            años = int.Parse(txbCantidadAños.Text);

            CalcularCapital(monto, porcentaje, años);
        }

        public int CalcularCapital(int m, int p, int a)
        {
            if (a == 0)
            {
                lstShow.Items.Add("Año: 0" + "\t" + "Monto Total: " + m);
                return m;
            }
            else
            {
                int capital = CalcularCapital(m, p, a - 1);
                int total = capital + (capital * p) / 100;
                lstShow.Items.Add("Año: " + a + "\t" + "Monto Total: " + total);
                return total;
            }
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txbCantidadAños.Text = "";
            txbMonto.Text = "";
            txbPorcentaje.Text = "";
            lstShow.Items.Clear();
        }
    }
}
