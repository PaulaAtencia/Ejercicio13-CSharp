using System.Windows;
using System.Windows.Controls;

namespace Ejercicio13_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Accion1Button_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("Acción 1 realizada");
        }

        private void Accion2Button_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("Acción 2 realizada");
        }

        private void Accion3Button_Click(object sender, RoutedEventArgs e)
        {
            MostrarMensaje("Acción 3 realizada");
        }

        private void MostrarMensaje(string accion)
        {
            if (CategoriaComboBox.SelectedItem is ComboBoxItem categoriaSeleccionada)
            {
            
                MessageBox.Show($"{accion} en {categoriaSeleccionada.Content}");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría.");
            }
        }
    }
}