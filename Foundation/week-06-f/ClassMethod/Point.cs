using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethod
{
    public class Point
    {
        public int Y;
        public int X;

        public Point(int x, int y)
        {
            this.Y = y;
            this.X = x;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }
            Move(newLocation.X, newLocation.Y);
        }
    }
}
