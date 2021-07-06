using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.Employees
{
    public class Director : EmployeeForValidate
    {
        public Director(string employeeName, string employeeCpf) : base(employeeName, employeeCpf, 8000.00)
        {
        }
        public override void IncreaseSalary()
        {
            Salary += (Salary*0.50);
        }

        public override double SalaryBonus()
        {
            return Salary *= 0.7;
        }
    }
}
