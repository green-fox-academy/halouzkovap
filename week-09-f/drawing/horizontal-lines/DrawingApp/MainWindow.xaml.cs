using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

namespace DrawingApp
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

            // foxDraw.DrawLine(x, y, 150, 150);

            //DrawCenter(10, 20);


            DrawRectangle(140, 155, 140);


        }
        public void DrawRectangle(int x, int z, int v)
        {
            // draw four different size and color rectangles.
            // avoid code duplication.

            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            for (int i = 0; i < 4; i++)
            {
                var points = new List<Point>();
                points.Add(new Point(x + (i * 20), x + (i * 20)));
                points.Add(new Point(z + (i * 20), z + (i * 20)));
                points.Add(new Point(v + (i * 20), z + (i * 20)));

                foxDraw.SetFillColor(Colors.Green);
                foxDraw.DrawPolygon(points);
            }

        }

        //public void Squere()
        //{
        //    var canvas = this.Get<Canvas>("canvas");
        //    var foxDraw = new FoxDraw(canvas);
        //    // Draw a green 10x10 square to the canvas' center.
        //    foxDraw.SetStrokeColor(Colors.Green);
        //    foxDraw.DrawLine(145, 145, 155, 145);
        //    foxDraw.DrawLine(155, 145, 155, 155);
        //    foxDraw.DrawLine(155, 155, 145, 155);
        //    foxDraw.DrawLine(145, 155, 145, 145);
        //}
        public void DrawLine(int x, int y, int z)
        {
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the foxDraw
            // and draws a 50 long horizontal line from that point.
            // Draw at least 3 lines with that function using a loop.
            //DrawLine(10, 20, 50);
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            for (int i = 0; i < 4; i++)
            {
                foxDraw.DrawLine(x, (y + (i * 10)), (x + z), (y + (i * 10)));
            }

        }
        public void DrawCenter(int x, int y)
        {

            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            for (int i = 0; i < 4; i++)
            {
                foxDraw.DrawLine((x + (i * 20)), y, 150, 150);
            }

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

    }
}
