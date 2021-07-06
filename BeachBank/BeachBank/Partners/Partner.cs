using BeachBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.Partners
{
    public class Partner : ISystemValidate
    {
        public string Password { get; set; }

        public bool Validate(string senha)
        {
            return Password.Equals(senha);
        }
    }
}
