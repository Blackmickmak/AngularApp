using System;
namespace AngWebApp.Models
{
    public class Employees
    {
        public decimal employeeNumber { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string extension { get; set; }
        public string email { get; set; }
        public string officeCode { get; set; }
        public decimal reportsTo { get; set; }
        public string jobTitle { get; set; }

        

    }
}
