using System.Windows;
using System.Windows.Controls;

namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int maximoCaracteres = 140;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MensajeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CaracteresTextBlock.Text = MensajeTextBox.Text.Length.ToString() + "/" + maximoCaracteres.ToString();

            if (MensajeTextBox.Text.Length == maximoCaracteres)
            {
                MensajeTextBox.IsReadOnly = true;
            }
        }
    }
}
