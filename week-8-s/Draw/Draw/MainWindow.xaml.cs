using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

namespace Draw
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
            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(100, 100, 200, 100);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(200, 100, 200, 200);
            foxDraw.SetStrokeColor(Colors.Red);

            foxDraw.DrawLine(200, 200, 100, 200);
            foxDraw.SetStrokeColor(Colors.Black);

            foxDraw.DrawLine(100, 200, 100, 100);

            // Draw a box that has different colored lines on each edge.

            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, 400, 400);

            // Draw a green 10x10 square to the canvas' center.
            static void DrawGreenPolygon(FoxDraw foxDraw)
            {
                var points = new List<Point>();
                points.Add(new Point(10, 10));
                points.Add(new Point(20, 10));
                points.Add(new Point(20, 30));
                points.Add(new Point(20, 10));
                foxDraw.SetFillColor(Colors.Green);
                foxDraw.DrawPolygon(points);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}