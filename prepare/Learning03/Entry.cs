using System;
using System.Collections;
using System.Text; 
using System.IO;

public class Entry
{
    public string _userResponse;
    public DateTime theCurrentTime = DateTime.Now; 
    public string _prompt;
    public void DisplayEntries(){
        string _dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine($"Date: {_dateText} - Prompt: {_prompt} \n{_userResponse}");
    }

}