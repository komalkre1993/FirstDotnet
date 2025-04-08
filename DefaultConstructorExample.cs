using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class DefaultConstExample
    {
        public int value;

        //Default Constructor
        public DefaultConstExample()
        {
            value=1;
        }
        //normal method
        public void Display()
        {
            Console.WriteLine("test" + value);
        }
    }
    class DefaultConstructorExample
    {
        static void Main()
        {
            //Instance creation
            DefaultConstExample example = new DefaultConstExample();
            example.Display();
        }
    }
}
