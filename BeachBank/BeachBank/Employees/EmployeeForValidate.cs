using BeachBank.Systems;

namespace BeachBank.Employees
{
    public abstract class EmployeeForValidate : Employee, ISystemValidate //Only manager, director and Partner have access to Intern System
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
