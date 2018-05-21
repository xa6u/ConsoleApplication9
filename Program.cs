using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centures = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 175315520;
            Console.WriteLine("{0} centuries is {1} years, or {2} days, or {3} hours.", centures, years, days, hours);
            Console.WriteLine();
            Console.WriteLine();


            float floatPI = 3.141559653589793238f;
            double doublePI = 3.141559653589793238;
            Console.WriteLine("Float PI is: {0}", floatPI);
            Console.WriteLine("Double PI is: {1}", floatPI, doublePI);
            Console.WriteLine();
            Console.WriteLine();

            double a = 1.0f;
            double b = 0.33f;
            double sum = 1.33f;
            bool equal = (a + b == sum);
            Console.WriteLine("a+b={0} sum={1} equal={2}", a+b, sum, equal);
            Console.WriteLine();
            Console.WriteLine();

            char symbol = 'c';
            Console.WriteLine("symbol = {0}, code = {1}", symbol, (int)symbol);
            Console.WriteLine();

            string firstName = "Sergey";
            string lastName = "Karabuta";
            Console.WriteLine("Hello, {0}!\n", firstName);
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Your full name is {0}", fullName);
            Console.WriteLine();


            int s = 0xFF;
            Console.WriteLine(s);
            Console.WriteLine();


            double s1 = 1.23e+6;
            Console.WriteLine(s1);
            Console.WriteLine();
        }
    }
}
