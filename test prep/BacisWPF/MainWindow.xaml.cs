using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BacisWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;
            Button btn = new Button();
            btn.Content = "Click me";
            btn.Height = 150;
            btn.Width = 150;

            WrapPanel wrapPanel = new WrapPanel();
            TextBlock txt = new TextBlock();
            txt.Text = "multi";
            txt.Foreground = Brushes.Blue;
            wrapPanel.Children.Add(txt);
            grid.Children.Add(btn);

        }
    }
}
