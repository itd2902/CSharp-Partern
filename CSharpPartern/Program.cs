using System;
using System.Threading.Tasks;

namespace CSharpPartern
{
    public class Program
    {
        public enum Directions
        {
            Up,
            Down,
            Right,
            Left
        }

        public enum Orientation
        {
            North,
            South,
            East,
            West
        }
        public static void Main(string[] args)
        {
            var direction = Directions.Right;
            Console.WriteLine($"Map view direction is {direction}");
            var orientation = direction switch
            {
                Directions.Up => Orientation.North,
                Directions.Down => Orientation.South,
                Directions.Left => Orientation.West,
                Directions.Right => Orientation.East,
                _ => throw new NotImplementedException()
            };
            var (_, beta) = ("a", "b");
            Console.WriteLine(beta);
            Point point = new Point(3, 5);
            (double X, double Y) = point;
            Console.WriteLine(X + "," + Y);
            Console.ReadKey();

        }
        public class Point
        {
            public Point(double x, double y) => (X, Y) = (x, y);
            public double X { get; set; }
            public double Y { get; set; }
            public void Deconstruct(out double x, out double y) => (x, y) = (X, Y);
        }
    }
}
