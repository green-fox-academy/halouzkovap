using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
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


            // DrawTriangle(140, 155, 140);
            //DrawRectangle(0, 0, 30, 50);
            // DrawSquere(0, 0, 50);

            //DrawCenter(50, foxDraw);

            //PurpleSteps(10, foxDraw);

            PurpleSteps3D(10, foxDraw);

            // LineToCenter(20, 20, foxDraw);
            var points = new List<Point> { new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290) };

            var pointsC = new List<Point> { new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70), new Point(120, 100), new Point(85, 130), new Point(50, 100) };
            //ConnectDots(pointsC, foxDraw);
            //NightSky(foxDraw);


        }
        public void NightSky(FoxDraw foxDraw)
        {
            // Draw the night sky:
            //  - The background should be black
            foxDraw.SetBackgroundColor(Colors.Black);
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            var random = new Random();
            int a = random.Next(1, 100);
            for (int i = 0; i < a; i++)
            {
                int x = random.Next(0, 300 - 10);
                int y = random.Next(0, 300 - 10);
                foxDraw.SetFillColor(Colors.Gray);
                foxDraw.DrawRectangle(x, y, 10, 10);
                x = 0;
                y = 0;
            }
            //  - The stars should have random color (some shade of grey)
        }
        public void ConnectDots(List<Point> list, FoxDraw foxDraw)
        {
            // Create a function that takes 2 parameters:
            // A list of (x, y) points and foxDraw
            // and connects them with green lines.
            var dots = new List<Point>();
            for (int i = 0; i < list.Count; i++)
            {


                dots.Add(list[i]);
            }
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.SetFillColor(Colors.White);
            foxDraw.DrawPolygon(dots);


        }
        public void LineToCenter(int x, int y, FoxDraw foxDraw)
        {
            // Create a function that draws a single line and takes 3 parameters:
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.


            for (int i = 0; i <= 300; i += 20)
            {
                foxDraw.DrawLine(0, 0 + i, 150, 150);
                foxDraw.DrawLine(0 + i, 0, 150, 150);
                foxDraw.DrawLine(300, 0 + i, 150, 150);
                foxDraw.DrawLine(0 + i, 300, 150, 150);


            }

        }
        public void PurpleSteps3D(int x, FoxDraw foxDraw)
        {

            int tem = 0;
            int a = 0;
            for (int i = 1; i < 6; i++)
            {
                tem += a;
                foxDraw.SetFillColor(Colors.Violet);
                foxDraw.DrawRectangle(tem, tem, x * i, x * i);

                a += (x * 1);

            }

        }
        public void PurpleSteps(int x, FoxDraw foxDraw)
        {


            for (int i = 0; i < 10; i++)
            {
                foxDraw.SetFillColor(Colors.Violet);
                foxDraw.DrawRectangle(0 + (i * x), 0 + (i * x), x, x);



            }

        }
        public void DrawRainbowSquere(int x, FoxDraw foxDraw)
        {
            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).
            var random = new Random();
            int a;
            foxDraw.DrawRectangle(x, x, x, x);
            for (int i = 0; i < 2; i++)
            {
                a = random.Next(0, 250);
                foxDraw.DrawRectangle(x + a, x + a, x, x);

                foxDraw.SetFillColor(Colors.Violet);

            }

        }
        public void DrawCenter(int x, FoxDraw foxDraw)
        {
            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.
            var random = new Random();
            int a;
            foxDraw.DrawRectangle(x, x, x, x);
            for (int i = 0; i < 2; i++)
            {
                a = random.Next(0, 250);
                foxDraw.DrawRectangle(x + a, x + a, x, x);

                foxDraw.SetFillColor(Colors.LightPink);

            }

        }
        public void DrawSquere(int x, int y, int w)
        {
            // create a function that draws one square and takes 3 parameters:
            // the x and y coordinates of the square's top left corner
            // and the foxDraw and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.
            var random = new Random();
            int a;
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            for (int i = 0; i < 3; i++)
            {
                a = random.Next(0, 250);
                foxDraw.DrawRectangle(x + a, y + a, w + a, w + a);

                foxDraw.SetFillColor(Colors.LightPink);

            }

        }
        public void DrawRectangle(int x, int y, int w, int h)
        {
            // draw four different triangles.
            // avoid code duplication.
            var random = new Random();
            int a;
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            for (int i = 0; i < 4; i++)
            {
                a = random.Next(0, 300);
                foxDraw.DrawRectangle(x + a, y + a, w + a, h + a);

                foxDraw.SetFillColor(Colors.Green);

            }

        }
        public void DrawTriangle(int x, int z, int v)
        {
            // draw four different triangles.
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
