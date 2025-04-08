using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    public class CopyConstructorExample
    {
        //parameter declaration
        public string Name{get; set;}
        public int Age { get; set;}

        public string NameNew { get; set; }
        public int AgeNew { get; set; }

        //parameter constructor
        public CopyConstructorExample(string name,int age)
        {
            Name=name;
            Age=age;
        }

        //Copy constructor
        public CopyConstructorExample(CopyConstructorExample copyx)
        {
            NameNew=copyx.Name;
            AgeNew=copyx.Age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}, Age:{Age}");
        }

        public void DisplayInfoNew()
        {
            Console.WriteLine($"Name:{NameNew}, Age:{AgeNew}");
        }


    }
    class ParameterAndCopyConstructor
    {
        static void Main()
        {
            //creating object with pass value for parametrized constructor
            CopyConstructorExample obj = new CopyConstructorExample("Vibhav",3);
            obj.DisplayInfo();

            //creating object with pass value for copy constructor
            CopyConstructorExample obj2 = new CopyConstructorExample(obj);
            obj2.DisplayInfoNew();
        }
    }
}
