using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjectionUsingDI
{
    public interface IAccount
    {
        void printdetails();
    }
    class SavingAcount : IAccount
    {
        public void printdetails()
        {
            Console.WriteLine("this is Saving account of Property Injection..........");
        }
    }
    class CurrentAccount : IAccount
    {

        public void printdetails()
        {
            Console.WriteLine("this is Current account of Property Injection..........");
        }
    }
    class Account
    {
        public IAccount account { get; set; }
        public void printAccount()
        {
            account.printdetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Account sa = new Account();
            sa.account = new SavingAcount();
            sa.printAccount();
            Account ca = new Account();
            ca.account = new CurrentAccount();
            ca.printAccount();      
            Console.ReadLine();
        }
    }
}



