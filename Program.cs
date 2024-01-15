// See https://aka.ms/new-console-template for more information
using System.IO;




// it, as, the, and => it_a, as_b, the_d, and_e 
try
{

    Dictionary<string, string> tokens = new();

    tokens.Add("it", "it_a"); //adding a key/value using the Add() method
    tokens.Add("as", "as_b");
    tokens.Add("the", "the_d");
    tokens.Add("shizzle", "shizzle_z");

    string line;
    string readFile = "C:\\Users\\dctutor\\source\\repos\\CopyFileDemo\\sample.txt";
    string writeFile = "C:\\Users\\dctutor\\source\\repos\\CopyFileDemo\\sample1.txt";
    StreamReader sr = new StreamReader(readFile);
    StreamWriter streamWriter = new StreamWriter(writeFile);

    line = sr.ReadLine();

    while (line != null)
    {
        foreach (KeyValuePair<string, string> kvp in tokens) { 
        
            line = line.Replace(kvp.Key, kvp.Value);
        }

        streamWriter.WriteLine(line);
        line = sr.ReadLine();
    }
    sr.Close();
    streamWriter.Close();

    Console.ReadLine();

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Executing finally block");
}


