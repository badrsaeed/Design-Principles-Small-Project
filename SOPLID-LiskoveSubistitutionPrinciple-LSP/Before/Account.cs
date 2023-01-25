using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOPLID_LiskoveSubistitutionPrinciple_LSP.Before
{
    public abstract class Account
    {
        public Account(string name, decimal balcance)
        {
            Name = name;
            Balance = balcance;
        }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public abstract void Deposite(decimal amount);
        public abstract void Withdraw(decimal amount);

    }
}
