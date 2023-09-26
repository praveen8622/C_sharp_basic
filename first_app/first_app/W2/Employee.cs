using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app.W2
{
    public class Employee
    {
        string name;
        int age;
        string position;
        public Employee(string name, int age, string position) {
            this.name = name;
            this.age = age;
            this.position = position;
        }

        public Employee() { }
        
        public string Name
        {
            get => name;
            set => name = value;
        }

        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "hello";
        }
    }
}
