namespace SOPLID_LiskoveSubistitutionPrinciple_LSP.After
{
    public abstract class RegularAccount : Account
    {
        public RegularAccount(string name, decimal balacance) : base(name, balacance)
        {
        }
       

        public abstract void Withdraw(decimal amount);

    }
}
