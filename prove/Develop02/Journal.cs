using System.ComponentModel;

public class Journal
{
    //member Variables
    public List<Entry> entriesList = new List<Entry>();

    //meathods
    public void AddEntry(DateTime date, string prompt, string responce)
    {

        Entry newEntry = new Entry(date,prompt,responce);
        
        entriesList.Add(newEntry);
        
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in entriesList)
        {
            DateTime date = entry.date;
            string prompt = entry.prompt;
            string responce = entry.responce;

            System.Console.WriteLine($"Date: {date} ");
            System.Console.WriteLine($"Prompt: {prompt} ");
            System.Console.WriteLine($"Responce: {responce} ");
            System.Console.WriteLine();
        }
    }

    
    public void SaveToFile(string filepath)
    {
        try
        {
            using(StreamWriter writer = new StreamWriter(filepath))
            {   
                foreach (Entry entry in entriesList) 
                {
                    writer.WriteLine($"Date: {entry.date}");
                    writer.WriteLine($"Prompt: {entry.prompt}");
                    writer.WriteLine($"Responce: {entry.responce}");
                    writer.WriteLine();
                }
                
            }

            System.Console.WriteLine("text written to file sucessfully");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"An error occured: {ex.Message}");
        }
    }

    public void LoadFromFile(string filepath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"An error occured: {ex.Message}");
            throw;
        }

        // foreach (string line in lines)
        // {
        //     System.Console.WriteLine(line);
        // }
    }


}
    