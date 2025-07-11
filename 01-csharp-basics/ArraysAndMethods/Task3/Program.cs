int GetSumOfNonNegativeElements(int[] a)
{
    int sum = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0)
        {
            sum += a[i];
        }
    }
    return sum;
    
}



int[] a = new int[10];

for(int i = 0; i < a.Length; i++)
{
    Random rnd = new Random();
    a[i] = rnd.Next(-100, 100);
}

int x = GetSumOfNonNegativeElements(a);
for(int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}

Console.WriteLine(x);


