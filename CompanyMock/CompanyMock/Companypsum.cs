using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMock
{
    internal class Companypsum
    {
        static Employee alex = new Employee("Alex Rod", 6);
        static Employee linda = new Employee("Linda Berry", 7);
        static Employee john = new Employee("John Doe", 3);
        static Employee[] salesDepartmentEmployees = { alex, linda, john };

        static readonly Department salesDepartment = new("Sales", salesDepartmentEmployees);

        static Employee sarah = new Employee("Sarah Time", 7);
        static Employee james = new Employee("James Doe", 4);
        static Employee[] itDepartmentEmployees = { sarah, james };

        static readonly Department itDepartment = new("IT", itDepartmentEmployees);

        public static void Main()
        {
            salesDepartment.PrintTotalBuget();

            itDepartment.PrintTotalBuget();
        }
    }
}
