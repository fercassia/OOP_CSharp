using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.Employees
{
    public class Developer : Employee
    {
        public Developer(string employeeName, string employeeCpf) : base(employeeName, employeeCpf, 4000.00)
        {
        }
        public override void IncreaseSalary()
        {
            Salary += (Salary * 0.30);
        }

        public override double SalaryBonus()
        {
            return Salary *= 0.30;
        }
    }
}
