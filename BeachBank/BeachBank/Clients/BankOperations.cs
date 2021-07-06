using System;

namespace BeachBank.Clients
{
    class BankOperations
    {
        public void Deposit(double value, BankAccount informationForOperations)
        {
            informationForOperations.UpdateBalance(value);
        }

        public void Withdraw(double value, BankAccount informationForOperations)
        {
            informationForOperations.UpdateBalance(-value);
        }

        public void Transference(double value, BankAccount destinyBankAccount, BankAccount informationForOperations)
        {
            Withdraw(value, informationForOperations);
            Deposit(value, destinyBankAccount);
        }

        public void Pay(double value, BankAccount informationForOperations)
        {
            Withdraw(value, informationForOperations);
        }

    }
}
