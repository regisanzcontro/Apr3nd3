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
using System.Windows.Shapes;

namespace Apr3nd3
{
    /// <summary>
    /// Lógica de interacción para IniciarEst.xaml
    /// </summary>
    public partial class IniciarEst : Window
    {
        public IniciarEst()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuEstud w = new MenuEstud();
            this.Hide();
            w.Show(); 
        }
    }
}
