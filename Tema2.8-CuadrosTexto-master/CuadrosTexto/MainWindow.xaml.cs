using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NombreTextBox.Tag = AyudaNombreTextBlock;
            ApellidoTextBox.Tag = AyudaApellidoTextBlock;
        }

        private void Ayuda_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox campo = sender as TextBox;
            TextBlock ayuda = campo.Tag as TextBlock;

            if (e.Key == Key.F1)
            {
                ayuda.Visibility = ayuda.Visibility == Visibility.Visible?Visibility.Hidden:Visibility.Visible;
            }
        }

        private void Edad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if (Int32.TryParse(EdadTextBox.Text, out _))
                {
                    MensajeEdadTextBlock.Visibility = Visibility.Hidden;
                }
                else
                {
                    MensajeEdadTextBlock.Visibility = Visibility.Visible;
                }
            }
        }

    }
}
