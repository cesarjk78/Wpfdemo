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
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnOperaciones_Click(object sender, RoutedEventArgs e)
        {
            var win = new Operaciones();   // ✅ instancia correctamente
            win.Show();
            this.Close();
        }

        private void BtnMantenimientos_Click(object sender, RoutedEventArgs e)
        {
            var win = new RegistroConductor();   // ✅ instancia correctamente
            win.Show();
        }

        private void BtnReportes_Click(object sender, RoutedEventArgs e)
        {
            var win = new ListadoIngresos();   // ✅ aquí estaba el error
            win.Show();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            var login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
