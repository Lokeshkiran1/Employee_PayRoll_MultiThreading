using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    public class EmployeePayRollOperations
    {
        List<EmployeeDetails> listOfEmployeeDetails=new List<EmployeeDetails>();
        public void AddEmployeeToPayRoll(List<EmployeeDetails> list)
        {
            list.ForEach(employeeData =>
            {
                Console.WriteLine("Employee Being Added "+employeeData.EmployeeName);
                this.AddEmployeeToPayRoll(employeeData);
                Console.WriteLine("Employee Added "+employeeData.EmployeeName);
            });
            Console.WriteLine(this.listOfEmployeeDetails);
        }
        private void AddEmployeeToPayRoll(EmployeeDetails employeeDetails)
        {
            listOfEmployeeDetails.Add(employeeDetails);
        }
        public void AddEmployeeToPayRollWithThread(List<EmployeeDetails> listEmployeeDetails)
        {
            listEmployeeDetails.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee Being Added " + employeeData.EmployeeName);
                    this.AddEmployeeToPayRoll(employeeData);
                    Console.WriteLine("Employee Added " + employeeData.EmployeeName);
                });
                thread.Start();
            });
            Console.WriteLine(this.listOfEmployeeDetails);
        }
    }
}
