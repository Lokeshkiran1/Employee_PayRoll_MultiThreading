using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    public class EmployeeDetails
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public long PhoneNumber { get; set; }
        public EmployeeDetails(int employeeID, string employeeName, long phoneNumber)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            PhoneNumber = phoneNumber;
        }

    }
}
