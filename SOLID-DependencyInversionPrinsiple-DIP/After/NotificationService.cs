using System.Collections.Generic;

namespace SOLID_DependencyInversionPrinsiple_DIP.After
{
    internal class NotificationService
    {
        private readonly List<INotifyFactoryService> _servicesFactory;

        public NotificationService(List<INotifyFactoryService> servicesFactory)
        {
            _servicesFactory= servicesFactory;
        }
        public void Notify()
        {
            foreach (var servic in _servicesFactory)
            {
                servic.Send();
            }
        }
    }
}
