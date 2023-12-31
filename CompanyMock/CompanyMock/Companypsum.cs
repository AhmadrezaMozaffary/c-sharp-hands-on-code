using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMock
{
    internal class Companypsum
    {
        static Employee alex = new("Alex Rod", 6);
        static Employee linda = new("Linda Berry", 7);
        static Employee john = new("John Doe", 3);

        static readonly Department salesDepartment = new("Sales");

        static Employee sarah = new("Sarah Time", 7);
        static Employee james = new("James Doe", 4);

        static readonly Department itDepartment = new("IT");

        public static void Main()
        {
            salesDepartment.AddNewEmployee(alex);
            salesDepartment.AddNewEmployee(linda);
            salesDepartment.AddNewEmployee(john);

            salesDepartment.PrintTotalBudget();

            itDepartment.AddNewEmployee(sarah);
            itDepartment.AddNewEmployee(james); 

            itDepartment.PrintTotalBudget();
        }
    }
}
