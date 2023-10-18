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

namespace Apr3nd3 {
	/// <summary>
	/// Lógica de interacción para Docente.xaml
	/// </summary>
	public partial class Docente : Window {
		public Docente() {
			InitializeComponent();
		}

        private void Registro_Click(object sender, RoutedEventArgs e)
        {
			Iniciar w = new Iniciar();
			this.Hide();
			w.Show();
		}
    }
}
