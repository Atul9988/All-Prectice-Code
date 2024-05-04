using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string[] aa = { "atul", "kamal", "arun", "shyam", "kajal", "neha" };
            var aaa = from i in aa orderby i ascending select i;
            foreach (var item in aaa)
            {
                Console.Write(item+", ");
            
            }
            Console.WriteLine();
            int [] value = { 4, 1, 6, 3, 5, 2,44,23,11,32,43,66,43,77,85,3 };
            var val = from j in value orderby j descending select j;
            foreach(var item in val)
            {
                Console.Write(item+", ");
            }

            Console.ReadLine();
        }
    }
}
