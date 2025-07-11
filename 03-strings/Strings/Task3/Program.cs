using System.Globalization;

CultureInfo eng = new CultureInfo("en-US");
CultureInfo rus = new CultureInfo("ru-RU");
CultureInfo invariant = new CultureInfo("in-IN");

Console.WriteLine("ru                  en");
Console.WriteLine(DateTime.Now.ToString(rus) + "|" + DateTime.Now.ToString(eng));
Console.WriteLine(1000000000.55.ToString(rus) + "|" + 1000000000.55.ToString(eng));

Console.WriteLine();

Console.WriteLine("en                  in");
Console.WriteLine(DateTime.Now.ToString(eng) + "|" + DateTime.Now.ToString(invariant));
Console.WriteLine(1000000000.55.ToString(eng) + "|" + 1000000000.55.ToString(invariant));

Console.WriteLine();

Console.WriteLine("ru                  in");
Console.WriteLine(DateTime.Now.ToString(rus) + "|" + DateTime.Now.ToString(invariant));
Console.WriteLine(1000000000.55.ToString(rus) + "|" + 1000000000.55.ToString(invariant));

