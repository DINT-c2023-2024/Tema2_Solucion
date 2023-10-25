using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FormatoTexto
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

        private void TextoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextoFormatoTextBlock.Text = TextoTextBox.Text;
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextoFormatoTextBlock.FontWeight = FontWeights.Bold;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoFormatoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextoFormatoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoFormatoTextBlock.FontStyle = FontStyles.Normal;
        }

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoFormatoTextBlock.Foreground = new SolidColorBrush(Colors.Blue);
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoFormatoTextBlock.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoFormatoTextBlock.Foreground = new SolidColorBrush(Colors.Green);
        }
    }
}
