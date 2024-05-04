using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class Program
    {
        public async static void t1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("strting method 1...");
                Thread.Sleep(2000);
                Console.WriteLine("ending method 1...");
            });
            Console.WriteLine("hello");
        }
        public async static void t2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("strting method 2...");
                Thread.Sleep(4000);
                Console.WriteLine("ending method 2...");
            });

        }
        public async static void t3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("strting method 3...");
                Thread.Sleep(5000);
                Console.WriteLine("ending method 3...");
            });

        }
        public async static void t4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("strting method 4...");
                Thread.Sleep(1000);
                Console.WriteLine("ending method 4...");
            });

        }
        static void Main(string[] args)
        {
            t1();
            t2();
            t3();
            t4();
            Console.ReadLine();
        }
    }
}
