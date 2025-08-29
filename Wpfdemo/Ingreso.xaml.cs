using System;
using System.Collections.Generic;
using System.Globalization;
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
    public partial class Ingreso : Window
    {
        public Ingreso()
        {
            InitializeComponent();
            dpFecha.SelectedDate = DateTime.Now.Date;
            txtHora.Text = DateTime.Now.ToString("HH:mm");
            cbTipoDocumento.SelectedIndex = 0;
            cbTurno.SelectedIndex = 0;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Validación simple
            if (string.IsNullOrWhiteSpace(txtNumeroDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                string.IsNullOrWhiteSpace(txtNombreConductor.Text) ||
                string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Validar hora simple
            if (!TimeSpan.TryParse(txtHora.Text.Trim(), out var hora))
            {
                MessageBox.Show("Hora inválida. Formato HH:mm", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Validar peso
            if (!double.TryParse(txtPeso.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out var peso))
            {
                // intentar con cultura actual
                if (!double.TryParse(txtPeso.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out peso))
                {
                    MessageBox.Show("Peso inválido.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }

            // Simulación de guardar
            MessageBox.Show("Ingreso guardado (simulado).", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            // Si quieres almacenar en una lista en memoria, lo hacemos en el siguiente paso :)
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            cbTipoDocumento.SelectedIndex = 0;
            txtNumeroDocumento.Clear();
            txtPlaca.Clear();
            cbTurno.SelectedIndex = 0;
            txtNombreConductor.Clear();
            txtNombreCliente.Clear();
            dpFecha.SelectedDate = DateTime.Now.Date;
            txtHora.Text = DateTime.Now.ToString("HH:mm");
            txtPeso.Clear();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            var ops = new Operaciones();
            ops.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

