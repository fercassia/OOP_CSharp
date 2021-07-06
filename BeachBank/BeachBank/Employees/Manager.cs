using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.Employees
{
    public class Manager : EmployeeForValidate
    {
        public Manager(string employeeName, string employeeCpf) : base(employeeName, employeeCpf, 5500.00)
        {

        }
        public override void IncreaseSalary()
        {
            Salary += (Salary * 0.45);
        }

        public override double SalaryBonus()
        {
            return Salary *= 0.55;
        }
    }
}
