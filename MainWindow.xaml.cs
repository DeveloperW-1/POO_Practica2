﻿using System;
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
using System.IO;

namespace POO_Practica2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void miCalculadora_Click(object sender, RoutedEventArgs e)
        {
            Practicas.formCalculadora x = new Practicas.formCalculadora();

            x.Show();
        }

        private void miFiguras_Click(object sender, RoutedEventArgs e)
        {
            Practicas.formFiguras x = new Practicas.formFiguras();

            x.Show();
        }

        private void miCategorias_Click(object sender, RoutedEventArgs e)
        {
            Practicas.frmCategorias x = new Practicas.frmCategorias();
            x.Show();
        }

        private void miRegiones_Click(object sender, RoutedEventArgs e)
        {
            Datos.frmRegion x = new Datos.frmRegion();
            x.Show();
        }
    }
}