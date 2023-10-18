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
    /// Lógica de interacción para SubirMat.xaml
    /// </summary>
    public partial class SubirMat : Window
    {
        public SubirMat()
        {
            InitializeComponent();
        }

        private void BtNotas_Click(object sender, RoutedEventArgs e)
        {
            Notas w = new Notas();
            this.Hide();
            w.Show();
        }

        private void BtExamen_Click(object sender, RoutedEventArgs e)
        {
            Examen w = new Examen();
            this.Hide();
            w.Show(); 
        }
    }
}
