using BeachBank.Employees;
using BeachBank.Partners;
using System;

namespace BeachBank.Systems
{
    public class Authenticator
    {
        public bool Login(ISystemValidate user, string password)
        {
            var exception = new InvalidOperationException("The provided password is invalid");

            if (!user.Validate(password))
                throw exception;

            if (user.GetType().ToString().Contains("Employee"))
            {
                Employee employee = (Employee)user;
                Console.Write($"\nWelcome to internal system: {employee.EmployeeName}");
            }
            else
            {
                Console.Write($"\nWelcome to internal system, Partner!");
            }

            return true;
        }
    }
}
