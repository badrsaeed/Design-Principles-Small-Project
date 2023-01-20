using System;


namespace SOLID_SingleResponsblity_SRP.After
{
    internal class AccountService
    {
        private readonly INotifyService _notifyService;

        public AccountService(INotifyService notifyService)
        {
            _notifyService = notifyService;
        }

        public void Withdraw(Account account, decimal amount)
        {
            var transactionMessage = "";
            if (account.Balance < amount)
            {
                transactionMessage =
                $"OVERDRAFT when trying to withdraw " +
                $"{amount.ToString("C2")}," +
                $" current balance {account.Balance.ToString("C2")}";
            }
            else
            {
                account.Balance -= amount;
                transactionMessage =
                   $"OK Withdraw {Math.Abs(amount).ToString("C2")}" +
                   $", current balance {account.Balance.ToString("C2")}";
            }

            
            _notifyService.Send(account, transactionMessage, DateTime.Now);
        }

        public void Deposit(Account account, decimal amount)
        {
            var transactionMessage = "";

            if(amount > 0)
            {
                account.Balance += amount;

                transactionMessage =
                    $"OK Deposit {amount.ToString("C2")}" +
                    $", current balance {account.Balance.ToString("C2")}";
            }

            _notifyService.Send(account, transactionMessage, DateTime.Now);
        }
    }
}
