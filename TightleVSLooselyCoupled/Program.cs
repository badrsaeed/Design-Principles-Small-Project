using System;

namespace TightleVSLooselyCoupled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tightly Coupled

            //NotifyService notifyService = new NotifyService(new EmailService(), new SmsService());
            //notifyService.Notofy();

            //Loosely Coupled

            //IServiceMode serviceMode = NotifyServiceFactory.Create(SelectService.WEIRD);
            //NotifyService notifyService = new NotifyService(serviceMode);
            //notifyService.Notofy();
        }
    }
    #region Tightle Coupled
    //class EmailService
    //{
    //    public void Send()
    //    {
    //        Console.WriteLine("Email Sent");
    //    }
    //}
    //class SmsService
    //{
    //    public void Send()
    //    {
    //        Console.WriteLine("Sms Sent");
    //    }
    //}

    //class NotifyService
    //{
    //    private readonly EmailService _emailService;
    //    private readonly SmsService _smsService;
    //    public NotifyService(EmailService emailService, SmsService smsService)
    //    {
    //        _emailService = emailService;
    //        _smsService = smsService;
    //    }
    //    public void Notofy()
    //    {
    //        _emailService.Send();
    //    }
    //}

    #endregion


    #region Loosely Coupled

    class NotifyServiceFactory
    {
        public static IServiceMode Create(SelectService selectService)
        {
            switch (selectService)
            {
                case SelectService.EMAIL:
                    return new EmailService();

                case SelectService.SMS:
                    return new SmsService();
                case SelectService.WEIRD:
                    return new WeiredService();
                default:
                    return new EmailService();
            }
        }
    }
    enum SelectService
    {
        EMAIL,
        SMS,
        WEIRD
    }
    class EmailService : IServiceMode
    {
        public void Send()
        {
            Console.WriteLine("Email Sent");
        }
    }
    class SmsService :IServiceMode
    {
        public void Send()
        {
            Console.WriteLine("Sms Sent");
        }
    }
    class WeiredService : IServiceMode
    {
        public void Send()
        {
            Console.WriteLine("blabla Sent");
        }
    }

    interface IServiceMode
    {
        void Send();
    }
    class NotifyService
    {
        private readonly IServiceMode _serviceMode;
        public NotifyService(IServiceMode serviceMode)
        {
            _serviceMode = serviceMode;
        }
        public void Notofy()
        {
            _serviceMode.Send();
        }
    }
    #endregion


    //2
    interface ICartTotal
    {
        float total();
    }
    public class CartEntry : ICartTotal
    {
        public float Price;
        public int Quantity;

        public float total()
        {
            float total = this.Price * this.Quantity;
            return total;
        }
    }

    public class CartContents : ICartTotal
    {
        public CartEntry[] items;

        public float total()
        {
            float totalitemsPrice = 0;
            foreach (var item in items)
            {
                totalitemsPrice += item.total();
            }
            return totalitemsPrice;
        }
    }

    public class Order 
    {
        private CartContents cart;
        private float salesTax;

        public Order(CartContents cart, float salesTax)
        {
            this.cart = cart;
            this.salesTax = salesTax;
        }
        public float total()
        {
            float cartTotal = 0;
            cartTotal = cart.total() * (1.0f * salesTax);

            return cartTotal;
        }
    }
}
