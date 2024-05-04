using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Baseclass
    {
        public void show1()
        {
            Console.WriteLine("this is show one method");
        }
    }
    class Derieved1 : Baseclass
    {
        public void show2()
        {
            Console.WriteLine("this is show two method");
        }
    }
    class Derieved2 : Class1
    {
        public void show3()
        {
            Console.WriteLine("this is  new method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Derieved2 d = new Derieved2();
            d.show1();
            d.show3();
            d.show2();
            d.newm();
            Console.ReadLine();

        }
    }
}
