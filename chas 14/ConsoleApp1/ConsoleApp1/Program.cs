using ConsoleApp1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.ArchiveLog();
            TechnicalStuff t1 = new TechnicalStuff
            {
                FirstName = "aaa",
                LastName = "aaa",
                ID = 123,
                Role = Role.TechnicalStuff,
                Password = "123qwe",
                BirthDate = new DateTime(2000, 1, 18),
                HireDate = new DateTime(2020, 1, 18),
                Email = "aaa@yahoo.com",
                Salary = 123
            };

            Robot r1 = new Robot
            {
                ID=321,
                FirstName = "bbb",
                LastName = "bbb",
                Role = Role.Robot,
                Password = "123qwe",
                BirthDate = new DateTime(2015, 1, 18),
                HireDate = new DateTime(2020, 1, 18),
                Email = "bbb@yahoo.com",
                Salary = 123
            };

            Director d1 = new Director
            {
                ID=111,
                FirstName = "ccc",
                LastName = "ccc",
                Role = Role.Director,
                Password = "123qwe",
                BirthDate = new DateTime(1990, 1, 18),
                HireDate = new DateTime(2000, 1, 18),
                Email = "ccc@yahoo.com",
                Salary = 123
            };

            Menager m1 = new Menager
            {
                ID=222,
                FirstName = "ddd",
                LastName = "ddd",
                Role = Role.Menager,
                Password = "123qwe",
                BirthDate = new DateTime(2015, 1, 18),
                HireDate = new DateTime(2020, 1, 18),
                Email = "ddd@yahoo.com",
                Salary = 123
            };

            Accountant a1 = new Accountant
            {
                ID = 222,
                FirstName = "eee",
                LastName = "eee",
                Role = Role.Accountant,
                Password = "123qwe",
                BirthDate = new DateTime(1995, 1, 18),
                HireDate = new DateTime(2015, 1, 18),
                Email = "eee@yahoo.com",
                Salary = 123
            };



            Console.WriteLine("{0} ", a1.ToString());
            Console.WriteLine("{0} ", a1.TimeInCompany());
            
            m1.DoEmployeeApprisal(a1);
            

            //Console.WriteLine("{0} ", d1.ToString());
            //Console.WriteLine("{0} ", d1.TimeInCompany());
            Console.WriteLine("-----------");
            d1.AddSubEmployee(a1);
            d1.AddSubEmployee(t1);
            d1.AddSubEmployee(r1);
            d1.GetEmployees();
            Console.WriteLine("-----------");
            Console.WriteLine(d1.EmailList); ;
            Console.WriteLine("-----------");
            Logger.ArchiveLog();
            Console.WriteLine("-----------");
            d1.PromoteSubEmployees(0);
            Console.WriteLine(a1.Salary);

            m1.SendCommunication();








            Console.ReadLine(); 
        }
    }
}
