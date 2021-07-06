using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.Employees
{
    public class Designer : Employee
    {
        public Designer(string employeeName, string employeeCpf) : base(employeeName, employeeCpf, 4150.00)
        {
        }
        public override void IncreaseSalary()
        {
            Salary += (Salary * 0.35);
        }

        public override double SalaryBonus()
        {
            return Salary *= 0.35;
        }
    }
}
