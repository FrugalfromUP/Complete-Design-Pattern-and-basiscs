using Practice.Solid.SolidO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class SolidO
    {
        /*Without Open/Closed Principle*/
        //static void Main(string[] args)
        //{
        //    Hospital hospital = new Hospital
        //    {
        //         HospitalName = "jupitar Hopital",
        //         Doctors = new List<Doctor>
        //         {
        //             new Doctor {DoctorName = "N S Verma" , Specialisaiton = "Dermatologist"},
        //             new Doctor {DoctorName = "R S Gupta" , Specialisaiton = "cardiology"}
        //         }
        //    };

        //    // now every doctor will check the patient one by one 
        //    foreach (var doctor in hospital.Doctors)
        //    {
        //        doctor.TreatPatient(doctor.DoctorName);
        //    }
        //    Console.ReadKey(); 
        //}
        /*end region
         
        In the above code i want to add one more staff i.e. Nurse with out mdifying existing code i can do this by introducing a interface.
         we can easily extend the system to include different types of medical staff (e.g., nurses) without modifying existing code. 
         */
        //With Open close principle
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital
            {
                HospitalName = "jupitar Hopital",
                staffTreats = new List<IStaffTreat>
                 {
                     new Doctor {Name = "N S Verma" , Specialisaiton = "Dermatologist"},
                     new Doctor {Name = "R S Gupta" , Specialisaiton = "cardiology"},
                     new Nurse {Name = "Sis Reeba s"},
                     new HouseKeeper{Name = "Ramesh"}
                 }
            };

            // now every Staff will Do his duty one by one 
            foreach (var staff in hospital.staffTreats)
            {
                staff.TreatPatient(staff.Name);
            }
            Console.ReadKey();
        }
    }
}
