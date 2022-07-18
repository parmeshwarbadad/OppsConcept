using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept
{
    class Property
    {
        int modelno;
        string name;
        string color;
        int price;

        public int Modelnumber { get => modelno; set => modelno = value; }
        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int Price { get => price; set => price = value; }


        /* public int Modelno
         {
             get { return modelno; }
             set { modelno = value; }
         }
         public string Name
         {
             get { return name; }
             set { name = value; }
         }
         public string Color
         {
             get;
             set;
         }
         public int Price
         {
             get;
             set;
         }
     }*/
        class CarInfo
        {
            static void Main(string[] args)
            {
                Property c = new Property();
                c.modelno = 123;
                c.Name = "Audi";
                c.Color = "Black";
                c.Price = 321;
                Console.WriteLine(c.modelno + " " + c.Name + " " + c.Color + " " + c.Price);

            }
        }
    }
    
    class EmployeeProperty1
    {
        int eid;
        string ename;
        double salary;

        public int Eid
        {
            get { return eid; }
            set { eid = value; }
        }
        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }

    class Employee
    {
        static void Main(string[] args)
        {
            EmployeeProperty1 ep = new EmployeeProperty1();
            ep.Eid = 21;
            ep.Ename = "Param";
            ep.Salary = 123.321;
            Console.WriteLine(ep.Eid+" "+ep.Ename +" "+ep.Salary );
        }
    }
}
