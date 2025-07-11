int a = 1000;
int b = 0;


for(int i = 0; i <a; i++)
{
    if(i % 3 == 0 || i % 5 ==0)
    {
        b += i;
    }

}
Console.WriteLine(b);


