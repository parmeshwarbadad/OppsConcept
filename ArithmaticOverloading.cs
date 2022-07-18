using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept
{
    class ArithmaticOverloading
    {
        public void Arithmatic(int a,int b,int c)
        {
            this.Arithmatic(5.2f, 3);

            Console.WriteLine("Addition of a , b and c is: "+(a+b+c));
        }
        public void Arithmatic(float a,int b)
        {
            this.Arithmatic(6,5.2f);

            Console.WriteLine("Substraction of a and b is: "+(a-b));
        }
        public void Arithmatic(int a, float b)
        {

            Console.WriteLine("Multiplication of a and b is: "+(a*b));
        }
        public void Arithmatic(int a, int b)
        {
            this.Arithmatic(2, 5, 6);
            Console.WriteLine("Division of two numbers are: "+(a/b));
        }



        static void Main(string[] args)
        {
            ArithmaticOverloading Ar = new ArithmaticOverloading();
            Ar.Arithmatic(4,2);
        }
    }






    class AreaOverlod
    {
        public void Area(float r)
        {
            Console.WriteLine("Area of a Circle are: "+3.14*r*r);
        }
        public void Area(int a, int b)
        {
            Console.WriteLine("Area of rectangle are: "+a*b);
        }
        public void Area(int a, float b)
        {
            Console.WriteLine("area of trangle are: "+(0.5*a*b));
        }
        public void Area(int b)
        {
            Console.WriteLine("area of Square: "+b);
        }






        static void Main(string[] args)
        {
            AreaOverlod a = new AreaOverlod();
            a.Area(3);
            a.Area(4,6);
            a.Area(0.5f);
            a.Area(2,4.4f);
        }

    }



    class StaticMethod
    {
        public static void M1() 
        {
            Console.WriteLine("No argument method");
        }

         public static void M1(int a)
         {
             Console.WriteLine("With argument method");
         }

        static void Main(string[] args)
        {
            StaticMethod.M1(5);
        }
    }
   static class StClass
   {
        static int x=10;
         static StClass()
         {
             Console.WriteLine(x);
         }
       

        static void    Main(string[] args)
        {
            Console.WriteLine(x);
        }


   }
    class ConOver
    {
        ConOver()
        {
            Console.WriteLine("Default constructor ");
        }
        ConOver(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        ConOver(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        static void Main(string[] args)
        { 
        ConOver c = new ConOver(5, 8, 6);
    }
    }
}
