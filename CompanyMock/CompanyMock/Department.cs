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
        private Employee[] employees;

        public Department(string departmentName, Employee[] employees)
        {
            this.departmentName = departmentName;
            this.employees = employees;
        }

        public void PrintTotalBuget() => Console.WriteLine("The total budget for {0} department is equal to {1}.", departmentName, TotalBudget);


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
