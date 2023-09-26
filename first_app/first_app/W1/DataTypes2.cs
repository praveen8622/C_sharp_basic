using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app.W1
{
    //Reference Type 
    //1.system defined
    //2.user defined
        //a. class
        //b. Interface
        //c. Delegate
        //d. record
    
    class Person
    {
        int pid;
        string name;
        public Person (int pid, string name)
        {
            this.pid = pid;
            this.name = name;

        }
        override
            public string ToString()
        {
            return (this.pid+"'"+this.name);
        }
    }
    interface Inf1
    {
        void f1();// abstract method
    }
    class Class1:Inf1 { // Implements Inf1
        public void f1()
        {
            Console.WriteLine("hello from f1 of class1");
        }
        
    }
    class Class2 : Inf1
    { // Implements Inf1
        public void f1()
        {
            Console.WriteLine("hello from f1 of class2");
        }

    }

    delegate int DelegateFunction (int x, int y);

    internal class DelegateTest
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int prd(int x, int y)
        {
            return x * y;
        }
    }

    public class OldStudent
    {
        public int sid;
        public string name;

        public OldStudent(int sid, string name)
        {
            this.sid = sid;
            this.name = name;
        }
    }
    public record  class NewStudent
    {
        public int sid { get; set; } = default;
        public string name { get; set; } =default;

    }
    /*
    class Program
    {
        static void Main(string[] args)
        {
            //System defined 
            //string
            //string
            string str1 = "Hello from Krishal";
            Console.WriteLine(str1);

            string str2 = "Hello from Krishal";

            Object obj1 = new Object();
            obj1 = new Object();
            obj1 = str1;




            // 2. User defined 
            //a. Class 
            Person p1;
            p1 = new Person(1, "Thapa ji");
            Console.WriteLine(p1);// call ToString 

            Class1 obj2 = new Class1();  
            Class2 obj3 = new Class2();
            obj2.f1();
            obj3.f1();
            new Class1().f1();
            new Class2().f1();


            DelegateFunction df1 = new DelegateTest().Sum;
            int result = df1(8, 7); // Sum
            Console.WriteLine(result);
            df1 = new DelegateTest().prd;
            result = df1(8, 7);
            Console.WriteLine(result);


            OldStudent s01 = new OldStudent(1, "Raj");
            OldStudent s02= new OldStudent(1, "Raj");
            bool rslt=(s01==s02);
            Console.WriteLine(rslt);

            var s1 = new NewStudent
            {
                sid = 2,
                name = "Krishal"

            };
            var s2 = new NewStudent
            {
                sid = 2,
                name = "Krishal"

            };
            rslt = (s1 == s2);
            Console.WriteLine(rslt);



        }

    }*/
}
