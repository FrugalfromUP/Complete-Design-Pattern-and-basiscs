using Practice.Solid.SolidL.WIthoutLSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class SolidL
    {
        static void DisplayPersonDetails(Person person)
        {
            person.DisplayDetails();
        }
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor { Name = "Dr. Smith", Specialization = "Cardiologist" };
            Patient patient = new Patient { Name = "John Doe", HealthCondition = "Fever" };

            DisplayPersonDetails(doctor); // Liskov violation: Displaying specialization for a patient
            DisplayPersonDetails(patient);

            Console.ReadLine();
        }
    }
}
