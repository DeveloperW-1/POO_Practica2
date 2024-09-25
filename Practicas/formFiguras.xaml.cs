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
using System.Windows.Shapes;

namespace POO_Practica2.Practicas
{
    /// <summary>
    /// Lógica de interacción para formFiguras.xaml
    /// </summary>
    public partial class formFiguras : Window
    {
        public formFiguras()
        {
            InitializeComponent();
        }

        private void btnCirculo_Click(object sender, RoutedEventArgs e)
        {
            Clases.clFiguras x = new Clases.clFiguras();

        }

        private void btnTriangulo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCuadrado_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRectangulo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRombo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
