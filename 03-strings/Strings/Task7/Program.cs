Console.WriteLine("Введите текст: ");
string a = Console.ReadLine();
string[] b = a.Split();
int count = 0;
for (int i = 0; i < b.Length; i++)
{

    if (b[i].Contains(":"))
    {
        string[] c = b[i].Split(":");
        int c1, c2;

        if (int.TryParse(c[0], out c1) && int.TryParse(c[1], out c2))
        {
            if (c1 > 0 && c1 <= 23)
            {
                if (c2 >= 0 && c2 <= 59)
                {
                    count += 1;
                }
            }
        }

    }
}

Console.WriteLine($"Время в тексте присутствует {count} раз.");
