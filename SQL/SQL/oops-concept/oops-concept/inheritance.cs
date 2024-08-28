using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
    internal class inheritance
    {
        //single inheritence
        //public class Employee
        //{
        //    public string Name { get; set; }
        //    public int Id { get; set; }
        //    public void Work()
        //    {
        //        Console.WriteLine("Working");
        //    }
        //}

        //public class Manager : Employee
        //{
        //    public void Manage()
        //    {
        //        Console.WriteLine("Managing");
        //    }
        //}
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        Manager myManager = new Manager { Name = "Shree", Id = 1 };
        //        myManager.Work(); 
        //        myManager.Manage(); 
        //    }
        //}

        ////MULTIPLE INHERITANCE
        //// Interface 1
        //public interface Student
        //{
        //    void AttendClasses();
        //    void CompleteAssignments();
        //}

        //// Interface 2
        //public interface Researcher
        //{
        //    void ConductResearch();
        //    void PublishPapers();
        //}

        //// Derived class
        //public class StudentResearcher : Student, Researcher
        //{
        //    public void AttendClasses()
        //    {
        //        Console.WriteLine("Attending classes");
        //    }

        //    public void CompleteAssignments()
        //    {
        //        Console.WriteLine("Completing assignments");
        //    }

        //    public void ConductResearch()
        //    {
        //        Console.WriteLine("Conducting research");
        //    }

        //    public void PublishPapers()
        //    {
        //        Console.WriteLine("Publishing papers...");
        //    }
        //}

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        StudentResearcher studentResearcher = new StudentResearcher();
        //        studentResearcher.AttendClasses(); 
        //        studentResearcher.CompleteAssignments(); 
        //        studentResearcher.ConductResearch();
        //        studentResearcher.PublishPapers(); 
        //    }
        //}
        //MULTILEVEL INHERITENCE
        //        public class Vehicle
        //        {
        //            public string Make { get; set; }
        //            public string Model { get; set; }
        //            public void Move()
        //            {
        //                Console.WriteLine("Moving");
        //            }
        //        }
        //         // Derived class 1
        //        public class Car : Vehicle
        //        {
        //            public void Drive()
        //            {
        //                Console.WriteLine("Driving");
        //            }
        //        }
        //         // Derived class 2
        //        public class ElectricCar : Car
        //        {
        //            public void Charge()
        //            {
        //                Console.WriteLine("Charging");
        //            }
        //        }
        //        class Program
        //        {
        //            static void Main(string[] args)
        //            {
        //                ElectricCar myElectricCar = new ElectricCar { Make = "Swift", Model = "Model S" };
        //                myElectricCar.Move();
        //                myElectricCar.Drive(); 
        //                myElectricCar.Charge(); 
        //            }
        //        }
        ////HIERARCHICAL INHERITENCE
        //// Base class
        //public class Employee
        //{
        //    public string Name { get; set; }
        //    public int Id { get; set; }
        //    public void Work()
        //    {
        //        Console.WriteLine("Working...");
        //    }
        //}
        //// Derived class 1
        //public class Developer : Employee
        //{
        //    public void Code()
        //    {
        //        Console.WriteLine("Coding...");
        //    }
        //}
        // // Derived class 2
        //public class Tester : Employee
        //{
        //    public void Test()
        //    {
        //        Console.WriteLine("Testing...");
        //    }
        //}
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        Developer myDeveloper = new Developer { Name = "John", Id = 1 };
        //        myDeveloper.Work();  // Output: Working...
        //        myDeveloper.Code(); // Output: Coding...

        //        Tester myTester = new Tester { Name = "Jane", Id = 2 };
        //        myTester.Work();  // Output: Working...
        //        myTester.Test(); // Output: Testing...
        //    }
        //}

    }
}
