using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

    //--------------------------------------------//
        //Primitive types
        //int i;
        //string s;
        //char c;
        //float f;
        //double d;
        //byte b;

        //lists - new keyword
        // List<int> myInts = new List<int>();
        // {
        // myInts.Add(2);
        // myInts.Add(55);
        // }


        // var myStrings = new List<string>();
        // {
        // myStrings.Add("Hello");

        // Iterate 
        // foreach (var i in myInts)
        // {
        //     Console.WriteLine($"my int = {i}");
        // }

        // List<int> numbers = new List<int>();
        
        // numbers.Add(55);
        // numbers.Add(25);
        
        // List<string> words =  new List<string>();

        // words.Add("taco");
        // words.Add("bell");

        // Console.WriteLine(words.Count);

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }
    //-------------------------------------------------//
    int numberInt = -1;

    List<int> numbersList = new List<int>();

    Console.WriteLine("(Enter 0 to quit)");
    Console.WriteLine("--------------------");

    while (numberInt != 0)
        {
            if (numberInt != 0)
            {
                
                Console.Write("Enter a number: ");
                string numberString = Console.ReadLine();
                numberInt = int.Parse(numberString);
                numbersList.Add(numberInt);
            }
            else
            {
                break;
            }
        }
    
    int sum = 0;
    int numberCount = numbersList.Count();
    int adjustedCount = numberCount - 1;
    int largest = 0;

    //Find the sum and the average of the list
    foreach (var number in numbersList)
            {   
                sum += number;

                if (number > largest)
                {
                    largest = number;
                }
            }

    
    float average = ((float)sum) / adjustedCount;
    Console.WriteLine($"The sum: {sum}");
    Console.WriteLine($"The average is: {average}");
    Console.WriteLine($"The largest number is: {largest}");

    }

    
}