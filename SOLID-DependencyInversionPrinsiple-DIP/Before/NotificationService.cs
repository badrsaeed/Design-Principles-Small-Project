namespace SOLID_DependencyInversionPrinsiple_DIP.Before
{
    internal class NotificationService
    {

        private readonly EmailService _emailService;
        private readonly SmsService _smsService;
        private readonly AddressService _addressService;

        public NotificationService(Customer customer)
        {
            _emailService =  new EmailService { EmailAddress = customer.EmailAddress, };
            _smsService =  new SmsService { PhoneNumber = customer.PhoneNumber, };
            _addressService= new AddressService { Address = customer.Address, };
        }
        public void Notify()
        {
            _emailService.Send();
            _smsService.Send();
            _addressService.Send();
        }
    }
}
