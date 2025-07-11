internal class Program
{
    public static int GetSumOfElementsOnEvenPosition(int[,] b)
    {
        int sum = 0;
        for(int i = 0; i < b.GetLength(0); i++)
        {
            for(int j = 0; j < b.GetLength(1); j++)
            {
                if ((i + j) % 2 == 0)
                {
                    sum += b[i, j];
                }
                
            }
        }

        return (sum);
    }

    private static void Main(string[] args)
    {
        int[,] a = new int[3,3];
        Random c = new Random();
        for(int i = 0; i < a.GetLength(0); i++)
        {
            for(int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = c.Next(-10, 10);
            }
        }

        for (int i = 0; i < a.GetLength(0); i++)
        {
            
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }

        int d = GetSumOfElementsOnEvenPosition(a);
        Console.WriteLine(d);
    }
}