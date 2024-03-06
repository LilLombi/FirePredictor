using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirePredictor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Calcular(object sender, RoutedEventArgs e)
        {
            if (temperature.Text.Length > 0 && humidity.Text.Length > 0)
            {
                try
                {
                    double t = double.Parse(temperature.Text);
                    double h = double.Parse(humidity.Text);

                    result.Text = MathOperations.chandlerBI(t, h).ToString();
                } 
                catch (FormatException)
                {
                    MessageBox.Show("Comprueba que ambos campos contienen valores numéricos", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}