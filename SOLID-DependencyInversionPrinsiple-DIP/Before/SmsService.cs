using System;

namespace SOLID_DependencyInversionPrinsiple_DIP.Before
{
    internal class SmsService
    {
        public string PhoneNumber { get; set; }

        public void Send()
        {
            Console.WriteLine($"SMS message sent to {this.PhoneNumber}");
        }
    }
}
