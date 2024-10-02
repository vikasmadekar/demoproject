using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    abstract class Person1
    {
        public string firstName;
        public string lastName;
        
        public int age;
        public abstract void PrintDetails();
    }
    class Student2:Person1
    {
        public int feees;
        public long phoneno;
        public override void PrintDetails()
        {
            Console.WriteLine("first name:{0}",firstName );
            Console.WriteLine("last name:{0}",lastName );
            Console.WriteLine("age:{0}",age);
            Console.WriteLine("Fess:{0}",feees);
            Console.WriteLine("phoneno:{0}",phoneno);


        }
    }
    class Teacher7:Person1
    {
        public float Salary;
        public string Qualification;
        public override void PrintDetails()
        {
            Console.WriteLine("Teacher the salary:{0}",Salary);
            Console.WriteLine("Teacher the qualification:{0}",Qualification );
        }
    }

    internal class Abstractc
    {

        static void Main()
        {
            Student2 std= new Student2();
            std.firstName = "vikas";
            std.lastName = "Madekar";
            std.age = 20;
            std.feees = 5000;
          
            std.PrintDetails();

            Teacher7 teacher = new Teacher7();
            teacher.Qualification = "master of computer science";
            teacher.Salary = 20000; 
            teacher.PrintDetails();
            Console.ReadKey();
            Console.ReadLine();







        }
    }
}
