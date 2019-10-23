using System;
using System.Runtime.Serialization;

namespace Northwind.BAS.OrderEntry.Contracts.ViewDto
{
    [DataContract]
    public class EmployeeModel
    {
        [DataMember]
        public int EmployeeId { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string TitleOfCourtesy { get; set; }

        [DataMember]
        public DateTime? DateOfBirth { get; set; }

        [DataMember]
        public DateTime? DateOfHire { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Region { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string HomePhone { get; set; }

        [DataMember]
        public string Extension { get; set; }

        [DataMember]
        public string Notes { get; set; }

        [DataMember]
        public int? ReportsTo { get; set; }

        [DataMember]
        public string ReportsToName { get; set; }
    }
}
