using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public Role Role { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }

        public string Email { get; set; }
        public double Salary { get; set; }


        public override string ToString()
        {
            return $"{ID}\t{FirstName}\t{LastName}\t{Role}\t{Email}\t{Salary}\t{BirthDate}\t{HireDate}";
        }

        public  string TimeInCompany()
        {

            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - HireDate.Year;
            // Go back to the year the person was born in case of a leap year
            if (HireDate > today.AddYears(-age)) age--;
            return $"{age}";
        }

        //public void PrintInfo()
        //{
        //    Console.WriteLine("First Name: {0}, Last Name: {1}, Role: {2}", FirstName, LastName, Role);
        //}
    }
}
