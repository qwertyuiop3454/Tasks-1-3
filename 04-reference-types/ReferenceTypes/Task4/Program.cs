internal class Program
{
    class MyString
    {
        private char[] c;
        public MyString() { }
        public MyString(string a)
        {
            c = new char[a.Length];
            for(int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
        }
        public MyString(char[] a)
        {
            c = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
        }
        public static MyString operator +(MyString a, MyString b)
        {
            string e = a.ToString();
            string f = b.ToString();
            return new MyString(e + f);
        }
        public static MyString operator -(MyString a, MyString b)
        {
            string g = "";
            for(int i = 0; i < a.ToString().Length; i++)
            {
                bool q = true;
                for(int j = 0; j < b.ToString().Length; j++)
                {
                    if (a.ToString()[i] == b.ToString()[j])
                    {
                        q = false;
                        break;
                    }
                }
                if(q)
                {
                    g += a.ToString()[i];
                }
            }
            return new MyString(g);
        }
        public override string ToString() => new string(c);
        
    }
    private static void Main(string[] args)
    {
        string c = "Hello world";
        char[] d = {'a','b','c','d','e'};
        MyString a = new MyString(c);
        MyString b = new MyString(d);
        Console.WriteLine(b.ToString());
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
    }
}