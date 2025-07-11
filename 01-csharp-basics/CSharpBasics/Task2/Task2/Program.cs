Console.WriteLine("Здравствуйте, это программа для рисования звёздочками");
Console.WriteLine("Введите число: ");
int a = 0;
while (a <= 0)
{
    a = Convert.ToInt32(Console.ReadLine());
    if(a <= 0)
    {
        Console.WriteLine("Ошибка");
    }
}
string b = "";

for (int i = 0; i < a; i++)
{
    b += "*";
    Console.WriteLine(b);
}

