using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;

namespace xp2
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

            int count = 12;
            int size = 150;
            int stepSize = size / count;

            // foxDraw.DrawLine(0, 10, 100, 200);
            for (int i = 0; i < count; i++)
            {

                foxDraw.DrawLine(size, i * stepSize, i * stepSize, size);
                //foxDraw.DrawLine(i * stepSize, size, size, i * stepSize);

            }




            //foxDraw.DrawLine(i * stepSize, 0, size, i * stepSize);


            //foxDraw.DrawLine(0, i * stepSize, i * stepSize, size);



        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
