using System.Windows;
using System.Windows.Media;

namespace Imagen
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


        private void AltaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CartelImage.Opacity = 1;
        }

        private void MediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CartelImage.Opacity = 0.6;
        }

        private void BajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CartelImage.Opacity = 0.3;
        }

        private void FillRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CartelImage.Stretch = Stretch.Fill;
        }

        private void UniformRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CartelImage.Stretch = Stretch.Uniform;
        }

        private void UniformToFillRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CartelImage.Stretch = Stretch.UniformToFill;
        }

        private void NoneRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CartelImage.Stretch = Stretch.None;
        }
    }
}
