using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDotnet
{
    class PrivateClass
    {   /*
        //private property
        private int PrivateField;

        //private method
        private void SetField(int value)
        {
            PrivateField = value;
        }
        private void Show()
        {
            Console.WriteLine("Private field value:"+PrivateField); 
        }
        */
    }
    class PrivateExample
    {
        //private property
        private int PrivateField;

        //private method
        private void SetField(int value)
        {
            PrivateField = value;
        }
        private void Show()
        {
            Console.WriteLine("Private field value:"+PrivateField);
        }

        //person full name assi for private
        private string firstname;
        private string lastname;
        private  void FullName()
        {
            Console.WriteLine("FullName is:"+firstname+" "+lastname);
        }
        static void Main(string[] args)
        {
            PrivateExample example = new PrivateExample();
            //person full name assi for private
            example.firstname ="Komal";
            example.lastname ="Linge";
            example.FullName();

            //PrivateClass obj = new PrivateClass();
            //obj.SetField(10);
            //obj.privatefield=1;

            example.SetField(10);
            example.PrivateField=1;
            example.Show();

          


            //internalExample file class inheriting here
            InternalExample test = new InternalExample();
            test.sound ="Roar";
            test.MakeSound();
        }
    }
}
