using BantamRouter.Models;
using System.Collections.Generic;

namespace BantamRouter.Managers
{
    using Faces;
    using NavWSsEmployee;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    public class EmployeeManager
    {
        
        public List<Employee> getAllActiveEmpoyees ()
        {
            Employees_Service NavEmployeeSVC = new Employees_Service();
            NavEmployeeSVC.UseDefaultCredentials = true;
            NavEmployeeSVC.PreAuthenticate = true;

            List<Employee> activeEmployees = new List<Employee> ();
            const int fetchsize = 0;
            string bookMarkKey = null;

            Employees[] results = NavEmployeeSVC.ReadMultiple(new Employees_Filter[] { }, bookMarkKey, fetchsize);

            foreach (Employees staff in results)
            {
                Employee currEmployee = new Employee();
                currEmployee = ConvertEmployee(staff);
                activeEmployees.Add(currEmployee);
            };

           return activeEmployees;
        }

        public Employee ConvertEmployee(Employees Staff)
        {
            Employee newEmployee            = new Employee();
            newEmployee.EmployeeNo          = Staff.No           ;
            newEmployee.FirstName           = Staff.First_Name               ;
            newEmployee.MiddleName          = Staff.Middle_Name              ;
            newEmployee.LastName            = Staff.Last_Name                ;
            newEmployee.Initials            = Staff.Initials                ;
            newEmployee.JobTitle            = Staff.Job_Title                ;
            newEmployee.Address             = Staff.Address                 ;
            newEmployee.City                = Staff.City                  ;
            newEmployee.PostOffice          = Staff.Post_Code              ;
            newEmployee.CountyName          = Staff.Country_Region_Code              ;
            newEmployee.PhoneNo             = Staff.Phone_No                 ;
            newEmployee.MobileNo            = Staff.Mobile_Phone_No                ;
            newEmployee.EMail               = Staff.E_Mail                   ;
            newEmployee.Birthdate           = Staff.Birth_Date               ;

            if (Staff.Gender == Gender.Male) { newEmployee.Gender = 0; };
            if (Staff.Gender == Gender.Female) { newEmployee.Gender = 1; };

            newEmployee.Employmentdate      = Staff.Employment_Date          ;

            if (Staff.Status == Status.Active) { newEmployee.Status = 1; };
            if (Staff.Status == Status.Inactive) { newEmployee.Status = 2; };
            if (Staff.Status == Status.Terminated) { newEmployee.Status = 3; };

            newEmployee.Department          = Staff.Global_Dimension_1_Code              ;
            newEmployee.LastDateModified    = Staff.Last_Date_Modified        ;
            newEmployee.CompanyEMail        = Staff.Company_E_Mail            ;
            newEmployee.Title               = Staff.Title                   ;
            newEmployee.NSSFNo              = Staff.NSSF_No                  ;
            newEmployee.NHIFNo              = Staff.NHIF_No                  ;
            newEmployee.PINNo               = Staff.PIN_No                   ;
            newEmployee.NationalID          = Staff.National_ID              ;
            newEmployee.HELBNo              = Staff.HELB_No                  ;
            newEmployee.SaccoNo             = Staff.Sacco_Co_op_No                 ;
            newEmployee.Position            = Staff.Designation                ;
            newEmployee.PassportNo          = Staff.Passport_No              ;
            newEmployee.Grade               = Staff.Grade                   ;
            newEmployee.NavUserID           = Staff.Imprest_UserID               ;
            newEmployee.WebUserID           = Staff.WebUserID               ;
            newEmployee.BaseCalendar        = Staff.Base_Calendar                   ;

            return newEmployee;

        }
    }
}
