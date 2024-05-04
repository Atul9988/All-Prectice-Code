using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInjectionUsingDI
{
    public interface IAccount
    {
        void printdetails();
    }
    class SavingAcount : IAccount
    {
        public void printdetails()
        {
            Console.WriteLine("this is Saving account  of Method Injection..........");
        }
    }
    class CurrentAccount : IAccount
    {
        public void printdetails()
        {
            Console.WriteLine("this is Current account of Method Injection..........");
        }
    }
    class Account
    {
       
        public void printAccount(IAccount account)
        {
            account.printdetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Account sa = new Account();
            sa.printAccount(new SavingAcount());
            Account ca = new Account(); 
            ca.printAccount(new CurrentAccount());
            Console.ReadLine();
        }
    }

}
