using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BantamRouter.Models
{
    public class Employee
    {
        [DataMember]
            public string EmployeeNo { get; set; }
        [DataMember]
            public string FirstName { get; set; }
        [DataMember]
            public string MiddleName { get; set; }
        [DataMember]
            public string LastName { get; set; }
        [DataMember]
            public string Initials { get; set; }
        [DataMember]
            public string JobTitle { get; set; }
        [DataMember]
            public string Address { get; set; }
        [DataMember]
            public string City { get; set; }
        [DataMember]
            public string PostOffice  { get; set; }
        [DataMember]
            public string CountyName { get; set; }
        [DataMember]
            public string PhoneNo { get; set; }
        [DataMember]
            public string MobileNo { get; set; }
        [DataMember]
            public string EMail { get; set; }
        [DataMember]
            public Byte Picture { get; set; }
        [DataMember]
            public DateTime Birthdate { get; set; }
        [DataMember]
            public int Gender { get; set; }
        [DataMember]
            public DateTime Employmentdate { get; set; }
        [DataMember]
            public int Status { get; set; }
        [DataMember]
            public string Department { get; set; }
        [DataMember]
           public DateTime LastDateModified { get; set; }
        [DataMember]
            public string CompanyEMail { get; set; }
        [DataMember]
            public string Title { get; set; }
        [DataMember]
            public string NSSFNo { get; set; }
        [DataMember]
            public string NHIFNo { get; set; }
        [DataMember]
            public string PINNo { get; set; }
        [DataMember]
            public string NationalID { get; set; }
        [DataMember]
            public string HELBNo { get; set; }
        [DataMember]
            public string SaccoNo { get; set; }
        [DataMember]
            public string Position { get; set; }
        [DataMember]
            public string PassportNo { get; set; }
        [DataMember]
            public string Grade { get; set; }
        [DataMember]
            public string NavUserID { get; set; }
        [DataMember]
            public string WebUserID { get; set; }
        [DataMember]
            public string BaseCalendar { get; set; }
    }
}
