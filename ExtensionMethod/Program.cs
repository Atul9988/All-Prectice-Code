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
        public static void Fun3(this Program program, int i)
        {
            Console.WriteLine("this is third claass method of injected class "+i);
        }
        public static bool getcompareValue(this int i,int b)
        {
            return b > i;
        }

    }
    class ExtentionMethodExce
    { 
        static void Main()
        {
            Program p = new Program();
            p.Fun3(10);
            int i = 30;
            bool result = i.getcompareValue(20);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
