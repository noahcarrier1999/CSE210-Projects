using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference reference = new Reference();
        Scripture scripture = new Scripture();
        Word word = new Word(scripture, 4);

        
        
     while (true) 
     {
        Console.Clear();
        Console.WriteLine("Welcome Pick a Scripture or type quit to exit");
        reference.Menu();

        Console.Write("Your choice: ");
        string choice = Console.ReadLine();
        Console.WriteLine("-------------------");

        if (choice == "1")
        {

            reference.getReference(0);
            scripture.getScripture(0);
            
        }
        else if (choice == "2")
        {
            reference.getReference(1);
            scripture.getScripture(1);
        }
        else if (choice == "3")
        {
            reference.getReference(2);
            scripture.getScripture(2);
        }
        else if (choice == "4")
        {
            reference.getReference(3);
            scripture.getScripture(3);
        }
        else if (choice == "5")
        {
            Console.Clear();
            Console.WriteLine(reference.getReference(4));
            Console.WriteLine(scripture.getScripture(4));
            Console.Write("Press Enter to take away words or type quit to quit ");
            
            

            while (true)
            {   
                //System.Console.WriteLine(reference.getReference(4));
                //System.Console.WriteLine(scripture.getScripture(4));
                choice = Console.ReadLine();
                int nonBlankWordCount = word.getNonBlankWordCount();

                if (choice == "quit" || choice == "Quit" || nonBlankWordCount == 0)
                {
                    break;
                }
                
            
                if (string.IsNullOrWhiteSpace(choice))
                {
                    var removeWords = word.PickRanWords(scripture.getScripture(4),5);
                    Console.Clear();
                    System.Console.WriteLine(string.Join(" ", word.replaceWithBlank(4)));
        
                }
                
                
                    

            
                
            }
            
        }
        else if (choice == "quit" || choice == "Quit")
        {
            break;
        }
     }  
     
        
    }
}