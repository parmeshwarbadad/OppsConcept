using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept
{
    class Address
    {
        public int pincode;
        public string city;

        public  Address(int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
        public void show()
        {
            Console.WriteLine(pincode +" "+city);
        }
    }
    class Person
    {
        int id;
        string name;
        Address addr;
    

        Person(int id,string name,Address addr)
        {
            this.id = id;
            this.name = name;
            this.addr = addr;
        }
        public void Display()
        {
            Console.WriteLine(id+" "+name);
            addr.show();
        }

        static void Main(string[] args)
        {
            //Address d = new Address(123, "pune");


            Person p = new Person(1, "Akash", new Address(123, "pune"));
            p.Display();
        }
    }


   




}
