using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        
        //functions

        //returnType FunctionName(ParamType paramName1)
        //{
            
        //}

        // int Add2(int start)
        // {
        //     return start + 2;
        // }
        // Console.WriteLine($"Total:{Add2(4)}");


        // void DisplayString(string value)
        // {
        //     Console.WriteLine(value);
        // }

        // DisplayString("hello world");


        // //scope
        // static int SumItAll(int[] numbers)
        // {
        //     var total = 0;
        //     foreach (var i in numbers)
        //     {
        //         total += i;
        //     }
        //     return total;
        // }

        // var nums = int[]{3,4,5};
        // Console.WriteLine(SumItAll(nums));

        Console.WriteLine("Hello Prep5 World!");
        
        DisplayWelcome();

        string name = PromptUsername();

        int num = PromptNumber();

        int square = SquareNumber(num);

        DisplayResults(name, square);



        //1. Capture requirements
        //2. Requirements sudo code
        //3. Psudo-code to working code
        //4. Test

        //Create DisplayWelcome
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }


        //Create PromptUsername
            //Output a prompt
            //read in name
        static string PromptUsername()
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            return username;

        }
        

        //PromptNumber
        static int PromptNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numString = Console.ReadLine();
            int num = int.Parse(numString);
            return num;
        }


        //SquareNumber
        static int SquareNumber(int num)
        {
            int square = num * num;
            return square;
        }

        

        //DisplayResults
        static void DisplayResults(string name, int num)
        {
            Console.WriteLine($"{name}, the square of your number is {num}");
        }
    
    }
    

}