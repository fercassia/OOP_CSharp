using BeachBank.ValidateInformation;
using System.Collections.Generic;

namespace BeachBank.Clients
{
    public class Client
    {
        public string Cpf { get; private set; }

        public Client(string clientName, string clientCpf, ICpfValidator cpfValidator, List<BankAccount> bankAccounts = default)
        {
            HolderName = clientName;
            Cpf = cpfValidator.HandleInvalidCPFAttribution(clientCpf);

            BankAccount = bankAccounts is null ? new List<BankAccount>() : bankAccounts;
        }

        //public ValidateCPF CPF { get; private set; }
        //public string Cpf { get; private set; }

        public List<BankAccount> BankAccount { get; private set; }

        public string HolderName {get; private set;}

        public void AddAccount(BankAccount account) 
        {
            BankAccount.Add(account);
        }
    }
}
