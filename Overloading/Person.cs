using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept.Overloading
{
    class Person
    {
        public virtual void Work()
        {
            Console.WriteLine("Person is working ");
        }
    }
    class Ajay:Person
    {
        public override void Work()
        {
            Console.WriteLine("Ajay Teaching C# to a student");
        }
    }
    class Satish:Person
    {
        public override void Work()
        {
            Console.WriteLine("satish is learning C# programing");
        }
    }
    class Overrinding
    {
        static void Main(string[] args)
        {
            Person p;
            p= new Ajay();
            p = new Satish();

        }
    }
}
