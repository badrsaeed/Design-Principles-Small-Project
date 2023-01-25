using System;

namespace SOPLID_LiskoveSubistitutionPrinciple_LSP.After
{
    public class ChickingAcount : RegularAccount
    {
        public ChickingAcount(string name, decimal balance) : base(name, balance)
        {
        }

        public override void Deposite(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > 1000)
            {
                Console.WriteLine("You cant withdram more than $1000");
                return;
            }
            Balance -= amount;
        }
    }
}
