public class Reference
{
    private List<string> references = new List<string>{
        "Ether 12:27",
        "John 3:16",
        "D&C 130: 20-21",
        "Mosiah 14:3-5",
        "Moroni 10:3-5"
    };

    //gets reference
    public string getReference(int num)
    {
        return references[num]; 
    }

    //makes a menu
     public void Menu()
    {
        System.Console.WriteLine(@$"
        ---------------------------------------
        Which Scripture do you Want to Memorize?
        ---------------------------------------
        1.{references[0]}
        2.{references[1]}
        3.{references[2]}
        4.{references[3]}
        5.{references[4]}
        ");

    }

    
}