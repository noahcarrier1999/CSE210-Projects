using System.Diagnostics;
using System.Collections.Generic;

public class Word 
{

    private Random random = new Random();
    private Scripture scripture;
    
    private List<string> availableWords;

    //List of Removed words
    private List<string> removedWords;
    
    public Word(Scripture scripture, int x)
    {
        this.scripture = scripture;
        availableWords = scripture.scriptureWords(x);
    }

    //gives a count of available words
    public int getNonBlankWordCount()
    {
        return availableWords.Count();
    }

    //shows what words are still available
    public List<string> getBlankWordList()
    {
        return availableWords;
    }

    //gets a list of words that have been removed
    public List<string> getRemovedWordsList()
    {
        return removedWords;
    }

    //clears the removed words list
    public void resetRemovedWordsList()
    {
        removedWords.Clear();
    }

    // resets the available words list
    public void resetNonBlankWordsList(int x)
    {
        availableWords = scripture.scriptureWords(x);
    }
   
    // public void addRemovedWords(string word)
    // {
    //     removedWords.Add(word);
    // }
    
    // public List<string> GetRemovedWords()
    // {
    //     return removedWords;
    // }
   

//Chooses an amount of random words
//param scripture: the index of the scripture
//param amount: how many random words to choose
//Returns an array of the words removed
    public List<string> PickRanWords(string scripture, int amount, int index)
    {
        int maxRemovals = Math.Min(amount, availableWords.Count);
        
        //repeats the take away for as many times as the user wants
        for (int i = 0; i < maxRemovals; i++) 
        {
            //Checks if there are still words to be removed
            if(availableWords.Count == 0)
            {
                System.Console.WriteLine("No more words to remove");
                break;
            } 

            
            //picks a random index
            int randomindex = random.Next(availableWords.Count);
            
            //Chooses a random word to take away
            string wordToRemove = availableWords[randomindex];
            removedWords.Add(wordToRemove);

            //removes from the available 
            availableWords.RemoveAt(randomindex);

            
        }
        
        return removedWords;
    }
    

// Replaces the removed words with blanks
//parameter: the scripture you want to useing the index
    public List<string> replaceWithBlank(int x)
    {   
        //list of the words in the scripture
        List<string> scriptureWordList = scripture.scriptureWords(x);

        //goes through each word in the removed words and checks to see if they are in the scripture word list
        //then replaces it with blanks
        foreach(string word in removedWords)
        {
            for (int i = 0; i < scriptureWordList.Count; i++)
            {
                string scriptureWord = scriptureWordList[i];
                if (scriptureWord == word)
                {
                    int wordLength = word.Length;
                    string blanked = new string('_', wordLength);

                    scriptureWordList[i] = blanked;
                }
            }
        }
        return scriptureWordList;

    }
    
}