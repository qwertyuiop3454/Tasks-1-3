using System;
using System.Globalization;

Console.WriteLine("Введите число: ");
string a = Console.ReadLine();

CultureInfo.CurrentCulture = new CultureInfo("en-US");

float b = 0;
bool c = true;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] == 'e' || a[i] == 'E')
    {
        if (float.TryParse(a, out b))
        {
            c = false;
            break;
        }
    }
}

if(c)
{
    if(float.TryParse(a, out b))
    {
        Console.WriteLine("Это число в обычной нотации");
    }
    else
    {
        Console.WriteLine("Это не число");
    }
        
}
else
{
    Console.WriteLine("Это число в научной нотации");
}



