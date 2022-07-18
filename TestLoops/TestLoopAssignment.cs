using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept.TestLoops
{
    //write a program to print all number between 1 to 100 except the tnumber which are divisuble by 5 od 10.
    class TestLoopAssignment
    {

        static void Main(string[] args)
        {
            //int num;
            //Console.WriteLine("Enter a number ");
            //num = int.Parse(Console.ReadLine());
            for (int i = 1; i <=100; i++)
            {
                if(i%5!=0 && i%10!=0)
                Console.WriteLine(i);
            }
        }
    }
    //Predict the behaviour of the following code.
    class Loop
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            } 
            while (b != 3);
            
        }
    }
    // predict the output of the following

    class WhileLoop
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k="+k+"i="+i);
        }
    }

    // Wtite a program to check a given number is spy number or not
    class SpyNumber
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            int rem,sum=0;
            int temp = num,mul=1;
            while(num>0)
            {
                rem = num % 10;
                mul *= rem;
                sum += rem;
                num /= 10;
            }
            if(sum==mul)
            {
                Console.WriteLine("Given number  is spy number");
            }
            else
            Console.WriteLine("Given number is not spy number");

        }
    }

    // Wtite a program to check a given number is trimorphic number or not


    class Trimorphic
    {
        static void Main(string[] args)
        {
            Boolean ismorphic = true;
            int num;
            Console.WriteLine("enter a number ");
            num = int.Parse(Console.ReadLine());
            int cube = num * num*num;
            while(num>0)
            {
                if(num%10!=cube%10)
                {
                    ismorphic = false;
                   // num=num % 10;
                    //cube = cube % 10;
                }
                if(ismorphic)
                {
                    Console.WriteLine("number is trimorphic");
                    break;
                }
                else
                    Console.WriteLine("number is not trimorphic");
                    break;
            }
           /* if (ismorphic)
            {
                Console.WriteLine("number is trimorphic");
                
            }
            else
                Console.WriteLine("number is not trimorphic");*/
           
        }
    }

    //Write a program to print following pattern.
        //        1
       //       2 2 2
      //      3 3 3 3 3
     //     4 4 4 4 4 4 4

    class Pattern
    {
        static void Main(string[] args)
        {
                for(int i=1;i<=4;i++)
                {
                     for(int k=4;k>=i;k--)
                     {
                    Console.Write(" ");
                     }
                     for(int j = 2; j <= i; j++)
                     {
                    Console.Write(i);
                     }
                     for(int l=2;l<=i+1;l++)
                     {
                    Console.Write(i);
                     }
                    Console.WriteLine();

                }
        }
    }

    // Write a program to print following pattern

    // * * * * *
    //  * * * *
    //   * * *
    //    * *
    //     *

    class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k >= i; k--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        } 
    }

    //     WAP to print following pattern.
    //   1 2 3 4 5
    //     1 2 3 4 
    //       1 2 3  
    //         1 2  
    //           1
    class pattern3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=5;k>=i;k--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}