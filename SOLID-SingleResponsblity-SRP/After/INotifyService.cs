

using System;

namespace SOLID_SingleResponsblity_SRP.After
{
    internal interface INotifyService
    {
        void Send(Account account, string transactionMessage, DateTime transactionDateTime);
    }

}
