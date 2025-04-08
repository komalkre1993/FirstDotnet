using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class ArrayAssiment
    {
        static void Main()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //alternate elements in array
            Console.Write("Alternate elements in array:");
            for(int i=0;i<array1.Length;i+=2)
            {
                Console.Write(" "+array1[i]+" ");
            }

            //Number of elements in array
            Console.WriteLine("");
            Console.WriteLine("Number of elements in array:"+array1.Length);

            //Smallest number in array 
            
            int min = array1[0];//assuming first element in array is small
            foreach(int num in array1)
            {
                if(num<min)
                {
                    min = num;
                }
            }
            Console.WriteLine("Smallest number in array:"+min);

            
            //Largest number in array 
            int max = array1[0];
            foreach (int num in array1)
            {
                if (num>max)
                {
                    max = num;
                }
            }
            Console.WriteLine("largest number in array:"+max);
        } 
    }
}
