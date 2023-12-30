using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMock
{
    internal class Employee
    {
        string name;
        int grade;

        public Employee(string name, int grade) 
        {
            this.name = name;
            SetGrade(grade);
        }

        private void SetGrade(int grade)
        {
            if (grade > 10 || grade < 0) return;

            this.grade = grade;
        }

        public bool HasHighGrade() => grade >= 5;
    }
}
