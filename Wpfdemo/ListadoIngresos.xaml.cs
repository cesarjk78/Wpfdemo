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
    public partial class ListadoIngresos : Window
    {
        public ListadoIngresos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgIngresos.ItemsSource = new List<dynamic>
            {
                new { Fecha="28/08/2025", Placa="XYZ-123", Turno="Mañana", Conductor="Juan Pérez", Producto="Cemento", Peso="1500 Kg", Transporte="Camión"},
                new { Fecha="28/08/2025", Placa="ABC-456", Turno="Tarde", Conductor="Luis García", Producto="Arena", Peso="2000 Kg", Transporte="Furgón"}
            };
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aquí aplicarías filtros de búsqueda con LINQ o base de datos.");
        }
    }
}
