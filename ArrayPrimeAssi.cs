using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class ArrayPrimeAssi
    {
        static void Main()
        {
            int[] nums = {1,2, 3, 4, 5, 6, 7, 8,9,10,11,12,13};
            Console.WriteLine("Prime numbers in the array:");
            foreach(int num in nums)
            {
                if(IsPrime(num))
                {
                    Console.WriteLine(num+"");
                }
            }
            
            static Boolean IsPrime(int num)
            {
                if (num<2)
                { return false; }
               for(int i=2; i<num;i++)
                {
                    if(num%i == 0)
                    {
                        return false;
                    }
                }
               return true;
            }
        }
    }
}
/* 
 Understanding the logic:
if (num < 2) return false;

If the number is less than 2, it cannot be prime.

Example: IsPrime(1) → Returns false because 1 is not prime.

for (int i = 2; i < num; i++)

Loops from 2 to num - 1.

Checks if num is divisible by any number.

if (num % i == 0) return false;

% is the modulus operator (it gives the remainder).

If num % i == 0, it means num is divisible by i.

If a number is divisible by any number other than 1 and itself, it’s not prime.

return true;

If no divisors were found, it means num is prime, so we return true.
 */