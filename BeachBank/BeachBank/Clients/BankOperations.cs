using System;

namespace BeachBank.Clients
{
    class BankOperations
    {
        public void Deposit(double value, BankAccount informationForOperations)
        {
            informationForOperations.Balance += value;
        }

        public bool Transference(double value, BankAccount destinyBankAccount, BankAccount informationForOperations)
        {
            if(informationForOperations.Balance < value)
            {
                Console.WriteLine("Insufficient funds");
                return false;
            }
            informationForOperations.Balance -= value;
            destinyBankAccount.Balance += value;
            Console.WriteLine("Transfer Successful");
            return true;
        }

        public bool Pay(double value, BankAccount informationForOperations)
        {
            if (informationForOperations.Balance < value)
            {
                Console.WriteLine("Insufficient funds");
                return false;
            }
            informationForOperations.Balance -= value;
            Console.WriteLine("Payment Successful");
            return true;
        }

        public bool Withdraw(double value, BankAccount informationForOperations)
        {
            if (informationForOperations.Balance < value)
            {
                Console.WriteLine("Insufficient funds");
                return false;
            }
            informationForOperations.Balance -= value;
            Console.WriteLine("Withdraw Successful");
            return true;
        }

    }
}
