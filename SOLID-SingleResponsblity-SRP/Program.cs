using SOLID_SingleResponsblity_SRP.After;
using SOLID_SingleResponsblity_SRP.Before;
using System;

namespace SOLID_SingleResponsblity_SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestWithoutSRP();
            TestWithSRP();
            Console.ReadKey();
        }

        private static void TestWithoutSRP()
        {
            Before.Account account = new Before.Account("Badr", "Badr@gmail.com", 500);
            account.MakeTransaction(500);
            account.MakeTransaction(-1500);

        }

        private static void TestWithSRP()
        {
            After.Account account = new After.Account("Badr", "Badr@gmail.com", 500, "01147137203");
            AccountService accountService = new AccountService(new SmsService());
            accountService.Deposit(account,500);
            accountService.Withdraw(account, 1500);

        }
    }

}
