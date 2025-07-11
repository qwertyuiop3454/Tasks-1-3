Console.WriteLine("Здравствуйте, это программа для рисования звёздочками");
Console.WriteLine("Введите число: ");
int o = 0;

while (o <= 0)
{
    o = Convert.ToInt32(Console.ReadLine());
    if (o <= 0)
    {
        Console.WriteLine("Ошибка");
    }
}

for (int a = 0; a < o + 1; a++)
{


    int stars = 1;

    for (int i = 0; i < a; i++)
    {
        string b = "";
        string c = "";
        for (int j = 0; j < a - 1 - i; j++)
        {
            b += " ";
        }
        for (int l = 0; l < o - a; l++)
        {
            b += " ";
        }

        for (int h = 0; h < stars; h++)
        {
            c += "*";
        }
        stars += 2;
        Console.WriteLine(b + c);
    }
}


