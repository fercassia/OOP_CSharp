namespace BeachBank.Clients
{
    public class BankAccount
    {
        private int AgencyClient { get; set; }

        private int NumberAccountClient { get; set; }

        private double BalanceClient = 10;

        public static int TotalAccountCreated { get; private set; }//It will not permit the change the count of number of accounts created;

        public int Agency//For agency_Client (private) -> client need put his agency correctly, but not change nothing and it need be different of 0;
        {
            get
            {
                return AgencyClient;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                AgencyClient = value;
            }
        }

        public int Number//For number_Account_Client (private) -> client need put his agency correctly, but not change nothing and it need be different of 0;
        {
            get
            {
                return NumberAccountClient;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                NumberAccountClient = value;
            }
        }
        public double Balance//For balance_Client (private) -> If client want put some value on this account, but not values negatives like -10;
        {
            get
            {
                return BalanceClient;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                BalanceClient = value;
            }
        }

        public BankAccount(int agency, int numberAccount) //Constructor
        {

            Agency = agency;
            Number = numberAccount;

            TotalAccountCreated++;//Count of accounts created;
        }          
    }
}
