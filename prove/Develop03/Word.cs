using System.Diagnostics;
using System.Collections.Generic;

public class Word 
{

    private Random random = new Random();
    private Scripture scripture;
    private List<string> nonBlankWords;

    //List of Removed words
    private List<string> removedWords = new List<string>();
    
    public Word(Scripture scripture, int x)
    {
        this.scripture = scripture;
        nonBlankWords = scripture.scriptureWords(x);
    }

    public int getNonBlankWordCount()
    {
        return nonBlankWords.Count();
    }


    public List<string> getBlankWordList()
    {
        return nonBlankWords;
    }


    public List<string> getRemovedWordsList()
    {
        return removedWords;
    }

    public void resetRemovedWordsList()
    {
        removedWords.Clear();
    }

    public void resetNonBlankWordsList(int x)
    {
        nonBlankWords = scripture.scriptureWords(x);
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
        int maxRemovals = Math.Min(amount, nonBlankWords.Count);
        
        for (int i = 0; i < maxRemovals; i++) 
        {
            if(nonBlankWords.Count == 0)
            {
                System.Console.WriteLine("No more words to remove");
                break;
            } 

            
            //picks a random index
            int randomindex = random.Next(nonBlankWords.Count);
            
            string wordToRemove = nonBlankWords[randomindex];
            removedWords.Add(wordToRemove);

            nonBlankWords.RemoveAt(randomindex);
                //System.Console.WriteLine("BlankWords" + string.Join(", ",nonBlankWords));
            
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