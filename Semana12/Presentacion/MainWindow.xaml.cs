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

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UserControl form = new Forms.ucInicio();

            this.grdMain.Children.Clear();
            this.grdMain.Children.Add(form);
        }

        private void BtnNuevo_Click(object sender, RoutedEventArgs e)
        {
            UserControl form = new Forms.ucNuevoContacto();

            this.grdMain.Children.Clear();
            this.grdMain.Children.Add(form);
        }

        private void BtnInicio_Click(object sender, RoutedEventArgs e)
        {
            UserControl form = new Forms.ucInicio();

            this.grdMain.Children.Clear();
            this.grdMain.Children.Add(form);
        }
    }
}
