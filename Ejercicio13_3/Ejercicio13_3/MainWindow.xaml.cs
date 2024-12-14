using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ejercicio13_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // Configurar ToolTip inicial
            if (ColorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                ToolTipService.SetToolTip(ColorComboBox, selectedItem.Tag);
            }
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                ToolTipService.SetToolTip(ColorComboBox, selectedItem.Tag);
            }
        }
    }
}