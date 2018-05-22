using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exersise 2.7 Changes value of 2 variables without third variable.
            //int a = 4;
            //int b = 5;

            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine("Variable a is: {0}\nVariable b is: {1}", a, b);
            //Console.ReadLine();


            //Exersise 2.9
            //string firstName;
            //string lastName;
            //int year;
            //char sex;
            //long idNuber;
            //string ssex,siNumber, sCardNumber;

            //Console.Write("Enter you first name: ");
            //firstName = Console.ReadLine();
            //Console.Write("Enter your last name: ");
            //lastName = Console.ReadLine();
            //Console.Write("Enter the year when you born (YYYY format): ");
            //year = Console.Read();
            //Console.Write("Enter your sex: ");
            //ssex = Console.ReadLine();
            //sex = ssex[0];

            Type type = typeof(int);

            Console.WriteLine($"Type Name = {type.FullName}");
            Console.WriteLine($"size = {size}");
            Console.WriteLine($"Max = {int.MaxValue}");
            Console.WriteLine($"Min = {int.MinValue}");


            Console.ReadLine();
                     
                                
        }
    }
}
