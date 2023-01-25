using System;

namespace SOLID_DependencyInversionPrinsiple_DIP.After
{
    internal class SmsService : INotifyFactoryService
    {
        public string PhoneNumber { get; set; }

        public void Send()
        {
            Console.WriteLine($"SMS message sent to {this.PhoneNumber}");
        }
    }
}
