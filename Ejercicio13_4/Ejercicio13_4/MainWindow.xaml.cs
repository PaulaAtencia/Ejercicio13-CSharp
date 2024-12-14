using System.Windows;
using System.Windows.Controls;

namespace Ejercicio13_4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, RoutedEventArgs e)
        {
            if (frutaComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string fruta = selectedItem.Content.ToString();
                MessageBoxResult result = MessageBox.Show($"¿Quieres confirmar tu selección de {fruta}?", "Confirmación", MessageBoxButton.YesNoCancel);

                switch (result)
                {
                    case MessageBoxResult.Yes:
                        MessageBox.Show($"Has confirmado {fruta}");
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show($"Has rechazado {fruta}");
                        break;
                    case MessageBoxResult.Cancel:
                        MessageBox.Show("No se realizó ninguna acción.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fruta.");
            }
        }
    }
}