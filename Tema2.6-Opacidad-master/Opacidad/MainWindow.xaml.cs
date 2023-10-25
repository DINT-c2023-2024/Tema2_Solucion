using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Opacidad
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

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image cartel = (Image)sender;
            cartel.Opacity = 1;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Image cartel = (Image)sender;
            cartel.Opacity = 0.5;
        }
    }
}
