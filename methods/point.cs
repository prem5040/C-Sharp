using System;
namespace methods
{
    public class point
    {
        public int X;
        public int Y;

        public point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void move(point newLocation)
        {
            // But there is a problem, if we pass null object, it will throw null reference exception.
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            else
                move(newLocation.X, newLocation.Y);

            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
        }
    }
}