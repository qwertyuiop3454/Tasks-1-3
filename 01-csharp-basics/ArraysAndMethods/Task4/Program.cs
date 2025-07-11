int GetSumOfElementsOnEvenPositions(int[,] a)
{
    int sum = 0;
    for(int i = 0; i <a.GetLength(0); i++)
    {
        
        for(int j = 0; j < a.GetLength(1); j++)
        {
            if ((i + j) % 2 == 0)
            {
                sum += a[i,j];
            }
            
        }
    }
    return sum;
}

int[,] b = new int[3, 4];

for (int i = 0; i < b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        
        Random rnd = new Random();
        b[i, j] = rnd.Next(-100, 100);
    }

}

for (int i = 0; i<b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        Console.Write(b[i, j] + " ");

    }
    Console.WriteLine();
}

Console.WriteLine(GetSumOfElementsOnEvenPositions(b));





