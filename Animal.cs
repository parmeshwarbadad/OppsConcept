using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept
{
    abstract class Addition
    {
        public abstract void Add();
    } 
    abstract class Multiplication:Addition
    {
        public override void Add()
        {
            Console.WriteLine("Addition Execited");
        }
        public abstract void  Mult();
    }
     class Division:Multiplication 
    {
        public override void Mult()
        {
            Console.WriteLine("Multiplication executed");
        }
        public void Div()
        {
            Console.WriteLine("Division method Executed");
        }
     

    
        static void MainMeth(string[] args)
        {
            Division s = new Division();
            s.Mult();
            s.Div();
            Console.WriteLine(s.Div());

        }
    }
}
