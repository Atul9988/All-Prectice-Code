using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritance_using_interface
{
    
    class Employee
    {
        public void show()
        {
            Console.WriteLine("this is Employee parents class");
        }

    }
    interface Student
    {
        void show();
    }
    interface Student1
    {
        void show();

    }

    class Teacher : Employee, Student, Student1
    {

        void Student.show()
        {
            Console.WriteLine("this is Teacher interface class");
        }
        void Student1.show()
        {
            Console.WriteLine("this is Student1 interface class");
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Student1 e = new Teacher();
            e.show();
            Console.ReadLine();
        }
    }
}
