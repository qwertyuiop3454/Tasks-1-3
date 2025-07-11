using System.Globalization;

static void СulturesDiff(CultureInfo culture1, CultureInfo culture2)
{
    var localDate = DateTime.Now;
    var doubleNumber = 3.14;
    var intNumber = 999999999;
    Console.WriteLine($"{culture1.NativeName,-50}" +
        $"{culture2.NativeName}");
    Console.WriteLine($"{localDate.ToString(culture1),-50}" +
        $"{localDate.ToString(culture2)}");
    Console.WriteLine($"{doubleNumber.ToString(culture1),-50}" +
        $"{doubleNumber.ToString(culture2)}");
    Console.WriteLine($"{intNumber.ToString("N", culture1),-50}" +
        $"{intNumber.ToString("N", culture2)}");
}

СulturesDiff(CultureInfo.CurrentCulture, CultureInfo.InvariantCulture);

