namespace Money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = double.Parse(Console.ReadLine());
            var uans = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine()) / 100.00;

            var bitcoinstoleva = 1168;
            var uanstodollars = 0.15;
            var dollarstoleva = 1.76;
            var levatoeuro = 1.95;

            var levove = bitcoins * bitcoinstoleva;
            var dollars = uans * uanstodollars;
            levove += dollarstoleva * dollars;

            var commissionlv = levove * commission;
            levove -= commissionlv;

            var euro = levatoeuro * levove;

            Console.WriteLine("{0}", euro);
        }
    }
}
