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

namespace Wpfdemo
{
    public partial class Operaciones : Window
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void BtnIngresos_Click(object sender, RoutedEventArgs e)
        {
            var win = new Ingreso();
            win.Show();
            this.Close();
        }

        private void BtnSalidas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ventana de Salidas (pendiente).", "Salidas", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            var menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

