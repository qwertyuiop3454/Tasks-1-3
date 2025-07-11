internal class Program
{

    public static int GetSumOfNonNegativeElements(int[] b)
    {
        int sum = 0;
        for(int i = 0; i < b.Length; i++)
        {
            if (b[i] > 0)
            {
                sum += b[i];
            }
        }
        return (sum);

    }
    private static void Main(string[] args)
    {
        int[] a = new int[10];
        Random c = new Random();

        for(int i = 0; i < a.Length; i++)
        {
            a[i] = c.Next(-10, 10);
        }

        for(int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }

        int d = GetSumOfNonNegativeElements(a);
        Console.WriteLine(d);
        
    }
}