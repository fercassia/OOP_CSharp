using BeachBank.ValidateInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.Employees
{
    public abstract class Employee
    {
        public static int TotalEmployee { get; private set; }
        public string Cpf { get; }

        public string EmployeeName { get; }

        public double Salary { get; protected set; }

        public Employee(string employeeName, string employeeCpf, double employeeSalary)
        {
            var cpfValidation = new CpfValidatorService();

            EmployeeName = employeeName;
            Cpf = cpfValidation.HandleInvalidCPFAttribution(employeeCpf);
            Salary = employeeSalary;

            TotalEmployee++;

            Console.WriteLine($"Creating a employee {EmployeeName}");
        }

        public abstract void IncreaseSalary();

        public abstract double SalaryBonus();

    }
}
