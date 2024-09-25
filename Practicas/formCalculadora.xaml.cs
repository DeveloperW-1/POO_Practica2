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
    /// Lógica de interacción para formCalculadora.xaml
    /// </summary>
    public partial class formCalculadora : Window
    {
        public formCalculadora()
        {
            InitializeComponent();
        }
        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {

            decimal valor1 = Convert.ToDecimal(txtValor1.Text);
            decimal valor2 = Convert.ToDecimal(txtValor2.Text);

            clOperaciones op = new clOperaciones();

            op.Valor1 = valor1;
            op.Valor2 = valor2;

            decimal result = op.suma();

            txtResultado.Text = result.ToString();
        }

        private void btnResta_Click(object sender, RoutedEventArgs e)
        {
            decimal valor1 = Convert.ToDecimal(txtValor1.Text);
            decimal valor2 = Convert.ToDecimal(txtValor2.Text);

            clOperaciones op = new clOperaciones();

            op.Valor1 = valor1;
            op.Valor2 = valor2;

            decimal result = op.resta();

            txtResultado.Text = result.ToString();
        }

        private void btnMultiplicacion_Click(object sender, RoutedEventArgs e)
        {
            decimal valor1 = Convert.ToDecimal(txtValor1.Text);
            decimal valor2 = Convert.ToDecimal(txtValor2.Text);

            clOperaciones op = new clOperaciones();

            op.Valor1 = valor1;
            op.Valor2 = valor2;

            decimal result = op.multiplicacion();

            txtResultado.Text = result.ToString();
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            decimal valor1 = Convert.ToDecimal(txtValor1.Text);
            decimal valor2 = Convert.ToDecimal(txtValor2.Text);

            clOperaciones op = new clOperaciones();

            op.Valor1 = valor1;
            op.Valor2 = valor2;

            decimal result = op.division();

            txtResultado.Text = result.ToString();
        }
    }
}
