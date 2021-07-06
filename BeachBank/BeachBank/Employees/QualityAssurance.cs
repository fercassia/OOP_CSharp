using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.Employees
{
    public class QualityAssurance : Employee
    {
        public QualityAssurance(string employeeName, string employeeCpf) : base(employeeName, employeeCpf, 4000.00)
        {

        }
        public override void IncreaseSalary()
        {
            Salary += 1.20;
        }

        public override double SalaryBonus()
        {
            return Salary *= 0.15;
        }
    }
}
