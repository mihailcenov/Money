using System;

namespace Money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal bitcoins = int.Parse(Console.ReadLine());
            decimal uans = decimal.Parse(Console.ReadLine());
            decimal commission = decimal.Parse(Console.ReadLine()) / 100.00m;

            decimal bitcoinstoleva = 1168;
            decimal uanstodollars = 0.15m;
            decimal dollarstoleva = 1.76m;
            decimal levatoeuro = 1.95m;

            decimal levove = bitcoins * bitcoinstoleva;
            decimal dollars = uans * uanstodollars;
            levove += dollarstoleva * dollars;

            decimal euro = levove / levatoeuro;
            euro -= commission * euro;

            Console.WriteLine("{0}", euro);
        }
    }
}
