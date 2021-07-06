using BeachBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.Employees
{
    public abstract class EmployeeForValidate : Employee, ISystemValidate //Only manager, director and Partner have accesse to Intern System
    {
        public string Password { get; set; }

        public EmployeeForValidate (string employeeName, string employeeCpf, double employeeSalary) : base (employeeName, employeeCpf, employeeSalary)
        {
        }

        public bool Validate(string senha)
        {
            return Password.Equals(senha);
        }
    }
}
