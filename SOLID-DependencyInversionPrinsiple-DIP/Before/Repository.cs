using System.Collections.Generic;

namespace SOLID_DependencyInversionPrinsiple_DIP.Before
{
    internal class Repository
    {
        public static IEnumerable<Customer> LoadCustomers()
        {
            return new List<Customer>()
            {
                new Customer()
                {
                    Id= 1,
                    Name = "Badr",
                    EmailAddress="badrsaedd@gmail.com",
                    PhoneNumber = "+201255688354",
                     Address = "Egypt - Cairo"
                },
                new Customer()
                {
                    Id= 2,
                    Name = "Amr",
                    EmailAddress="Amrsaedd@gmail.com",
                    PhoneNumber = "+20115464551",
                     Address = "Egypt - Giza"
                },
                new Customer()
                {
                    Id= 3,
                    Name = "Ah,ed",
                    EmailAddress="Ahmed@gmail.com",
                    PhoneNumber = "+212151231345",
                     Address = "USA - New York"
                },
            };
        }
    }
}
