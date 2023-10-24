using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Noah Carrier", "How to train a dragon");
        System.Console.WriteLine(assignment1.GetSummary());
        System.Console.WriteLine();
        
        MathAssignment assignment2 = new MathAssignment("Tony","Mathmatics","7.9","100-1000");
        System.Console.WriteLine(assignment2.GetSummary());
        System.Console.WriteLine(assignment2.GetHomeworkList());
        System.Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment("John", "WW3","How to Survive a World War");
        System.Console.WriteLine(assignment3.GetSummary());
        System.Console.WriteLine(assignment3.GetWritingInformation());
        //var person = new Person("id1", "Person1");
        //var student = new Student("id2");
        //inheritance
    }
}


// class Person {
//     protected string _id;
//     protected string _name;

//     public Person(string id, string name)
//     {
//         _id = id;
//         _name = name;
//     }

//     public void Display()
//     {
//         System.Console.WriteLine($"Name = {_name}");
//     }
// }

// //Student
// public class Student : Person
// {
//     protected string _major;

//     public Student(string studentId, string studentName, string major) : base(studentId, studentName)
//     {
//         _major = major;
//     }
    
//     public void DisplayStudentSummary
//     {
//         System.Console.WriteLine($"{_name}: {_major}");
//     }
// }

// //Employee

// public class Employee : Person 
// {
//     private string _department;

//     public Employee(string id, string name, string department) :base(id,name)
//     {
//         _department = department;
//     }
// }