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

namespace Ejercicio13_5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ToolTip edadToolTip;

        public MainWindow()
        {
            InitializeComponent();

            // Crear y asignar el ToolTip
            edadToolTip = new ToolTip();
            edadToolTip.Content = "Introduce tu edad (solo números)";
            EdadTextBox.ToolTip = edadToolTip;

            // Suscribirse al evento TextChanged del TextBox
            EdadTextBox.TextChanged += EdadTextBox_TextChanged;
        }

        private void EdadTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(EdadTextBox.Text, out int edad))
            {
                MessageBox.Show("Edad válida", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}