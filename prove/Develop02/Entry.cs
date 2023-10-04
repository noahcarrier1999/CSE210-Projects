using System.Xml.Linq;
using System.IO;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;





public class Entry
{


    public DateTime date  {get; set;}
    
    public string prompt { get; set;}

    public string responce {get; set;}


    public Entry(DateTime date, string prompt, string responce)
    {
        this.date = date;
        this.prompt = prompt;
        this.responce = responce;
    }
    
    public void SaveEntry(List<Entry> entries)
    {

        entries.Add(this);

    }


    public string DisplayEntry(DateTime date, string prompt, string responce)
    {
        return $"/n Date:{date}/n Prompt:{prompt}/n responce{responce}";
    }

   

    


    
}