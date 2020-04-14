using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace DrawingX1
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);


            int count = 15;
            int size = 300;
            int stepSize = size / count;

            for (int i = 1; i < count; i++)
            {
                foxDraw.SetStrokeColor(Colors.Violet);
                foxDraw.DrawLine(i * stepSize, 0, size, i * stepSize);
                foxDraw.SetStrokeColor(Colors.Green);

                foxDraw.DrawLine(0, i * stepSize, i * stepSize, size);

                //foxDraw.DrawLine(10, i * stepSize, (i * stepSize) + 30, 290);
            }



        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
