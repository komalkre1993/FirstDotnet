using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class ArraysAssi1
    {
        static void Main()
        {
            //sum value of array
            Console.WriteLine("-----Sum value of an array-----");
            int[] num = { 1, 2, 3, 4, 5, 6, 7 };
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine($"Sum values of an array is:"+sum);

            //average value of array
            Console.WriteLine("-----Average value of an array-----");
            int[] average = { 10, 20, 30, 40, 50 };
            double add = 0;
            for(int j = 0;j < average.Length;j++)
            {
                add += average[j];
            }
            Console.WriteLine($"Addition value of an array is:" +add);
            double averagevalue = add / average.Length;
            Console.WriteLine($"Average value of an array is:" +averagevalue);

            //Add and even values from arrays
            Console.WriteLine();
            Console.WriteLine("-----Odd and even values from array-----");
            int[] evenodd = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

            //even numbers
            Console.WriteLine("Even Numbers in arrays:");
            foreach (int k in evenodd)
            {
                if (k%2==0)
                {
                    Console.Write(k+",");
                }

            }

            //Odd numbers
            Console.WriteLine();
            Console.WriteLine("Odd Numbers in arrays:");
            foreach (int k in evenodd)
            {
                if (k%2!=0)
                {
                    
                    Console.Write(k+",");
                }

            }
            Console.WriteLine();
        }
    }
}
