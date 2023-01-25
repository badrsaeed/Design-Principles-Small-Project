using System;

namespace SOPLID_LiskoveSubistitutionPrinciple_LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var account = new Before.FixedDepositeAccount("Badr", 1000);
            //account.Withdraw(1000);
            var account = new After.ChickingAcount("Badr", 1000);
            account.Deposite(1000);
            Console.WriteLine(account.Balance);
        }
    }
}
