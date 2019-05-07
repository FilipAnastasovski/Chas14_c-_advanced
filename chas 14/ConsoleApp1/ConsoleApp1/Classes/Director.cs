using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Director : ManagementStuff
    {
        public Director()
        {

        }

        public Director(int id, string firstName, string lastName, string password, DateTime bday, DateTime hireDay, string email, double salary)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Role = Role.Accountant;
            BirthDate = bday;
            HireDate = hireDay;
            Salary = salary;
            Email = email;

        }

        public override void SendCommunication()
        {
            Logger.Log("Director sent a message"); ;
        }
    }
}
