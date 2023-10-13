using System;
using System.Collections;
using System.Text; 
using System.IO;

public class Journal
{
    
    public List<Entry> _save = new List<Entry>();
    public string _fileName;
    //public string _load;
    
    public void DisplayJournal(){
       using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
      // You can add text to the file with the WriteLine method
        outputFile.WriteLine("This will be the first line in the file.");
        outputFile.WriteLine(_save);
     // You can use the $ and include variables just like with Console.WriteLine
      //  string color = "Blue";
       // outputFile.WriteLine($"My favorite color is {color}");
      }
      string[] lines = System.IO.File.ReadAllLines(_fileName);

       foreach (string line in lines)
          {
              string[] parts = line.Split(",");

              string firstName = parts[0];
              string lastName = parts[1];
          }

    }


}