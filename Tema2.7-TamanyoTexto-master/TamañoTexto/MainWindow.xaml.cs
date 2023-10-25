using System;
using System.Windows;
using System.Windows.Controls;

namespace TamañoTexto
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton seleccionado = sender as RadioButton;
            TituloTextBox.FontSize = Double.Parse(seleccionado.Tag.ToString());
        }
    }
}
