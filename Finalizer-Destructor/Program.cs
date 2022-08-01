using System;

namespace Finalizer_Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Younis Sultan";
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public Person()//Constructor
        {
            Console.WriteLine("This is Person Constructor");
        }

        ~Person()//Destructor
        {
            Console.WriteLine("This is Person Destructor");
        }
    }
}
