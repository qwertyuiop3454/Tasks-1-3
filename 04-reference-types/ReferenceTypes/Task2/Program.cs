internal class Program
{
    class Round
    {
        public int _radius;
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Радиус не должен быть отрицательным");
                }
                _radius = value;
            }
        }
        public int X { get; set; }
        public int Y { get; set; }
        public double Circumference
        {
            get
            {
                return Radius * 2 * Math.PI;
            }
        }
        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
        public Round(int radius, int x, int y)
        {
            Radius = radius;
            X = x;
            Y = y;
        }
    }
    private static void Main(string[] args)
    {
        Round a = new Round(6, 2, 2);
        Console.WriteLine(a.Radius);
        Console.WriteLine(a.Circumference);
        Console.WriteLine(a.Area);

    }
}
