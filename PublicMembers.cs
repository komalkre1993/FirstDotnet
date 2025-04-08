using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    public class Person
    {

        public string firstname;
        public string lastname;


        public void displayfullname( )
        {
            Console.WriteLine("FullName is:" +firstname +" "+lastname);
        }
    }
    class PublicMembers
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstname = " komal";
            person.lastname = "Linge";
            person.displayfullname();

        }

    }
}
