using System;

namespace TypeMatchingPartern
{
    class Program
    {
        class Rectangle
        {
            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public int Width { get; set; }
            public int Height { get; set; }
        }

        class Cirle
        {
            public int Radius { get; set; }
        }

        class Square
        {
            public int Length { get; set; }
        }
        public static double Acreage(object shape)
            => shape switch
            {
                Rectangle r when r.Width > 10 && r.Height > 10 => r.Width * r.Height,
                Cirle c => Math.PI * Math.Pow(c.Radius, 2),
                Square q => Math.Pow(q.Length, 2),
                _ => 0
            };
        static void Main(string[] args)
        {
            var shape = new Rectangle(12, 11);
            Console.WriteLine(Acreage(shape));
            Console.ReadKey();
        }
    }
}
