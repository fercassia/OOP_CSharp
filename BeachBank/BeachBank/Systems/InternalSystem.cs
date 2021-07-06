using BeachBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachBank.Systems
{
    public class InternalSystem
    {
        public bool Login(ISystemValidate employee, string password)
        {
            var exception = new InvalidOperationException("The provided password is invalid");
            bool userValidated = employee.Validate(password);

            if (userValidated) Console.WriteLine("Welcome to internal system");
            else throw exception;

            return userValidated;
        }
    }
}
