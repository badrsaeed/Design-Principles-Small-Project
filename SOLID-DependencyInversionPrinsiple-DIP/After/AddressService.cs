using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DependencyInversionPrinsiple_DIP.After
{
    internal class AddressService : INotifyFactoryService
    {
        public string Address { get; set; }

        public void Send()
        {
            Console.WriteLine($"mail sent to {this.Address}");
        }
    }
}
