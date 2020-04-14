using System.Windows;
using System.Windows.Media;

namespace WpfApp1
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

        private void helloBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello word");

        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void fruit_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void welcome_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            welcome.Background = Brushes.Red;
        }
    }
}
