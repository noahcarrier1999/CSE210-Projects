using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        //If Statements
        // int x = 4;
        // int y = 3;
        // int z = 2;
        // if (x > y)
        // {
        //     Console.WriteLine("Greater than");
        // }

        //indenting
        // if (x > y)
        // {
	    //     if (x > z)
	    //     {
		//         Console.WriteLine("Greater than Both");
        //     }

        //     Console.WriteLine("Greater than");
        // }

        // else
        // if (x > y)
        // {
        //     Console.WriteLine("Greater than");
        // }
        // else
        // {
	    //     Console.WriteLine("Less than");
        // }

        //else if
        // if (x > y)
        // {
        //     Console.WriteLine("Greater than");
        // }
        // else if (x > z)
        // {
	    //     Console.WriteLine("Greater than Z");
        // }
        // else
        // {
	    //     Console.WriteLine("Less than");
        // }


        //Operators
        // string firstname = "Brigham";
        // string lastname = "Young";
        // string name = "John";
        // string color = "red";
        // string favColor = "blue";
        // if (name == "John")
        // {
        //     Console.WriteLine("The name is John");
        // }


        // if (color != favColor)
        // {
        //     Console.WriteLine("That is not my favorite color");
        // }


        //And
        // if (firstname == "Brigham" && lastname == "Young")
        // {
        //     Console.WriteLine("Welcome Brother Brigham");
        // }

        //Or
        // if (name == "Peter" || name == "James" || name == "John")
        // {
        //     Console.WriteLine("This is a biblical name");
        // }


        //Not
        // if (!(name == "Peter" || name == "James" || name == "John"))
        // {
        //     Console.WriteLine("This is not one of those three");
        // }

        //Converting string to int
        // Console.Write("What is your favorite number");
        // string userInput = Console.ReadLine();
        // int number = int.Parse(userInput);

        //Converting int to string
        // int num = 42;
        // string textVersion = num.ToString();

        //asks user for grade
        Console.Write("What is your grade percentage: ");
       
        //reads the input
        string gradeString = Console.ReadLine();
        //converts to and interger
        int grade = int.Parse(gradeString);

        string letter = "";
        int lastDigit = (grade % 10);


        // Finds out the letter grade
        if (grade >= 90 )
        {
            if (lastDigit >= 7)
            {
                letter = "A+";
            }
            else if(lastDigit <= 3) 
            {
                letter = "A-";
            }   
            else{
                letter = "A";  
            }
            
        }
        else if (grade >= 80)
        {
            if (lastDigit >= 7)
            {
                letter = "B+";
            }
            else if(lastDigit <= 3) 
            {
                letter = "B-";
            }   
            else{
                letter = "B";  
            }
        }
        else if (grade >= 70)
        {
            if (lastDigit >= 7)
            {
                letter = "C+";
            }
            else if(lastDigit <= 3) 
            {
                letter = "C-";
            }   
            else{
                letter = "C";  
            }
        }
        else if (grade >= 60)
        {
            if (lastDigit >= 7)
            {
                letter = "D+";
            }
            else if(lastDigit <= 3) 
            {
                letter = "D-";
            }   
            else{
                letter = "D";  
            }
        }
        else
        {
            if (lastDigit >= 7)
            {
                letter = "F+";
            }
            else if(lastDigit <= 3) 
            {
                letter = "F-";
            }   
            else{
                letter = "F";  
            }
        }


        // Determines wether to use an or a
        if (letter == "A")
        {
            Console.WriteLine($"Your grade is an {letter}");
        }
        else
        {
            Console.WriteLine($"Your grade is a {letter}");
        }
        

        //Gives message to user
        if (grade > 70 || grade == 70)
        {
            Console.WriteLine("Congratulations you pass the class!!");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass this class better luck next time.");
        }

    }
}