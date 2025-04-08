using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class Constantex
    {
        //normal variable declaration
        public int a = 10;
        public string name = "Test";

        //constant variable declaration
        public const double pi = 3.14;
        const string AppName = "ZYZ";

        public void PrintConstantValues()
        {
             Console.WriteLine(name);

             Console.WriteLine($"The value of pi is:{pi}");
             Console.WriteLine($"The value of Appname is:{AppName}");

            name ="TestNew";
            Console.WriteLine(name);
        }
    }
    class ConstExample
    {
        static void Main()
        {
            Constantex constantex = new Constantex();
           
            constantex.PrintConstantValues();

        }
    }
}
