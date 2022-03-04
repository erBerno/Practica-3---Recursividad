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

namespace Practica3Recursividad___Ejercicio4
{
    /// <summary>
    /// Implemente de forma recursiva una función que nos diga si una cadena de caracteres es simétrica (un palíndromo). 
    /// Por ejemplo, “DABALEARROZALAZORRAELABAD” es un palíndromo.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            txtMensaje.Text = "";
            verificarPalindromo(txbPalabra.Text);
        }

        bool verificarPalindromo(string palabra)
        {
            if (palabra.Length == 0 || palabra.Length == 1)
            {
                txtMensaje.Text = "La cadena de texto ingresada es un palindromo.";
                return true;
            }
            else if (palabra[0] != palabra[palabra.Length - 1])
            {
                txtMensaje.Text = "La cadena de texto ingresada no es un palindromo.";
                return false;
            }
            return verificarPalindromo(palabra.Substring(1, palabra.Length - 2));
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txbPalabra.Text = "";
            txtMensaje.Text = "";
        }
    }
}
