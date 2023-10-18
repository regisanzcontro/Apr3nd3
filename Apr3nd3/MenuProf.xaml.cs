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

namespace Apr3nd3
{
    /// <summary>
    /// Lógica de interacción para MenuProf.xaml
    /// </summary>
    public partial class MenuProf : Window
    {
        public MenuProf()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditarNotas w = new EditarNotas();
            this.Hide();
            w.Show();
        }

        private void BtSubMat_Click(object sender, RoutedEventArgs e)
        {
            SubirMat w = new SubirMat();
            this.Hide();
            w.Show();
        }

        private void BtBajaMat_Click(object sender, RoutedEventArgs e)
        {
            BajaMat w = new BajaMat();
            this.Hide();
            w.Show();
        }
    }

}
