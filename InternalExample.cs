using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    internal class InternalExample
    {
        
        //internal property
        internal string sound = "Test";

        //internal method

        internal void MakeSound()
        {
            Console.WriteLine("Sound of animal is:"+sound);
        }


            
        
    }
}
