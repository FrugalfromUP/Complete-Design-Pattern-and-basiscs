using Practice.Solid.SolidS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class SolidS
    {
        /*Without Without Single Responsibility Principle
        lets take a hospital where we have some patient and some procedure for patient i.e.AdmitPatient, PerformSurgery, GenerateReport


       here we have a class which has all the funtion which is supposed to be procedure


        static void Main(string[] args)
        {
            Procedures proc = new Procedures();
            proc.AdmitPatient("Ritesh");
            proc.PerformSurgery("Ritesh");
            proc.GeneraReport("Ritesh");
            Console.ReadKey();
        }
        HospitalManagement class violates the SRP as it is responsible for admitting patients,
        performing surgeries, and generating patient reports.This can lead to a situation where

        changes in one functionality may affect others, making the code less maintainable.


       end region
        */



        /*With Single responsiblity Principle 
         here what we will do we will create seperate classes for diffrent 

        Now by seperating diffrent proc in diffrent diffrent classes will not violates SRP
        becoz our one class has only one purpose or has only one reson to change     
         */
        static void Main(string[] args)
        {
            ProcedureAdmit procedureAdmit = new ProcedureAdmit();
            ProcedureSurgery procedureSurgery = new ProcedureSurgery();
            ProcedureReport procedureReport = new ProcedureReport();
            procedureAdmit.AdmitPatient("Ritesh");
            procedureSurgery.PerformSurgery("Ritesh");
            procedureReport.GeneraReport("Ritesh");
            Console.ReadKey();
        }


    }
}
