using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOPLID_LiskoveSubistitutionPrinciple_LSP.After
{
    public abstract class Account
    {
        public Account(string name, decimal balacance)
        {
            Name = name;
            Balance = balacance;
        }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public abstract void Deposite(decimal amount);

    }
}
