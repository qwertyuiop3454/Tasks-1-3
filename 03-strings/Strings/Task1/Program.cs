Console.Write("Введите текст: ");
var a = Console.ReadLine();
var b = a.Split();
int sum = 0;

for(int i = 0; i < b.Length; i++)
{
    Console.WriteLine(b[i]);
}

for(int i = 0; i < b.Length; i++)
{
    sum += b[i].Length;
}

float c = sum * 1f / b.Length;
Console.WriteLine(c);



