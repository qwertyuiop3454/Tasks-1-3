string a = Console.ReadLine();
int count = 0;

string[] words = a.Split(new char[] { ' ' });
for(int i = 0; i<words.Length; i++)
{
    
    for(int j = 0; j < words[i].Length; j++)
    {
        if (!Char.IsPunctuation(words[i][j]))
        {
            count++;
        }
    }
}
Console.WriteLine(count / words.Length);

