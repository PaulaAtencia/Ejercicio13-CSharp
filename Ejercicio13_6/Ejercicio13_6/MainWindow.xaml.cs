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

namespace Ejercicio13_6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ThemeComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var selectedTheme = (sender as System.Windows.Controls.ComboBox).SelectedItem as System.Windows.Controls.ComboBoxItem;
            if (selectedTheme != null)
            {
                switch (selectedTheme.Content.ToString())
                {
                    case "Claro":
                        this.Background = Brushes.White;
                        TextBlockDemo.Foreground = Brushes.Black;
                        TextBlockDemo.FontSize = 16;
                        break;
                    case "Oscuro":
                        this.Background = Brushes.Black;
                        TextBlockDemo.Foreground = Brushes.White;
                        TextBlockDemo.FontSize = 18;
                        break;
                    case "Azul":
                        this.Background = Brushes.Blue;
                        TextBlockDemo.Foreground = Brushes.White;
                        TextBlockDemo.FontSize = 16;
                        break;
                }
            }
        }
    }
}
