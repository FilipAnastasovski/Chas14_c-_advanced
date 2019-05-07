using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    class Robot : Employee, IWorkable
    {
        public Robot()
        {

        }

        public Robot(int id, string firstName, string lastName, string password, DateTime bday, DateTime hireDay, string email, double salary)
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


        public override string ToString()
        {
            return base.ToString() + "from robot";
        }

        public void MaintaingDatawareHouse()
        {
            Logger.Log("Maintaing Data wareHouse");
        }

        public void Work()
        {
            Logger.Log("work robot"); ;
        }
    }
}
