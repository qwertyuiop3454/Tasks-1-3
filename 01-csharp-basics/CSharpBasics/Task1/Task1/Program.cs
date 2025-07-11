Console.WriteLine("Здравствуйте! Эта программа находит площадь прямоугольника");
Console.WriteLine("Введите отдельно первую сторону: ");

int a = 0;
while(a <= 0)
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a <= 0)
    {
        
        Console.WriteLine("Нельзя вводить отрицательные числа!");

    }
}

Console.WriteLine("Введите отдельно вторую сторону: ");
int b = 0;
while (b <= 0)
{
    b = Convert.ToInt32(Console.ReadLine());
    if (b <= 0)
    {

        Console.WriteLine("Нельзя вводить отрицательные числа!");

    }
}
Console.WriteLine("Площадь равна: " + a * b);

