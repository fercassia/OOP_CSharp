using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.ValidateInformation
{
    public interface ICpfValidator
    {
        string HandleInvalidCPFAttribution(string cpf);
    }
}
