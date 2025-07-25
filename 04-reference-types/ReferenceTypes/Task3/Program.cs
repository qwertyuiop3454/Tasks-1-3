internal class Program
{
    class Triangle
    {
        public int _a;
        public int _b;
        public int _c;
        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int A
        {
            get
            {
                return _a;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Сторона A не должна быть отрицательной");
                }
                _a = value;
                if(B != 0 && C != 0)
                {
                    if(!IsExist())
                    {
                        throw new Exception("Этот треугольник не существует");
                    }
                }
                
                
            }
        }
        public int B
        {
            get
            {
                return _b;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Сторона B не должна быть отрицательной");
                }
                _b = value;
                if (A != 0 && C != 0)
                {
                    if (!IsExist())
                    {
                        throw new Exception("Этот треугольник не существует");
                    }
                }
                
            }
        }
        public int C
        {
            get
            {
                return _c;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Сторона C не должна быть отрицательной");
                }
                _c = value;
                if (A != 0 && B != 0)
                {
                    if (!IsExist())
                    {
                        throw new Exception("Этот треугольник не существует");
                    }
                }
                
            }
        }
        public double GetArea()
        {
            int p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public int GetPerimeter()
        {
            return A + B + C;
        }
        private bool IsExist()
        {
            if(A + B > C && A + C > B && B + C > A)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
    private static void Main(string[] args)
    {
        Triangle a = new Triangle(3, 3, 3);
        Console.WriteLine(a.GetArea());
        Console.WriteLine(a.GetPerimeter());
        a.C = 2;
    }
}