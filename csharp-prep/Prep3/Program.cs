using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //while loop
    
        //var count = 0;
        // while (true)
        // {
        //     Console.WriteLine("Still Going");
        //     if (count >= 5)
        //     {
        //         break;
        //     }
        //     ++count;
        // }


        //do-while
        // do 
        // {
        //     Console.WriteLine("hit");
        //     count++;
        // }
        // while (count < 5);


        //for loop
        // for(var i = 0; i<5; ++i )
        // {
        //     Console.WriteLine($"i = {i}");
        // }


        //for each loop
        // var myInts = new int[]{1,2,3,4,5};
        // foreach(var i in myInts)
        // {
        //     Console.WriteLine($"i = {i}");
        // }

        

        //ask for a random number
        Console.Write("what is your random number: ");
        string randomNumberString = Console.ReadLine();
        int randomNumber = int.Parse(randomNumberString);

        int guessNumber = -1;

        while (guessNumber != randomNumber)
        
        {
            //ask for guesses
            Console.Write("guess a number: ");
            string guessNumberString = Console.ReadLine();
            guessNumber = int.Parse(guessNumberString);

            //Check if guess is high
            if (guessNumber > randomNumber)
            {
                Console.WriteLine("You guessed too high");
            }

        //Check if guess is low
            if (guessNumber < randomNumber)
            {
                Console.WriteLine("You guessed too low");
            }

        //Check if guess is low
            if (guessNumber == randomNumber)
            {
                Console.WriteLine("You guessed right");
            }
        }

    }
}