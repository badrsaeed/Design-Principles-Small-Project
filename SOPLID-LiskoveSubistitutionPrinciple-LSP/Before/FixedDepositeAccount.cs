using System;

namespace SOPLID_LiskoveSubistitutionPrinciple_LSP.Before
{
    public class FixedDepositeAccount : Account
    {
        public FixedDepositeAccount(string name, decimal balance) : base(name, balance)
        {
        }
        public override void Deposite(decimal amount)
        {
            Balance+= amount;
        }

        public override void Withdraw(decimal amount)
        {
            throw new NotSupportedException("Cant withdraw more than 1000");
        }
    }
}
