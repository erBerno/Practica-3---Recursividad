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

namespace Practica3Recursividad___Ejercicio8
{
    /// <summary>
    /// Triangulo de Sierpinsky
    /// Este ejercicio no lo hice yo, es una copia de internet, pero me parecio bastante curioso el ejemplo y decidi guardarmelo.
    /// Disculpe inge, no logre hacer este ejercicio.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        int depth = 0;
        int i = 0;

        private void btnGenerar_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();

            CompositionTarget.Rendering += StartAnimation;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void StartAnimation(object sender, EventArgs e)
        {
            i += 1;
            if (i % 40 == 0)
            {

                Point p1 = new Point(canvas.Width / 2, 10);
                Point p2 = new Point(10, canvas.Height - 10);
                Point p3 = new Point(canvas.Width - 10, canvas.Height - 10);
                DisplayTriangle(canvas, p1, p2, p3, depth);
                depth += 1;
                if (depth > 5)
                {

                    CompositionTarget.Rendering -= StartAnimation;
                }
            }

        }

        private void DisplayTriangle(Canvas canvas, Point p1, Point p2, Point p3, int deep)
        {

            if (deep > 0)
            {
                Point p12 = midpoint(p1, p2);
                Point p23 = midpoint(p2, p3);
                Point p31 = midpoint(p3, p1);

                DisplayTriangle(canvas, p1, p12, p31, deep - 1);
                DisplayTriangle(canvas, p12, p2, p23, deep - 1);
                DisplayTriangle(canvas, p31, p23, p3, deep - 1);

            }
            else
            {
                DrawLine(p1, p2, canvas);
                DrawLine(p1, p3, canvas);
                DrawLine(p2, p3, canvas);
                return;
            }
        }

        private void DrawLine(Point From, Point To, Canvas TargetCanvas)
        {
            Line line = new Line();
            line.Stroke = Brushes.Red;
            line.StrokeThickness = 1.0;
            line.X1 = From.X;
            line.Y1 = From.Y;
            line.X2 = To.X;
            line.Y2 = To.Y;
            TargetCanvas.Children.Add(line);
        }

        private static Point midpoint(Point p1, Point p2)
        {
            return new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }
    }
}
