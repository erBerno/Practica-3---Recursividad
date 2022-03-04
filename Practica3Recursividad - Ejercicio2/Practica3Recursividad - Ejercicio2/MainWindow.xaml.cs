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

namespace Practica3Recursividad___Ejercicio2
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

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            lstShow.Items.Clear();
            GenerarMensaje(txbMensaje.Text, txbMensaje.Text.Length - 1);
        }

        string GenerarMensaje(string mensaje, int letra)
        {
            if (letra == 0)
            {
                lstShow.Items.Add(mensaje[0]);
                return mensaje[0].ToString();
            }
            else
            {
                string res = GenerarMensaje(mensaje, letra - 1) + mensaje[letra];
                lstShow.Items.Add(res);
                return res;
            }      
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txbMensaje.Text = "";
            lstShow.Items.Clear();
        }
    }
}
