Console.WriteLine("Здравствуйте, это программа для рисования звёздочками");
Console.WriteLine("Введите число: ");
int a = 0;

while (a <= 0)
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a <= 0)
    {
        Console.WriteLine("Ошибка");
    }
}

int stars = 1;

for (int i = 0; i < a; i++)
{
    string b = "";
    string c = "";
    for(int j = 0; j < a-1-i; j++)
    {
        b += " ";
    }
    
    for(int h = 0; h < stars; h++)
    {
        c += "*";
    }
    stars += 2;
    Console.WriteLine(b + c);
}




