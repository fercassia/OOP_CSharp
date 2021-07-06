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
        static void Main(string[] args)
        {
            //CustumerMovement();
            EmplyoeeIniciation();
            
        }

        public static void CustumerMovement()
        {
            var bankAcocunts = new List<BankAccount>
            {
                new BankAccount(1, 1),
                new BankAccount(2, 2)
            };

            var cpfValitation = new CpfValidatorService();

            var client = new Client("Fernanda", "80469611677", cpfValitation, bankAcocunts);
            client.AddAccount(new BankAccount(3, 3));

            var operation = new BankOperations();

            operation.Deposit(500, client.BankAccount[1]);
            operation.Transference(5, client.BankAccount[2], client.BankAccount[0]);

            Console.WriteLine(client.BankAccount[1].Balance);
            Console.WriteLine(client.BankAccount[2].Balance);
            Console.WriteLine(client.BankAccount[0].Balance);

            Console.WriteLine(client.Cpf);
            Console.WriteLine(client.HolderName);
        }
        public static void EmplyoeeIniciation()
        {
            var internalSystem = new InternalSystem();

            var joao = new Director("Joao", "09640097659"); //caminho feliz senha
            joao.IncreaseSalary();
            Console.WriteLine(joao.Salary);
            joao.Password = "joao41";

            internalSystem.Login(joao, "joao41");

            var joaoAlves = new Director("Joao Alves", "09640097659"); //Erro na senha
            joaoAlves.IncreaseSalary();
            Console.WriteLine(joaoAlves.Salary);
            joaoAlves.Password = "JAlvs60";

            internalSystem.Login(joao, "joao41");

            var xande = new Partner(); // caminho feliz senha
            xande.Password = "4190@";

            internalSystem.Login(xande, "4190@");

            var camila = new Partner(); //erro na senha
            camila.Password = "Camilao1";

            internalSystem.Login(camila, "Camila");

            var fernanda = new Director("fernanda", "09640097650"); // erro no cpf
            fernanda.SalaryBonus();
            Console.WriteLine(fernanda.Salary);
            fernanda.Password = "fehfe12";

            internalSystem.Login(fernanda, "fehfe12");

        }
    }
}
