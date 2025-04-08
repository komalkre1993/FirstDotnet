using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class ControlstatementsAssi1
    {
       static void Main()
        {
            //switch statement
            Console.WriteLine("Here is list of our tasty menus:");
            Console.WriteLine("1.Burger - Rs.69.00");
            Console.WriteLine("2.Pizza - Rs.99.00");
            Console.WriteLine("3.Salad - Rs.49.00");
            Console.WriteLine("4.cold coffee - Rs.59.00");
            Console.WriteLine("Enter menu no which is you want to test");
            string menu = Console.ReadLine();
            switch(menu)
            {
                case "1":
                    Console.WriteLine("You choose menu no 1.burger of Rs.69.00");
                    break;

                case "2":
                    Console.WriteLine("You choose menu no 2.pizza of Rs.99.00");
                    break;

                case "3":
                    Console.WriteLine("You choose menu no 3.salad of Rs.49.00");
                    break;

                case "4":
                    Console.WriteLine("You choose menu no 4.cold coffee of Rs.59.00");
                    break;

                default:
                    Console.WriteLine("Please choose right menu options between 1 to 4");
                    break;
            }

            //for loop
            Console.WriteLine("------Display student by for loop------");
            for (int i =1;i<=10;i++)
            {
                Console.WriteLine("Student No:" +i);
            }

            //while loop
            Console.WriteLine("------Display student by while loop------");
            int j = 1;
            while(j<=10)
            {
                Console.WriteLine("Student No:" +j);
                j++;
            }

            //do while loop
            Console.WriteLine("------Display student by do while loop------");
            int k = 1;
            do
            {
                Console.WriteLine("Student No:" +k);
                k++;
            }
            while (k<=10);
        }
    }
}
