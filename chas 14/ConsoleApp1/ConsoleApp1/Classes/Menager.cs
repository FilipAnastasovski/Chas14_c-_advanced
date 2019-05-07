using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
   public  class Menager : ManagementStuff
    {
        public Menager()
        {

        }

        public Menager(int id, string firstName, string lastName, string password, DateTime bday, DateTime hireDay, string email, double salary)
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
        
        public override async void SendCommunication()
        {
            Logger.Log("Menager sent a message");
            string msg = await SendCommunicationAsync();
            Logger.Log(msg);
        }

        public static async Task<string> SendCommunicationAsync()
        {
            await Task.Delay(10000);
            return "async Menager sent a message";
            //await Task.Run(() =>
            //{
            //    Thread.Sleep(10000);
            // });
            //return "async Menager sent a message";
        }
    }
}
