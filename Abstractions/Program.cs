using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    class Employe
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TexDeduction = 0.1;
        double netSalary;

        public Employe(int Eid,string EName,double Egrosspay)
        {
            this.EmpId = Eid;
            this.EmpName = EName;
            this.GrossPay = Egrosspay;
        }
        void calculateSalary()
        {
            if(GrossPay>=30000)
            {
                netSalary = GrossPay - (TexDeduction * GrossPay);
                Console.WriteLine("your Salary is:{0}",netSalary);
            }
            else
            {
                Console.WriteLine("your Salary is:{0}", GrossPay);
            }
        }
        public void show()
        {
            this.calculateSalary();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID");
            int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter Employee Name");
            string b = Console.ReadLine();
            Console.WriteLine("Enter Employee salary");
            double c=Convert.ToDouble(Console.ReadLine());
            Employe e = new Employe(a,b,c);
            e.show();
            Console.ReadLine();
        }
    }
}
