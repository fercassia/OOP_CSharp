using BeachBank.ValidateInformation;
using System.Collections.Generic;

namespace BeachBank.Clients
{
    public class Client
    {
        public string Cpf { get; }//Allow declare ONLY constructor, after that allow ONLY read;

        public int NumberOfAccounts { get; private set; }

        public Client(string clientName, string clientCpf, ICpfValidator cpfValidator, List<BankAccount> bankAccounts = default)
        {
            HolderName = clientName;
            Cpf = cpfValidator.HandleInvalidCPFAttribution(clientCpf);

            BankAccount = bankAccounts is null ? new List<BankAccount>() : bankAccounts;

            if (bankAccounts != null) 
            {
                bankAccounts.ForEach(_ => NumberOfAccounts++);
            }
        }

        public List<BankAccount> BankAccount { get; }//Allow declare ONLY constructor, after that allow ONLY read;

        public string HolderName {get; }//Allow declare ONLY constructor, after that allow ONLY read;

        public void AddAccount(BankAccount account) 
        {
            BankAccount.Add(account);

            NumberOfAccounts++;
        }
    }
}
