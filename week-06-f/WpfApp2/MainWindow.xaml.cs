using System.Windows;

namespace WpfApp2
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

        private void myFistBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome to XAML");
        }
    }
}
