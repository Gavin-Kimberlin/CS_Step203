using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step203
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            { 
                employees.Add(new Employee { FirstName = "Jerry", LastName = "Smith", Id = 0});
                employees.Add(new Employee { FirstName = "Bill", LastName = "Johnson", Id = 1});
                employees.Add(new Employee { FirstName = "Jim", LastName = "Williams", Id = 2});
                employees.Add(new Employee { FirstName = "Joe", LastName = "Brown", Id = 3});
                employees.Add(new Employee { FirstName = "Dwight", LastName = "Jones", Id = 4});
                employees.Add(new Employee { FirstName = "Karen", LastName = "Garcia", Id = 5});
                employees.Add(new Employee { FirstName = "Felix", LastName = "Miller", Id = 6});
                employees.Add(new Employee { FirstName = "Gary", LastName = "Davis", Id = 7});
                employees.Add(new Employee { FirstName = "Dan", LastName = "Rodriguez", Id = 8});
                employees.Add(new Employee { FirstName = "Joe", LastName = "Martinez", Id = 9});
            }

            List<Employee> Joes = new List<Employee>();
            foreach ( var Employee in employees)
            {
                if (Employee.FirstName == "Joe")
                {
                    Joes.Add(Employee);
                    Console.WriteLine(Employee.FirstName + " " + Employee.LastName + " was added to the Joes list.");
                }
            }

            List<Employee> Joes2 = employees.FindAll(Employee => Employee.FirstName == "Joe");
            foreach(var Employee in Joes2)
            {
                Console.WriteLine(Employee.FirstName + " " + Employee.LastName + " was added to the second Joes list.");
            }

            List<Employee> idGreaterThan5 = employees.FindAll(Employee => Employee.Id > 5);
            foreach (var Employee in idGreaterThan5)
            {
                Console.WriteLine(Employee.FirstName + " " + Employee.LastName + " was added to the ID greater than 5 list.");
            }

            Console.ReadLine();
        }
    }
}
