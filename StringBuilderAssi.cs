using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class StringBuilderAssi
    {
        static void Main()
        {
            //Assignment1
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Assignment 1:");
            StringBuilder sb = new StringBuilder();

            sb.Append("You ");
            sb.Append("never ");
            sb.Append("regert ");
            sb.Append("to ");
            sb.Append("being ");
            sb.Append("Kind. ");
            Console.WriteLine("Original String:");
            Console.WriteLine(sb.ToString()); // Output: Hello, World!

           //replace value in specific index
            sb.Replace("You", "I");
            Console.WriteLine("Replaced 'You' String:");
            Console.WriteLine(sb.ToString());

            //remove value in string builder in specific index
            sb.Remove(15, 3);
            Console.WriteLine("Removed 'to' String:");
            Console.WriteLine(sb.ToString());


            sb.Clear();

            //Assignment2 Arrays
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Assignment 2:");

            int[] maxmin = { 50, 30, 80, 10, 40 };

            int maxValue = maxmin.Max();
            int minValue = maxmin.Min();
            Console.WriteLine("Maximum value in array:" +maxValue);
            Console.WriteLine("Minimum value in array:" +minValue);


            //Assignment3 Arrays
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Assignment 3:");

            string[] names = { "Alice", "Bob", "Charlie", "David", "Emily" };
            Console.WriteLine("Names in the list:Alice,Bob,Charlie,David,Emily");

            Console.WriteLine("Enter Name:");
            string? searchname = Console.ReadLine();

            if (names.Contains(searchname))
            {
                Console.WriteLine(searchname+" found!");
            }
            else
            {
                Console.WriteLine(searchname+" not found!");
            }
                
        }
    }
}
