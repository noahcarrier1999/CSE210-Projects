using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        //String Interpolation
        //int myInt = 5;
        //Console.WriteLine("my int = " + myInt);
        //Console.WriteLine($"my int = {myInt}");

        //Read line
        //Console.Write("What is your name? ");
        //string name = Console.ReadLine();
        //Console.WriteLine($"name = {name}");
       
        //conditionals

        //if (name == "brother Lynn")
        //{
            //Console.WriteLine("Hey thats me");
        //}
        //else
        //{
            //Console.WriteLine($"Hi there {name}");
        //}

        string firstName;
        string lastName;

        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();

        Console.Write("What is your Last name? ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");


    }
}