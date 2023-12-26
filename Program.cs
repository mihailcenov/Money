using System;

namespace Money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въвеждане на биткойни");
            decimal bitcoins = int.Parse(Console.ReadLine());
            Console.WriteLine("въвеждане на юани");
            decimal uans = decimal.Parse(Console.ReadLine());

            decimal commission;
            do
            {
                Console.WriteLine("Комисионна от 0-5%");
                commission = decimal.Parse(Console.ReadLine()) / 100.00m;
                //Console.WriteLine("Невалидна комисионна");
            } while (commission > (5.0m / 100.00m));

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
