using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    public class PublicExampleTest
    {
        //define property
        public int publicproperty{get; set;}

        //define method display and show
        public void Display()
        {
            Console.WriteLine("Public property value:"+publicproperty);
        }

        public void show()
        {
            Console.WriteLine("Hello");
        }

    }
    class PublicExample
    {
        static void Main()
        {
            PublicExampleTest obj = new PublicExampleTest();

            //inheriting or calling method and property from publicexampletest class to publicexample class
            obj.publicproperty = 1;
            obj.Display();
            obj.show();
        }
    }
}
