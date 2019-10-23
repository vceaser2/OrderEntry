using Northwind.BAS.OrderEntry.Contracts.Commands;
using Northwind.BAS.OrderEntry.Contracts.Events;

namespace Northwind.BAS.OrderEntry
{
    /// <summary>
    /// Command Services
    /// <para>Command services include Creates (i.e., Inserts), Updates, and Deletes.</para>
    /// </summary>
    public class OrderEntryService : IOrderEntryService
    {
        public string TestCommand()
        {
            return "Success!";
        }
    }
}
