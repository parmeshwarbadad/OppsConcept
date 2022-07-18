using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept
{
    class Shopping
    {
        string paitem;
        int price;
        int quantity;
        int bill;


        public void AcceptDetails(string peraitem, int aprice, int aquantity)
        {
            paitem = peraitem;
            price = aprice;
            quantity = aquantity;
        }
        public void GetBill()
        {
            this.AcceptDetails("perfume", 200, 0);
            if (quantity > 0)
                bill = quantity * price;
            else
                Console.WriteLine("Error");
        }
        public void Showdetails()
        {
            Console.WriteLine("Total Bill are: "+bill);
            Console.WriteLine("Aitems are: "+paitem);
            Console.WriteLine("Price: "+price);
            Console.WriteLine("Quantity:s "+quantity);
        }

        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            //s.AcceptDetails("perfume", 200, 3);
            s.GetBill();
            s.Showdetails();

            

        }
    }
    class ICICIBank
    {
        string cname;
        int accnumber;
        int balance;
        public ICICIBank()
        {
            Console.WriteLine("Default");
        }
        public void AcceptDetails(string cname, int accnumber, int balance)
        {
            this.cname = cname;
            this.accnumber = accnumber;
            this.balance = balance;
        }
        public void Display()
        {
            this.AcceptDetails("Param", 1234, 4321);
            Console.WriteLine("Customer name is: " + cname);
            Console.WriteLine("Account number are: " + accnumber);
            Console.WriteLine("balance is: " + balance);

        }
        static void Main(string[] args)
        {
            ICICIBank b = new ICICIBank();
            b.Display();
            //Console.WriteLine();
        }
    }
}
