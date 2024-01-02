using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class LinQEmployee
    {
        public static void Main(string[] args)
        {

            List<Employee> employees = DataManger.GetEmployee();

            //employees = employees.Take(2).ToList();
            //employees = employees.Skip(2).ToList();
            //employees = employees.Distinct().ToList();
            var id  = employees.Min(e => e.Id); 
            
            
            Console.WriteLine(id);

            //employees.ForEach(employee =>
            //{
            //    Console.WriteLine("Id = {0}, Name = {1}, MobileNo= {2}, Email = {3}", employee.Id, employee.Name, employee.MobileNo, employee.Email);
            //});

            //employees = employees.Where(e => e.Id == 2).ToList();
            //var employee = employees.SingleOrDefault();


            //Console.WriteLine("Id = {0}, Name = {1}, MobileNo= {2}, Email = {3}", employee.Id, employee.Name, employee.MobileNo, employee.Email);


            // employees = employees.OrderBy(e=>e.Name).ThenBy(e=> e.Email).ToList();



            //var ep = employees.Select(e => e.Id);
            //foreach(int i in ep)
            //{
            //    Console.WriteLine(i);
            //}

            //employees.ForEach(employee =>
            //{
            //    Console.WriteLine("Id = {0}, Name = {1}, MobileNo= {2}, Email = {3}", employee.Id, employee.Name, employee.MobileNo, employee.Email);
            //});
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine("Id = {0}, Name = {1}, MobileNo= {2}, Email = {3}",employee.Id,employee.Name,employee.MobileNo,employee.Email);
            //}
            Console.ReadKey();
        }

    }
}
