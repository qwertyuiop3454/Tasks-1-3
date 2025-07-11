using System.ComponentModel.Design;

string a = "<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами";

string c = "";
bool d = true;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] == '<')
    {
        c += "_";
        d = false;
    }

    if (d == true)
    {
        c += a[i];
    }

    if (a[i] == '>')
    {
        d = true;

    }


}

Console.WriteLine(c);