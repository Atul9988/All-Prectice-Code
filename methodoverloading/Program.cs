using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverloading
{
    class Program
    {
        public void test()
        {
            int a = 10;
            int b = 39;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void test(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public int test(float aa,int bb)
        {
            int cc = Convert.ToInt32(aa) +  bb;
            return cc;

        }
        public void test(float a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.test(1,34.0f);
            Console.ReadLine();
        }
    }
}
