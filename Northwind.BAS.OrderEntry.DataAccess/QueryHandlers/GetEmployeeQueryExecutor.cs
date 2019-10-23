using Northwind.BAS.OrderEntry.Contracts.ViewDto;
using Northwind.BAS.OrderEntry.DataAccess.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.BAS.NIMS.DataAccess.QueryHandlers
{
    public class GetEmployeeQueryExecutor
    {
        public GetEmployeeQueryExecutor() { }

        public List<EmployeeModel> GetEmployees()
        {
            using (var dbContext = new NorthwindDbContext())
            {
                var results = (from employee in dbContext.Employees
                               join directReport in dbContext.Employees
                               on employee.EmployeeID equals directReport.EmployeeID
                              select new EmployeeModel()
                              {
                                  EmployeeId = employee.EmployeeID,
                                  LastName = employee.LastName,
                                  FirstName = employee.FirstName,
                                  Title = employee.Title,
                                  TitleOfCourtesy = employee.TitleOfCourtesy,
                                  DateOfBirth = employee.BirthDate,
                                  DateOfHire = employee.HireDate,
                                  Address = employee.Address,
                                  City = employee.City,
                                  Region = employee.Region,
                                  ZipCode = employee.PostalCode,
                                  Country = employee.Country,
                                  HomePhone = employee.HomePhone,
                                  Extension = employee.Extension,
                                  Notes = employee.Notes,
                                  ReportsTo = employee.ReportsTo,
                                  ReportsToName = directReport.FirstName + " " + directReport.LastName
                              }).ToList();

                return results;
            }
        }
    }
}
