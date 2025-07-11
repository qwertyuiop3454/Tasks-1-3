Console.WriteLine("Введите первую строку");
string a = Console.ReadLine();
Console.WriteLine("Введите вторую строку");
string b = Console.ReadLine();

for(int i = 0; i <a.Length;i++)
{
    Console.Write(a[i]);
    for(int j = 0; j < b.Length; j++)
    {
        if (b[j] == a[i])
        {
            Console.Write(a[i]);
            break;
        }
    }
}

