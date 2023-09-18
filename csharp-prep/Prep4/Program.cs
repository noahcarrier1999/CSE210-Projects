using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        //Primitive types
        int i;
        string s;
        char c;
        float f;
        double d;
        byte b;

        //lists - new keyword
        List<int> myInts = new List<int>();
        {
        myInts.Add(2);
        myInts.Add(55);
        }


        var myStrings = new List<string>();
        {
        myStrings.Add("Hello");

        // Iterate 
        foreach (var i in myInts)
        {
            Console.WriteLine($"my int = {i}");
        }



    }
}