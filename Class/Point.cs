using System;

namespace ConsoleApplication.Class
{
    public class Point
    {
        public int X, Y;

        public Point(int x , int y)
        {
            this.X = x;
            this.Y = y;
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
                throw new ArgumentException("newLocation");
            }

            /* this line is passing an object of Point as parameter (in this case is "newLocation") 
            to the another Method ( in this case is   Move(int x, int y)   on line 15) */
            Move(newLocation.X, newLocation.Y);
        }
    }
}
