using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class ControlStatements
    {
        static void Main()
        {
            //Basic Conditions
            Console.WriteLine("-------Basic number indentify---------");
            Console.WriteLine("Enter the Number");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a>0)
            {
                Console.WriteLine("Number is Positive");
            }
            else if(a<0)
            {
                Console.WriteLine("Number is Negative");
            }
            else if(a==0)
            {
                Console.WriteLine("Number is Zero");
            }

            //Grade Calculator
            Console.WriteLine("-------Grade Calculator---------");
            Console.WriteLine("Enter your marks(0-100)");
            int grade = Convert.ToInt32(Console.ReadLine());
            if (grade>=75)
            {
                Console.WriteLine("Congratulations!! You got a grade A!!");
            }
            else if (grade>=60 && grade<75)
            {
                Console.WriteLine("Congratulations!! You got a grade B!!");
            }
            else if (grade>=50 && grade<60)
            {
                Console.WriteLine("You got a grade C!!");
            }
            else if (grade>=40 && grade<50)
            {
                Console.WriteLine("You got a grade D!!");
            }
            else if (grade<40 && grade>=0)
            {
                Console.WriteLine("OOPS!! You got a grade E.Betterluck Next time");
            }
            else
            {
                Console.WriteLine("you entered invalid marks");
            }

        }
    }
}
