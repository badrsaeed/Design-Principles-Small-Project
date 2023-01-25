using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DependencyInversionPrinsiple_DIP.Before
{
    internal class AddressService
    {
        public string Address { get; set; }

        public void Send()
        {
            Console.WriteLine($"mail sent to {this.Address}");
        }
    }
}
