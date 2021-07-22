namespace BeachBank.Clients
{
    class BankOperation
    {
        public void Deposit(double value, BankAccount bankAccountForDepositing)
        {
            bankAccountForDepositing.UpdateBalance(value);
        }

        public void Withdraw(double value, BankAccount bankAccountForWithdrawing)
        {
            bankAccountForWithdrawing.UpdateBalance(-value);
        }

        public void Transfer(double value, BankAccount destinationBankAccount, BankAccount originBankAccount)
        {
            Withdraw(value, originBankAccount);
            Deposit(value, destinationBankAccount);
        }

        public void Pay(double value, BankAccount bankAccountForWithdrawing)
        {
            Withdraw(value, bankAccountForWithdrawing);
        }

    }
}
