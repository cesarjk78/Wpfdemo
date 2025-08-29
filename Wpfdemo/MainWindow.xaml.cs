using System.Windows;

namespace Wpfdemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento ligado al XAML: Click="Ingresar_Click"
        private void Ingresar_Click(object sender, RoutedEventArgs e)
        {
            var user = txtUsuario.Text.Trim();
            var pass = txtPassword.Password.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Credenciales de prueba:
            if (user == "admin" && pass == "1234")
            {
                var menu = new MainMenu();
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Evento ligado al XAML: Click="Salir_Click"
        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
