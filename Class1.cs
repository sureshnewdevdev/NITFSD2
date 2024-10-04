using System;

namespace ExampleApp
{
    // Partial Class - File 1
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Partial method declaration (it may or may not be implemented)
        partial void PrintFullName();

        // Constructor to initialize values
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
    }

    public class Dept 
    {
        public int DeptID { get; set; }
        public int DeptName { get; set; }
    }

    // EmpId,EMpName,DeptName

    class Program
    {

        static void Main(string[] args)
        {
            // Using anonymous types
            var student = new { Name = "John", Age = 25 };
            var course = new { CourseName = "C# Programming", Duration = 30 };

            var fruits = new { FruitsName = "Bannana", FruitsDescription = "Good Food" };
            Employee emp = new Employee() { ID=1, Name="Raj", DeptId=1 };
            var repoData = new 
                        { 
                EmployeeID=emp.ID,
                EmployeeName = emp.Name,
                DeptName = "Sale"
            };

            // Display anonymous type properties
            Console.WriteLine($"Student Name: {student.Name}, Age: {student.Age}");
            Console.WriteLine($"Course Name: {course.CourseName}, Duration: {course.Duration} days");

            // Using partial class and partial methods
            Person person = new Person("Jane", "Doe");
            person.DisplayPerson();
        }
    }
}
