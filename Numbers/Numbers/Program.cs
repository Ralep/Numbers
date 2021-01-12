using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {


            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            Console.WriteLine($"The range of integers is {minInt} to {maxInt}");

            int what = maxInt + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            Console.WriteLine($"The range of double is {minDouble} to {maxDouble}");

            decimal minDecimal = decimal.MinValue;
            decimal maxDecimal = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {minDecimal} to {maxDecimal}");


            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);


        }
    }
}
