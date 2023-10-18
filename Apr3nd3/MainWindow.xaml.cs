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

namespace Apr3nd3 {
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

        private void BtIniciar_Click(object sender, RoutedEventArgs e)
        {
			Registrarse w = new Registrarse();
			this.Hide(); 
			w.Show(); 
        }

        private void BtRegistrarse_Click(object sender, RoutedEventArgs e)
        {
			IniResEstudiante w = new IniResEstudiante();
			this.Hide(); ;
			w.Show(); 
        }
    }
}
