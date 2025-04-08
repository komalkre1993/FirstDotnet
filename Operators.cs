using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class Operators
    {
        static void Main()
        {
            /* Console.WriteLine("Test1");
              Console.WriteLine("Test2");
              Console.Write("Test3");
              Console.Write("Test4"); */

            //variable declarations
            int a = 9;
            int b = 10;

            //Arithmetic operators

            Console.WriteLine("Arithmetic operators");
            Console.WriteLine($"Addition:{a+b}");
            Console.WriteLine($"Subtraction:{a-b}");
            Console.WriteLine($"Multiplication:{a*b}");
            Console.WriteLine($"Division:{a/b}");
            Console.WriteLine($"Modulus:{a%b}");

           //Relational/comparison operators

            Console.WriteLine("Relational operators");
            Console.WriteLine($"a==b:{a == b}");
            Console.WriteLine($"a!=b:{a != b}");
            Console.WriteLine($"a>b:{a > b}");
            Console.WriteLine($"a<b:{a < b}");
            Console.WriteLine($"a>=b:{a >= b}");
            Console.WriteLine($"a<=b:{a <= b}");

        }
    }
}
