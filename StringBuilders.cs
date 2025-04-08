using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class StringBuilders
    {
        static void Main()
        {
             string str = "Hello World";
             Console.WriteLine(str);

             str = "test";
             Console.WriteLine(str);

             string firstname = "Komal";
             string lastname = "Linge";

             string fullname = firstname + lastname;
             Console.WriteLine(fullname); 

            //stringbuilder implementation
            StringBuilder sb = new StringBuilder();

            sb.Append("My Name ");
            sb.Append("is ");
            sb.Append("Komal ");
            sb.Append("Linge ");
            Console.WriteLine(sb.ToString()); // Output: Hello, World!

            //remove value in string builder in specific index
            //sb.Remove(8, 3);
            //Console.WriteLine(sb.ToString());

            //insert value in specific index
            sb.Insert(11, "Mr ");
            Console.WriteLine(sb.ToString());

            //replace value in specific index
            sb.Replace("Komal", "Vibhav");
            Console.WriteLine(sb.ToString());

            sb.Clear();
        }
    }
}
