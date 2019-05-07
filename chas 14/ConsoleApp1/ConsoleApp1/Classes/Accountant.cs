using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Classes
{
    public class Accountant : Employee, IEatable, IManagable
    {
        public Accountant()
        {

        }

        public Accountant(int id, string firstName, string lastName, string password, DateTime bday, DateTime hireDay, string email, double salary )
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

        public void Eat()
        {
            Logger.Log("hunger satisfied"); 
        }

        public void MaintainAccounts()
        {
            Logger.Log("maintaining accounts");
        }

        public void Manage()
        {
            Logger.Log("Managing accountant stuff");
        }
    }
}
