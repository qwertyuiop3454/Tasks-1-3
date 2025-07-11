internal class Program
{

    private static int[] GenerateArray()
    {
        int[] a = new int[10];
        Random b = new Random();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = b.Next(-100, 100);
        }
        return (a);
    }

    private static void PrintArray(int[] d)
    {
        for (int i = 0; i < d.Length; i++)
        {
            Console.WriteLine(d[i]);
        }
    }

    private static int[] SortAndGetMinAndMaxValues(int[] e, out int min, out int max)
    {
        for (int j = 0; j < e.Length; j++)
        {
            for (int i = 0; i < e.Length - 1; i++)
            {
                if (e[i] > e[i + 1])
                {
                    int f = e[i + 1];
                    e[i + 1] = e[i];
                    e[i] = f;

                }
            }
        }
        min = e[0];
        max = e[e.Length - 1];
        return (e);



    }
    private static void Main(string[] args)
    {
        int a1 = 0, a2 = 0;

        int[] c = GenerateArray();

        PrintArray(c);

        SortAndGetMinAndMaxValues(c, out a1, out a2);
        Console.WriteLine();

        PrintArray(c);

        Console.WriteLine();

        Console.WriteLine(a1);
        Console.WriteLine(a2);
    }

}



