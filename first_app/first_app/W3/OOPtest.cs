using System;

public class Class1
{
    public Class1()
    {
        int id;
        public string fullname;
    private string password;
    protected string address;
}

class Class2
{
    private int id;
    private string fullname;

    // default
    public Class2()
    {
        this.id = 1;
        this.fullname = "NA";
    }
    //parameterized
    public Class2(int id, string fullname)
    {
        this.id = id;
        this.fullname = fullname;
    }
    //copy
    public Class2(Class2 class2)
    {
        this.id = class2.id;
        this.fullname = class2.fullname;
    }

    public int GetId()
    {
        return this.id
    }

    public void SetId(int id)
    {
        this.id = id;
    }

    public int GetFullName()
    {
        return this.fullname
    }

    public void SetFullName(string fullname)
    {
        this.fullname = fullname;
    }

    override

    public string ToString()
    {
        return this.fullname + " " + this.id;
    }

}
class Class3
    {
        private int id;
        private string fullname;

    }
// default
public Class3()
    {
        this.id = 1;
        this.fullname = "NA";
    }
//parameterized
public Class3(int id, string fullname)
    {
        this.id = id;
        this.fullname = fullname;
    }
//copy
public Class3(Class3 class3)
    {
        this.id = class3.id;
        this.fullname = class3.fullname;
    }

//properties-> set and get value
public int ID
    {
    set { this.id = value; }
    get {  return this.id; }


    }
public string NAME
{
    set { this.fullname = value; }
    get { return this.fullname }
}
override
public string ToString()
    {
        return this.id + " "+ this.fullname;
    }


class Class4{
    int id;
    public string fullname;
    private string password;
    protected string email;

   }
public class Class4_1 : Class4 {//inheritance
    public Class4_1()
    {
        base.id = -1
        base.fullname = 'pravin';
        base.password = 'your password';
        base.email = "your email"
    }
}

    class Class4
    {
        private int id;
    }
    public Class5() {
        this.id = 2;


        public Class5 (int id)
        {
            this.id = id;
        }
        //copy
        public Class5(Class5 class5) {
            this.id = class5.id;
        }
        public int GetID() { return this.id }
        public void SetID(int id) { this.id = id; }

    }

internal class Program
{
    public static void Main(string[] args)
    {
        /*Class1 obj_1 = new Class1();
        Console.WriteLine(obj_1.id);

        obj_1.fullname = "good";
        Console.WriteLine(obj_1.fullname);

        obj_1.password = "good";
        Console.WriteLine(obj_1.password);

        obj_1.address = "good";
        Console.WriteLine(obj_1.address);*/

        /*
        Class2 obj_2 = new Class2();

        obj_2.SetId(5);
        Console.WriteLine(obj_2.GetId());

        obj_2.SetFullName("Baibhav");
        Console.WriteLine(obj_2.GetFullName());
        
        Class2 obj_2_1 = new Class2(1, "bAIBHAV");

        Class2 obj_2_2 = new Class2(obj_2_1)
        Console.WriteLine(obj_2_2.GetId());
        Console.WriteLine(obj_2_2);
        */
        /*
        Class3 obj3_1 = new Class3();   
        obj3_1.ID  = 10;
        obj3_1.NAME = 'PRAVIN'
        Console.WriteLine(obj3_1.ID)
        Console.WriteLine(obj3_1.NAME)
        */
        /*
        Class4_1 obj4_1 = new Class4_1(); 
        obj4_1.id = 1;
        obj4_1.fullname ="pravin"
        obj4_1.password='******'
        obj4_1.email = 'your email'

        Class4 obj41 = new Class4_1()

        Console.WriteLine(obj4_1.id)
        Console.WriteLine(obj4_1.id)
        */

        Class1 obj5_1 = new Class5();
        obj5_1.SetID(1);
        obj5_1.SetFullname('pravin')







    }
}
}