
void ReplacePositiveElementsWithZero(int[,,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int q = 0; q < a.GetLength(2); q++)
            {
                if (a[i, j, q] > 0)
                {
                    a[i, j, q] = 0;
                }

            }
        }
    }
}


int[,,] a = new int[2, 3, 4];
for(int i = 0; i<a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int q = 0; q < a.GetLength(2); q++)
        {
            Random rnd = new Random();
            a[i, j, q] = rnd.Next(-100, 100);
        }
    }
}

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int q = 0; q < a.GetLength(2); q++)
        {
            Console.WriteLine(a[i, j, q]);
        }
    }
}

Console.WriteLine();

ReplacePositiveElementsWithZero(a);


for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int q = 0; q < a.GetLength(2); q++)
        {
            Console.WriteLine(a[i, j, q]);
        }
    }
}