using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class ControlStatementsAssi2
    {
        static void Main()
        {
            //Foreach loop
            Console.WriteLine("-----For each loop-----");
            Console.WriteLine("Mobile brand list:");
            String[] mobilebrands = { "Nokia", "Samsung", "Xiomi", "Apple", "Google", "Oneplus", "Vivo", "Motorola", "Sony", "Oppo" };
            foreach(string brand in mobilebrands)
            {
               
                Console.WriteLine($"Mobile brand name is:{brand}");
            }

            //Break statement
            Console.WriteLine("------Break statement-----");
            int sum = 0;
            while(true)
            {
                Console.Write("Please enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                
                if (num<0)
                {
                    break;
                }
                
                sum += num;
            }

            Console.WriteLine("Sum of all entered number is:" +sum);

            //Continue
            Console.WriteLine("------Continue statement-----");
            for(int i=1;i<=20;i++)
            {
                if(i%3==0)
                {
                    continue;
                }
                Console.WriteLine("Numbers which is not divisible by 3:" +i);
            }

            //Goto
            Console.WriteLine("------Goto statement-----");
            int age;
            repeatcheck:
            Console.Write("Enter your age between 0 to 120: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age>120)
            {
                Console.WriteLine("Please enter valid age between 0 to 120");
                goto repeatcheck;
            }
            Console.WriteLine("Your Age is:" +age);
        }
    }
}
