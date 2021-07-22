using System;

namespace BeachBank.ValidateInformation
{
    public class CpfValidatorService : ICpfValidator
    {
        private const int CPF_LENGTH = 11;

        public string HandleInvalidCPFAttribution(string cpf)
        {
            var exception = new InvalidOperationException("ERROR!!! The provided CPF is invalid.");

            int[] cpfAsIntArray = ConvertCpfToIntArray(cpf);

            if (!ValidateLength(cpf)) throw exception;            
            if (!ValidateCpfNineFirstDigits(cpfAsIntArray)) throw exception;
            if (!ValidateRemainingRules(cpfAsIntArray)) throw exception;

            return cpf;
        }

        private static bool ValidateLength(string cpf)
        {
            return (!(cpf.Equals("00000000000") || !cpf.Length.Equals(CPF_LENGTH)));
        }

        private static bool ValidateRemainingRules(int[] cpfAsIntArray)
        {
            int sum = 0;
            int result;
            for (int aux = 0; aux < 10; aux++)
                sum += (CPF_LENGTH - aux) * cpfAsIntArray[aux];

            result = sum % CPF_LENGTH;
            
            if ((result < 2) && (!cpfAsIntArray[10].Equals(0))) return false;
            
            if (!cpfAsIntArray[10].Equals(CPF_LENGTH - result)) return false;

            return true;
        }

        private static bool ValidateCpfNineFirstDigits(int[] cpfAsIntArray)
        {
            var sum = 0;
            for (int aux = 0; aux < 9; aux++)
                sum += (10 - aux) * cpfAsIntArray[aux];

            var result = sum % CPF_LENGTH;
            
            if ((result < 2) && (!cpfAsIntArray[9].Equals(0))) return false;
            
            if (!cpfAsIntArray[9].Equals(CPF_LENGTH - result)) return false;

            return true;
        }

        private static int[] ConvertCpfToIntArray(string cpf)
        {
            var cpfAsIntArray = new int[CPF_LENGTH];
            for (int x = 0; x < CPF_LENGTH; x++)
            {
                cpfAsIntArray[x] = int.Parse(cpf[x].ToString());
            }
            return cpfAsIntArray;
        }
    }
}
