using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.Employees
{
    public class Designer : Employee
    {
        public double IncreaseSalaryFactor { get; set; }

        public double SalaryBonusFactor { get; set; }

        public Designer(string name, string cpf, double salary) : base(name, cpf, salary) { }

        public override void IncreaseSalary()
        {
            Salary *= IncreaseSalaryFactor;
        }

        public override double SalaryBonus()
        {
            return Salary * SalaryBonusFactor;
        }
    }
}
