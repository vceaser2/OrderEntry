using Northwind.BAS.OrderEntry.Contracts.Commands;
using Northwind.BAS.OrderEntry.Contracts.Events;
using Northwind.BAS.OrderEntry.Contracts.Exceptions;
using System.ServiceModel;

namespace Northwind.BAS.OrderEntry
{
    [ServiceContract]
    public interface IOrderEntryService
    {
        [OperationContract]
        string TestCommand();
    }
}
