using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; } 
        public string Email { get; set; }
        

        
    }
    public class DataManger
    {
        public static List<Employee> GetEmployee()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Ritesh", MobileNo = "7617698946", Email = "Ritesh@gmail.com"},
                new Employee { Id = 2, Name = "Yugank", MobileNo = "3237698946", Email = "Yugank@gmail.com"},
                new Employee { Id = 3, Name = "Pankaj", MobileNo = "5647698946", Email = "Pankaj@gmail.com"},
                new Employee { Id = 4, Name = "Ashish", MobileNo = "5767698946", Email = "Ashish@gmail.com"},
                new Employee { Id = 5, Name = "Mayank", MobileNo = "8867698946", Email = "Mayank@gmail.com"},
            };
        }

    }
}
