using System;

class Program
{
    Word word;
    Reference reference;
    Scripture scripture;

    public Program()
    {
        reference = new Reference();
        scripture = new Scripture();
        word = new Word(scripture,4);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Program program = new Program();

        Word[] words = new Word[5];
        for (int i = 0; i < 5; i++)
        {
            words[i] = new Word(program.scripture, i);
        }
        
        
     while (true) 
     {
        Console.Clear();
        Console.WriteLine("Welcome Pick a Scripture or type quit to exit");
        program.reference.Menu();

        Console.Write("Your choice: ");
        string choice = Console.ReadLine();
        Console.WriteLine("-------------------");

        if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
        {
            int refIndex = int.Parse(choice) - 1;
            program.MemorizeProcess(refIndex, 4, program.reference, program.scripture, words[refIndex]);
            
        }
        
        else if (choice == "quit" || choice == "Quit")
        {
            break;
        }
     }  
     
        
    }

    private void MemorizeProcess(int refIndex, int amount, Reference reference, Scripture scripture, Word word)
    {
        Console.Clear();
        Console.WriteLine(reference.getReference(refIndex));
        Console.WriteLine(scripture.getScripture(refIndex));
        
            
        

        while (true)
        {   
            //System.Console.WriteLine(reference.getReference(4));
            //System.Console.WriteLine(scripture.getScripture(4));
            Console.Write("Press Enter to take away words or type quit to quit ");
            string choice = Console.ReadLine();
            int nonBlankWordCount = word.getNonBlankWordCount();
            Console.Clear();

            if (choice == "quit" || choice == "Quit" || nonBlankWordCount == 0)
            {
                word.resetRemovedWordsList();

                word.resetNonBlankWordsList(refIndex);
                Console.Clear();
                break;
            }
            
            else
            {
                var removeWords = word.PickRanWords(scripture.getScripture(refIndex),amount,refIndex);
                Console.Clear();
                System.Console.WriteLine(reference.getReference(refIndex));
                //System.Console.WriteLine(removeWords);

                // List<string> removedWordsList = word.getRemovedWordsList();
                // foreach(string item in removedWordsList)
                // {
                //     Console.WriteLine(item + " ");
                // }
                    
               
            


                System.Console.WriteLine(string.Join(" ", word.replaceWithBlank(refIndex)));
    
            }   

            Thread.Sleep(100);  
        }
    }


}