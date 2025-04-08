using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class EnumExamples
    {
        //Syntax of enum

        enum Days
        {
            //Enum implementation
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday


        }

        enum Httpstatuscode
        {
            OK = 200,
            Badrequest = 400,
            Unauthorized = 401,
            Forbidden = 500,
            NotFound = 400

        }

        static void Main()
        {

            //calling class method and property from publicexample file to test public identifier
            PublicExampleTest obj = new PublicExampleTest();

            obj.publicproperty = 5;
            obj.Display();
            obj.show();



            Days today = Days.Sunday;
            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("Today is Sunday");
                    //Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case Days.Monday:
                    Console.WriteLine("Today is Monday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case Days.Thursday:
                    //Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Today is Thursday");
                    break;
                case Days.Friday:
                    Console.WriteLine("Today is Friday");
                    break;
                case Days.Saturday:
                    Console.WriteLine("Today is Saturday");
                    break;

            }

            if(today == Days.Sunday || today == Days.Saturday)
            {
                Console.WriteLine("It's weekend");
            }
            else
            {
                Console.WriteLine("It's week day");
            }


            Httpstatuscode code = Httpstatuscode.OK;
            Console.WriteLine("HTTP status code: "+code);

            int codenumber = (int)code;
            Console.WriteLine("HTTP status code number: "+codenumber);
        }
    }
}
