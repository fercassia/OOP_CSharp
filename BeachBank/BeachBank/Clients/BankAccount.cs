using BeachBank.BeachBankExceptions;
using System;

namespace BeachBank.Clients
{
    public class BankAccount
    {
        public int AgencyClient { get; }//Allow declare ONLY constructor, after that allow ONLY read;

        public int NumberAccountClient { get; }//Allow declare ONLY constructor, after that allow ONLY read;

        public static int TotalAccountCreated { get; private set; }//It will not permit the change the count of number of accounts created;

        public double Balance { get; private set; }

        public void UpdateBalance(double valueToUpdate)
        {
            try
            {
                var result = Balance + valueToUpdate;

                if (result < 0) throw new FinancialOperationException("\nCan't do this operation... The balance can't be lower than 0.");

                Balance = result;

                Console.WriteLine("The Operation made with successful");
            }
            catch (FinancialOperationException e)
            {
                Console.WriteLine($"The message is: {e.Message}");
                Console.WriteLine($"\nThe StackTrace is:\n {e.StackTrace}");
            }
        }
        
        public BankAccount(int agency, int numberAccount) //Constructor
        { 
            try
            {
                if (agency <= 0) throw new ArgumentException($"\nThe argument of {nameof(agency)} is invalid (is 0 or lower than 0)");
                if (numberAccount <= 0) throw new ArgumentException($"\nThe argument of {nameof(numberAccount)} is invalid (is 0 or lower than 0)");

                AgencyClient = agency;
                NumberAccountClient = numberAccount;

                TotalAccountCreated++;//Count of accounts created;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine($"The StackTrace is: {e.StackTrace}");        
            }
        }
    }
}
