using System;

namespace EfCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var _Context = new ApplicationDbContext();
            var employee = new Employee
            { };
              
            _Context.Employees.Add(employee);
            _Context.SaveChanges();
        }
    }
}
