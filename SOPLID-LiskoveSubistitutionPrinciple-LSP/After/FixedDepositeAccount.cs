using System;

namespace SOPLID_LiskoveSubistitutionPrinciple_LSP.After
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

       
    }
}
