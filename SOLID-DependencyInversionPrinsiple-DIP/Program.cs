using System;
using System.Collections.Generic;

namespace SOLID_DependencyInversionPrinsiple_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Before DIP
            //var customers =  Before.Repository.LoadCustomers();

            //foreach (var customer in customers)
            //{
            //    var notifyService = new Before.NotificationService(customer);
            //    notifyService.Notify();
            //}

            // After using DIP
            var customers = After.Repository.LoadCustomers();

            foreach (var customer in customers)
            {
                var serviceFactory = new List<After.INotifyFactoryService>()
                {
                    new After.EmailService() {EmailAddress = customer.EmailAddress},
                    new After.SmsService() {PhoneNumber = customer.PhoneNumber},
                    new After.AddressService() {Address = customer.Address},
                };
                // Constructor Dependency Injection
                var notificationService = new After.NotificationService(serviceFactory);
                notificationService.Notify();
            }
        }
    }
}
