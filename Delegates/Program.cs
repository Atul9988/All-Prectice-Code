using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Calculate(int a, int b);
    class  Program
    {
        public static void Additation(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("the addition of two no is "+ result);
        } public static void substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("the substraction of two no is " + result);
        } public static void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("the multiplication of two no is " + result);
        }
        static void Main(string[] args)
        {
            Calculate obj = new Calculate(Program.Additation);
            obj.Invoke(20,19);
            obj = substraction;
            obj(20, 19);
            obj = multiplication;
            obj(23, 4);
            Console.ReadLine( );
        }
    }
}
