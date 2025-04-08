using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class Arrays
    {
        static void Main()
        {
            //declare the arrays
            string[] Mobiles = new string [6];

            //assigning values in arrays

            //First approach
            Mobiles[0] = "Apple";
            Mobiles[1] = "Oneplus";
            Mobiles[2] = "Samsung";
            Mobiles[3] = "Xiomi";
            Mobiles[4] = "Vivo";
            Mobiles[5] = "Motorola";

            //Second approach
            string[] Mobile = ["Apple", "Samsung", "Vivo"];

            //Accessing values from array
            for(int i=0;i<Mobiles.Length;i++)
            {
                Console.WriteLine("Mobile brand name is:" +Mobiles[i]);
            }

            //multidimentional arrays
            Console.WriteLine();
            Console.WriteLine("Multidimensional arrays");
            int[,] Matrix = new int[,]
                            { //0, 1, 2----index row
                                {1, 2, 3 }, //0----index coloumn
                                {4, 5, 6},  //1
                                {8, 9, 10} //2

                            };
            //Accessing values from multidemntional arrays
            Console.WriteLine("Element at(1,2):" +Matrix[1, 2]);
            Console.WriteLine("Element at(2,2):" +Matrix[2, 2]);

            //Print all the values from arrays
            Console.WriteLine("All elements from arrays");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(Matrix[i, j]+",");
                    
                }
                Console.WriteLine() ;

            }

            //Reverse String
            Console.WriteLine("-----Reverse String----");
            String rev = "Welcome";
            char[] chArray = rev.ToCharArray();
            char[] revArray = new char[chArray.Length];
            for(int i=0;i<chArray.Length;i++)
            {
                revArray[i] = chArray[chArray.Length -1-i];
            }
            string originalstr = new string(chArray);
            string reversestr = new string(revArray);

            Console.WriteLine($"Original String is:"+originalstr);
            Console.WriteLine($"Reverse String is:"+reversestr);

        }
    }
}
