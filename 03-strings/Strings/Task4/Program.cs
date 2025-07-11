using System.Text;
using System.Diagnostics;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Stopwatch stopWatch1 = new Stopwatch();
        Stopwatch stopWatch2 = new Stopwatch();
        stopWatch1.Start();

        string str = "";
        StringBuilder sb = new StringBuilder();
        int N = 500000;

        for (int i = 0; i < N; i++)
        {
            str += "*";
        }
        stopWatch2.Start();
        stopWatch1.Stop();
        for (int i = 0; i < N; i++)
        {
            sb.Append("*");
        }
        stopWatch2.Stop();
        TimeSpan ts1 = stopWatch1.Elapsed;
        TimeSpan ts2 = stopWatch2.Elapsed;
        string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts1.Hours, ts1.Minutes, ts1.Seconds,
           ts1.Milliseconds / 10);

        string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts2.Hours, ts2.Minutes, ts2.Seconds,
           ts2.Milliseconds / 10);

        Console.WriteLine("String " + elapsedTime1);
        Console.WriteLine("StringBuilder " + elapsedTime2);
        
    }
}
