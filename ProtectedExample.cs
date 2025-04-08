using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    //protected access modifier

    //base class/derived class/super class
    class Animal
    {
        //protected member
        protected string Sound;

        //protected method
        protected void Makesound()
        {
            Console.WriteLine($"Animal makes sound:{ Sound}");

        }

    }

    //derived class/child class/sub class
    class Dog:Animal
    {
        public Dog()
        {
            Sound="Barks";
        }
        public void Displaysound()
        {
            Makesound();
        }
    }
    class Cat : Animal
    {
        public Cat()
        {
            Sound="Meows";
        }
        public void Displaysound()
        {
            Makesound();
        }
    }

    //parent class
    class Person1
    {
        protected string EmployeeName; 
        protected string EmployeeID;
        protected string Address;

        protected void Details()
        {
            Console.WriteLine("Employee Details: Id:"+EmployeeID+" Name:"+EmployeeName+" Address:"+Address);
        }
    }
    //child class
    class Employee : Person1
    {
        public Employee()
        {
            EmployeeName = "Komal";
            EmployeeID = "01";
            Address = "Pune";
        }
        public void DisplayDetails()
         {
            Details();
         }
    }
    class ProtectedExample
    {
        static void Main()
        {
            Cat c = new Cat();
            c.Displaysound();
            Dog d = new Dog();
            d.Displaysound();   

            Employee employee = new Employee();
            employee.DisplayDetails();
        }
        
    }
}
