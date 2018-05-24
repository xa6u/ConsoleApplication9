using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 4(workshop) Make 3 virtual column 10 symbols long and place there 3 numbers with left alignment
            int n1 = 234234;
            double n2 = 356.6545;
            double n3 = -678.6786;
            Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-10:F2} ", n1, n2, n3);
            Console.ReadLine();

            ////Exersise 6(workshop) Prints the greater number
            int a, b;
            int maxInt, minInt;

            Console.WriteLine("Enter any int number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another int number");
            b = int.Parse(Console.ReadLine());

            minInt = (a + b - Math.Abs(a - b)) / 2;
            maxInt = (a + b + Math.Abs(a - b)) / 2;

            Console.WriteLine("Smaller one  {0}", minInt);
            Console.WriteLine("Bigger one  {0}", maxInt);
            Console.ReadLine();

            ////Exersise 1.6 Draw rhombus 
            Char c = '*';
            Console.WriteLine("{0,20}", c);
            Console.WriteLine("{0,15}{0,10}", c);
            Console.WriteLine("{0,10}{0,20}", c);
            Console.WriteLine("{0,15}{0,10}", c);
            Console.WriteLine("{0,20}", c);
            Console.ReadLine();


        }
    }
}
