using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjectionUsingDI
{
    public interface IAccount
    {
        void printdetails();
    }
    class SavingAcount : IAccount
    {
        public void printdetails()
        {
            Console.WriteLine("this is Saving account..........");
        }
    }
    class CurrentAccount : IAccount
    {
        public void printdetails()
        {
            Console.WriteLine("this is Current account..........");
        }
    }
    class Account
    {
        private IAccount account;
        public Account(IAccount account)
        {
            this.account = account;    
        }
        public void printAccount()
        {
            account.printdetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAccount sa = new SavingAcount();
            Account a = new Account(sa);
            IAccount ca = new CurrentAccount();
            Account a2 = new Account(ca);
            a.printAccount();
            a2.printAccount();
            Console.ReadLine();
        }
    }
}
