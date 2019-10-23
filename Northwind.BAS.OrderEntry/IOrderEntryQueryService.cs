using Northwind.BAS.OrderEntry.Contracts.ViewDto;
using System.Collections.Generic;
using System.ServiceModel;

namespace Northwind.BAS.OrderEntry
{
    [ServiceContract]
    public interface IOrderEntryQueryService
    {
        [OperationContract]
        string GetDataTest();

        [OperationContract]
        List<EmployeeModel> GetEmployees();
    }
}
