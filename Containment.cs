using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept
{
        class Department
        {
           public int did;
           public string dname;

            public int Did
            {
                get { return did; }
                set { did = value; }
            }
            public string Dname
            {
                get { return dname; }
                set { dname = value; }
            }
        }


    class Employee1
    {
        int eid;
        string ename;
        Department dept;
        public int Eid
        {
            get { return eid; }
            set { eid = value; }
        }

        public string Ename
        {
            get;
            set;
        }
        public Department Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        static void Main(string[] args)
        {
            Employee1 e = new Employee1();
            e.eid=01;
            e.ename = "Satish";

            e.Dept = new Department();
            e.Dept.did= 2;
            e.dept.dname= "HR";
            Console.WriteLine(e.eid+" "+e.ename+" "+e.Dept.did+" "+e.Dept.dname);
        }







    }


}
