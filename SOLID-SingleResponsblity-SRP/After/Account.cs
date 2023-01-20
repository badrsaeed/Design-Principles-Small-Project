using System;



namespace SOLID_SingleResponsblity_SRP.After
{
    internal class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }

        public Account(string name, string email, decimal balance, string phone)
        {
            this.Name = name;
            this.Email = email;
            this.Balance = balance;
            Phone = phone;
        }

    }
}
