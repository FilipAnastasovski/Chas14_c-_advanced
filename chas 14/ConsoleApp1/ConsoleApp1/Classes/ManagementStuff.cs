using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public abstract class ManagementStuff : Employee, IManagable
    {
        private List<Employee> PeopleEmployed = new List<Employee>();

        public void AddSubEmployee(Employee e)
        {
            PeopleEmployed.Add(e);
        }

        // treba poubavo
        //public void RemoveEmployee(Employee e)
        //{
        //    PeopleEmployed.Remove(e);
        //}

        public void GetEmployees()
        {
           foreach(var item in PeopleEmployed)
            {
                Logger.Log(item.ToString());
            }
        }

        public string EmailList
        {
            get { return string.Join("; ", PeopleEmployed.Select(e => e.Email)); } 
        }
        //

       public void PromoteSubEmployees(int totalPromotionAmount)
        {
            try
            {
                double eaqualAmmount = totalPromotionAmount / PeopleEmployed.Count;

                foreach (var item in PeopleEmployed)
                {
                    item.Salary += eaqualAmmount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        //
        public void DoEmployeeApprisal(Employee e)
        {
            Logger.Log($"Brabo {e.FirstName}");
        }

        public void Manage()
        {
            Logger.Log("managing stuff"); 
        }

        public void PromoteEmployee(Employee e)
        {
            Logger.Log($"Unapreden e {e.FirstName}");
        }

        public abstract void SendCommunication();

        
       
    }
}
