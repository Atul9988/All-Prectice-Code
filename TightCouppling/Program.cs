using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TightCouppling
{
    class SavingAccount
    {
        public void show()
        {
            Console.WriteLine("this is shaving account");
        }
    }
    class CureentAccount
    {
        public void show()
        {
            Console.WriteLine("this is Current account");
        }
    }
    class Account
    {
        CureentAccount ca = new CureentAccount();
        SavingAccount sa = new SavingAccount();
        public void print()
        {
            ca.show();
            sa.show();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account ak = new Account();
            ak.print();
            Console.ReadLine();
        }
    }
}
