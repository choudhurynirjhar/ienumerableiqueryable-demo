using System;
using System.Linq;

namespace IEnumerableIQueryable.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeContext("Persist Security Info = False; Integrated Security = true; Initial Catalog = EFDemo; server = .\\SQLEXPRESS");
            
            IQueryable<Employee> employees = context.Employees
                .Where(e => e.Id > 1);
            var topTwoEmployees = employees.Take(2);
            
            foreach (var employee in topTwoEmployees)
            {
                Console.WriteLine($"Name - {employee.FirstName} {employee.LastName}");
            }
        }
    }
}
