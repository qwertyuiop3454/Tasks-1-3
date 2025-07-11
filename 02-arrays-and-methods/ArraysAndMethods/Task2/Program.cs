using System.Text.Json.Serialization;

internal class Program
{
    private static void ReplacePositiveElementsWithZero(int[,,] b)
    {
        for(int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(2); k++)
                {
                    if (b[i,j,k] > 0)
                    {
                        b[i, j, k] = 0;
                    }
                }
            }
        }
    }

    private static void Main(string[] args)
    {
        Random c = new Random();
        int[,,] a = new int[5, 5, 5];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                for (int k = 0; k < a.GetLength(2); k++)
                {
                    a[i, j, k] = c.Next(-50, 50);
                    
                }
            }
        }


        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                for (int k = 0; k < a.GetLength(2); k++)
                {
                    Console.WriteLine(a[i, j, k]);
                    
                    
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        ReplacePositiveElementsWithZero(a);

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                for (int k = 0; k < a.GetLength(2); k++)
                {
                    Console.WriteLine(a[i, j, k]);

                }
            }
        }
    }
}


