using System;

namespace BeachBank.ValidateInformation
{
    public class CpfValidatorService : ICpfValidator
    {
        public string HandleInvalidCPFAttribution(string cpf)
        {
            var exception = new InvalidOperationException("The provided CPF is invalid");

            var numbersCPF = new int[11];

            if(cpf.Equals("00000000000") || !cpf.Length.Equals(11))
            {
                Console.WriteLine("CPF invalid");
                throw exception;
            }
            //Adding CPF to a array to simplify the verification;
            for(int countCpf = 0; countCpf < 11; countCpf++)
            {
                numbersCPF[countCpf] = int.Parse(cpf[countCpf].ToString());
            }

            // Calculate the 2 lasts cpf digits;
            //Verifying the first last cpf digit;

            var sum = 0;

            for(int aux = 0; aux < 9; aux++) //adding of 9 first cpf numbers after multiply each numbers with 10 until 2 (deacreasing);
            {
                sum += (10 - aux) * numbersCPF[aux];
            }

            var result = sum % 11;//Verifying the remainder of 11;

            if(result < 2)
            {
                if (!numbersCPF[9].Equals(0))
                {
                    Console.WriteLine("CPF invalid");
                    throw exception;
                }
            }
            else if(!numbersCPF[9].Equals(11 - result))
            {
                Console.WriteLine("CPF invalid");
                throw exception;
            }

            //Verifying the first last cpf digit

            sum = 0;

            for(int aux = 0; aux < 10; aux++)//adding of 10 first cpf numbers after multiply each numbers with 11 until 2 (deacreasing); 
            {
                sum += (11 - aux) * numbersCPF[aux];
            }

            result = sum % 11; //Verifying the remainder of 11

            if(result < 2)
            {
                if (!numbersCPF[10].Equals(0))
                {
                    Console.WriteLine("CPF invalid");
                    throw exception;
                }
            }
            else if (!numbersCPF[10].Equals(11 - result))
            {
                Console.WriteLine("CPF invalid");
                throw exception;
            }

            return cpf;//The compiller will return the cpf
        }
    }
}
