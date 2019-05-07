using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    class TechnicalStuff : Employee, IWorkable, IEatable
    {
        public TechnicalStuff()
        {

        }

        public TechnicalStuff(int id, string firstName, string lastName, string password, DateTime bday, DateTime hireDay, string email, double salary)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Role = Role.TechnicalStuff;
            BirthDate = bday;
            HireDate = hireDay;
            Salary = salary;
            Email = email;

        }

        public void Eat()
        {
            Logger.Log("nom nom nom"); ;
        }

        public void MaintainSystems()
        {
            Logger.Log("maintaining systems");
        }

        public void Work()
        {
            Logger.Log("work human"); ;
        }
    }
}
