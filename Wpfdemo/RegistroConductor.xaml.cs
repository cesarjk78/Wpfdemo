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
    public partial class RegistroConductor : Window
    {
        public RegistroConductor()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Conductor: {txtNombre.Text}\nLicencia: {txtLicencia.Text}\nTransporte: {txtTransporte.Text}",
                            "Guardado", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
