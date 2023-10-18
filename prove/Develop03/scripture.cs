using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    //Memeber Variables
    private List<string> _scriptures = new List<string>{
        "And if men come unto me I will show unto them their aweakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.",

        "For God so loved the world, that he gave his only begotten  Son, that whosoever believeth in him should not perish, but have everlasting  life.",

        "20. There is a law, irrevocably decreed in heaven before the foundations of this world, upon which all blessings are predicated\n\n21. And when we obtain any blessing from God, it is by obedience to that law upon which it is predicated.",

        "3 He is despised and rejected of men; a man of sorrows, and acquainted with grief; and we hid as it were our faces from him; he was despised, and we esteemed him not.\n\n4 Surely he has aborne our griefs, and carried our sorrows; yet we did esteem him stricken, smitten of God, and afflicted.\n\n5 But he was wounded for our transgressions, he was bruised for our iniquities; the chastisement of our peace was upon him; and with his stripes we are healed.",

        "3 Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your chearts.\n\n4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.\n\n5 And by the power of the Holy Ghost ye may aknow the truth of all things."
    };

    //Function
    

    
    Random random = new Random();
    
    public string getScripture(int x)
    {
        //System.Console.WriteLine(_scriptures[x]); 
        return _scriptures[x];
    }

    public List<string> scriptureWords(int x)
    {
       string scripture = getScripture(x);

       string[] scriptureWords =scripture.Split(" ");

       return scriptureWords.ToList();

    }
    
}