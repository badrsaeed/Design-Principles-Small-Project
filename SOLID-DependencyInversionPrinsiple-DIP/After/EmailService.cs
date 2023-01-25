using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DependencyInversionPrinsiple_DIP.After
{
    internal class EmailService : INotifyFactoryService
    {
        public string EmailAddress { get; set; }

        public void Send()
        {
            Console.WriteLine($"email sent to {this.EmailAddress}");
        }
    }
}
