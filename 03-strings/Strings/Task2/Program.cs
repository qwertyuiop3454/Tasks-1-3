Console.WriteLine("Введите первую строку: ");
var a = Console.ReadLine();

Console.WriteLine("Введите вторую строку: ");
var b = Console.ReadLine();


string c = "";


for (int i = 0; i < a.Length; i++)
{
    c += a[i];
    for (int j = 0; j < b.Length; j++)
    {
        
        if (a[i] == b[j])
        {
            c += b[j];
            break;
        }
    }
}

Console.WriteLine(c);

