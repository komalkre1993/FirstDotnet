using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class EnumAssi
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December

        }

        static void Main()
        {
            Months monthname = Months.December; 
            switch (monthname)
            {
                case Months.January:
                    Console.WriteLine("It is starting month of the year");
                    break;

                case Months.December:
                    Console.WriteLine("It is ending month of the year");
                    break;

                case Months.February:
                    Console.WriteLine("It is 2nd month of the year");
                    break;

                case Months.March:
                    Console.WriteLine("It is 3rd month of the year");
                    break;

                case Months.April:
                    Console.WriteLine("It is 4th month of the year");
                    break;

                case Months.May:
                    Console.WriteLine("It is 5th month of the year");
                    break;

                case Months.June:
                    Console.WriteLine("It is 6th month of the year");
                    break;

                case Months.July:
                    Console.WriteLine("It is 7th month of the year");
                    break;

                case Months.August:
                    Console.WriteLine("It is 8th month of the year");
                    break;

                case Months.September:
                    Console.WriteLine("It is 9th month of the year");
                    break;

                case Months.October:
                    Console.WriteLine("It is 10th month of the year");
                    break;

                case Months.November:
                    Console.WriteLine("It is 11th month of the year");
                    break;

                default:
                    Console.WriteLine("Enter valid month of the year");
                    break;
            }

        }
    }
}
