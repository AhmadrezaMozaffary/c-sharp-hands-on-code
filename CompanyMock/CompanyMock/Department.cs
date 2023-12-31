using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMock
{
     class Department
    {
        private readonly string departmentName;
        private int budget = 50000;
        private List<Employee> employees = new();

        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }

        public void AddNewEmployee (Employee employee)
        {
            employees.Add(employee);
        }

        public void PrintTotalBudget() => Console.WriteLine("The total budget for {0} department is equal to {1}.", departmentName, TotalBudget);


        private int TotalBudget
        {
            get
            {
                foreach (Employee employee in employees)
                {
                    if (employee.HasHighGrade())
                    {
                        this.budget += 150000;
                    }
                    else
                    {
                        this.budget += 100000;
                    }
                }
                return this.budget;
            }
        }
    }
}
