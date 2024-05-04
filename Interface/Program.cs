using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    

    interface Iemployee
    {
        void show();
    }
    interface Iemployee1
    {
        void show1();
    }
    class demo : Iemployee,Iemployee1
    {
        public void show()
        {
            Console.WriteLine("this is interface");
        }

        public void show1()
        {
            Console.WriteLine("this is second interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            demo d = new demo();
            d.show();
            d.show1();
            Console.ReadLine();
        }
    }
}
