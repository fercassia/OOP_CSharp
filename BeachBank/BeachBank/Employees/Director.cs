namespace BeachBank.Employees
{
    public class Director : EmployeeForValidate
    {
        public double IncreaseSalaryFactor { get; set; } = 1.5;

        public double SalaryBonusFactor { get; set; } = 0.7;


        public Director(string name, string cpf, double salary) : base(name, cpf, salary) { }

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
