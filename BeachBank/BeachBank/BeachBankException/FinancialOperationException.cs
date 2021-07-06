using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.BeachBankExceptions
{
    public class FinancialOperationException : Exception
    {
        public double ValueException { get; private set; }
        
        public double BalanceException { get; private set; }
                
        public FinancialOperationException()
        {
        }
        public FinancialOperationException(string message) : base(message)
        {
        }
        public FinancialOperationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
