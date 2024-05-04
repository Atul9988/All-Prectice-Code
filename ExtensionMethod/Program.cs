using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        public void Fun1()
        {
            Console.WriteLine("this is first method in program class");
        }
        public void Fun2()
        {
            Console.WriteLine("this is Second method in program class");
        }
       
    }
    static class injectedMethodClass
    {
        public static void Fun3(this Program program)
        {
            Console.WriteLine("this is third claass method of injected class");
        }
    }
    class ExtentionMethodExce
    { 
        static void Main()
        {
            Program p = new Program();
            p.Fun3();
            Console.ReadLine();
        }
    }
}
