using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SingleResponsblity_SRP.Before
{
    internal class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

        public Account(string name, string email, decimal balance)
        {
            this.Name = name;
            this.Email = email;
            this.Balance = balance;
        }



        public void MakeTransaction(decimal amount) // amount +/-
        {
            var transactionMessage = "";

            // handle withdraw
            if (amount < 0)
            {
                if (Balance < Math.Abs(amount))
                {
                    transactionMessage =
                    $"OVERDRAFT when trying to withdraw " +
                    $"{Math.Abs(amount).ToString("C2")}," +
                    $" current balance {Balance.ToString("C2")}";
                }
                else
                {
                    this.Balance += amount;
                    transactionMessage =
                       $"OK Withdraw {Math.Abs(amount).ToString("C2")}" +
                       $", current balance {Balance.ToString("C2")}";
                }
            }
            else
            {
                // handle deposit
                if (amount > 0)
                {
                    this.Balance += amount;

                    transactionMessage =
                        $"OK Deposit {amount.ToString("C2")}" +
                        $", current balance {Balance.ToString("C2")}";
                }
            }
        }
    }
}
