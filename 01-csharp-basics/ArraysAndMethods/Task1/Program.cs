int[] GenerateArray()
{
    int[] a = new int[8];
    for(int i = 0; i < a.Length; i++)
    {
        Random rnd = new Random();
        a[i] = rnd.Next(1, 100);
    }
    return a;
}

int[] SortAndGetMinAndMaxValues(int[] a, out int min, out int max)
{
    int g = 0;
    for(int j = 0; j < a.Length; j++)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] > a[i + 1])
            {
                int u = 0;
                u = a[i];
                a[i] = a[i + 1];
                a[i + 1] = u;
            }
        }
    }
    min = a[0];
    max = a[a.Length - 1];
    return a;
}
void PrintArray(int[] a)
{
    for(int j = 0; j < a.Length; j++)
    {
        Console.WriteLine(a[j]);
    }
}

int[] m = GenerateArray();
PrintArray(m);
Console.WriteLine();
int min, max;
PrintArray(SortAndGetMinAndMaxValues(m,out min, out max));
Console.WriteLine();
Console.WriteLine(min);
Console.WriteLine(max);




