using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class ReadOnlyEx
    {
        //Property declaration
        public readonly int InitialValue;
        public static readonly double pi;
        public static string test = "Test";

        public ReadOnlyEx(int initialValue)
        {
            InitialValue=initialValue;
        }
       static ReadOnlyEx()
        {
            pi=3.14;
        }

        public void PrintValues()
        {
            Console.WriteLine($"Initial Value:{ InitialValue}");
            Console.WriteLine($"Initial Value:{pi}");
        }

    }
    class ReadOnlyExample
    {
        static void Main()
        {
            ReadOnlyEx re = new ReadOnlyEx(5);
            re.PrintValues();
        }
    }
}
