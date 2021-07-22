using BeachBank.Clients;
using BeachBank.Employees;
using BeachBank.Partners;
using BeachBank.Systems;
using BeachBank.ValidateInformation;
using System;
using System.Collections.Generic;

namespace BeachBank
{
    class Program
    {
        static void Main()
        {
            EmployeeIniciation();
        }

        public static void CustomerMovement()
        {
            var bankAccounts = new List<BankAccount>
            {
                new BankAccount(1, 1),
                new BankAccount(2, 2)
            };

            var cpfValidatorService = new CpfValidatorService();

            var client = new Client("Fernanda", "80469611677", cpfValidatorService, bankAccounts);
            client.AddAccount(new BankAccount(3, 3));

            var bankOperation = new BankOperation();

            bankOperation.Deposit(500, client.BankAccount[1]);
            bankOperation.Transfer(5, client.BankAccount[2], client.BankAccount[0]);

            Console.WriteLine(client.BankAccount[1].Balance);
            Console.WriteLine(client.BankAccount[2].Balance);
            Console.WriteLine(client.BankAccount[0].Balance);

            Console.WriteLine(client.Cpf);
            Console.WriteLine(client.HolderName);
        }
        public static void EmployeeIniciation()
        {
            Console.Write("\n|||||||||||||||||||||||||||||||||||| Creating the users |||||||||||||||||||||||||||||||||||||\n");
            var joao = new Director("Caterine Zeta Jones", "09640097659", 8000.00);
            var joaoAlves = new Director("Almeirinda Silvestre", "09640097659", 9500.00);
            var fernanda = new Director("Clarissa Casale Doimo", "09640097650", 12000.00);
            var xande = new Partner();
            var camila = new Partner();            

            List<ISystemValidate> users = new List<ISystemValidate>
            {
                joao,
                joaoAlves,
                fernanda,
                xande,
                camila
            };

            Console.Write("\n\n|||||||||||||||||||||||||||||||| Showing everyone's salaries ||||||||||||||||||||||||||||||||");
            ShowingEveryonesSalaries(users);
            Console.WriteLine();

            Console.Write("\n\n|||||||||||||||||||||||||||||||||||| Logging In The Users |||||||||||||||||||||||||||||||||||");
            LoggingInTheUsers(users);
            Console.WriteLine();
        }

        private static void ShowingEveryonesSalaries(List<ISystemValidate> users)
        {
            foreach (ISystemValidate user in users)
            {
                if (user.GetType().ToString().Contains("Employee"))
                {
                    EmployeeForValidate employee = (EmployeeForValidate)user;
                    employee.IncreaseSalary();
                    Console.Write($"\n{employee.EmployeeName}'s salary is: {employee.Salary} and his/her salary bonus is: {employee.SalaryBonus()}");
                }
            }
        }

        private static void LoggingInTheUsers(List<ISystemValidate> users)
        {
            var authenticator = new Authenticator();
            foreach (ISystemValidate user in users)
            {
                if (user.GetType().ToString().Contains("Employee"))
                {
                    EmployeeForValidate employee = (EmployeeForValidate)user;
                    employee.Password = "teste";
                }
                else
                {
                    Partner partner = (Partner)user;
                    partner.Password = "teste";
                }
                authenticator.Login(user, "teste");
            }
        }
    }
}
