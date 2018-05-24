using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork24._05
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool result = (5 == 2 * 2);
            //bool result1 = (5 == 3 + 2);
            //Console.WriteLine(result);
            //Console.WriteLine(result1);


            //char ch = Console.ReadLine()[0];
            //if (ch >= '0' && ch <= '9')
            //{
            //    Console.WriteLine("c is a number");
            //}
            //else
            //{
            //    Console.WriteLine("c is not a number");
            //}

            //bool b1=true;
            //bool b2 =true;
            //Console.WriteLine(b1^b2);
            //true ^ true = false
            
            //Exersise 4.2
            //int age = int.Parse(Console.ReadLine());
            //if (age <= 10)
            //{
            //    Console.WriteLine("This is a child");
            //}
            //if (age >= 10 && age <= 18) ;
            //{
            //    Console.WriteLine("This is a teanager");
            //}
            //if (age >= 18 && age <= 60) ;
            //{
            //    Console.WriteLine("This is a adult");
            //}

            //Exersise 4.1
            double d1, d2;
            Console.WriteLine("Enter any number");
            d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            d2 = double.Parse(Console.ReadLine());

            if (d1 > d2) 
            {
                Console.WriteLine("The greater number is {0}", d1);
            }
            else if (d1<d2)
            {
                Console.WriteLine("The greater number is {0}", d2);
            }
            else
            {
                Console.WriteLine("They are equal");
            }
            
            //Exersise 4.3
            double whatNumber;
            Console.WriteLine("Enter any number");
            whatNumber = double.Parse(Console.ReadLine());
            whatNumber = whatNumber % 2;
            switch (whatNumber)
            {
                case 0:Console.WriteLine("Even"); break;
                default: Console.WriteLine("Odd"); break;
            }


            //Exersise 4.4
            int nOfguds, price, cashAmount;
            Console.WriteLine("What you amount of goods?");
            nOfguds = int.Parse(Console.ReadLine());
            Console.WriteLine("What price of good?");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("What you amount of cash?");
            cashAmount = int.Parse(Console.ReadLine());

            int avaliableGoodsForBuy = cashAmount / price;
            if (avaliableGoodsForBuy < 0)
            {
                Console.WriteLine("Take a credit");
            }
            if (nOfguds < avaliableGoodsForBuy)
            {
                Console.WriteLine("We dont have enough goods");
            }
            else
            {
                Console.WriteLine("You can by {0}", avaliableGoodsForBuy);
            }



            Console.WriteLine($"The amount of goods you can effort = {avaliableGoodsForBuy}");





            Console.ReadLine();

        }
    }
}
