using Northwind.BAS.NIMS.DataAccess.QueryHandlers;
using Northwind.BAS.OrderEntry.Contracts.ViewDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Northwind.BAS.OrderEntry
{
    /// <summary>
    /// Query services
    /// <para>Query services include Reads only.</para>
    /// </summary>
    /// <returns></returns>
    public class OrderEntryQueryService : IOrderEntryQueryService
    {
        public string GetDataTest()
        {
            return string.Format("Success!");
        }

        public List<EmployeeModel> GetEmployees()
        {
            GetEmployeeQueryExecutor queryExecutor = new GetEmployeeQueryExecutor();
            return queryExecutor.GetEmployees();
        }
    }
}
