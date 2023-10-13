using System;
using System.Collections.Generic;
using System.Data;
class Program
{
    static void Main(string[] args){
          
        Entry answer = new Entry();

        Random questions = new Random();
        int x = questions.Next(5);
        string[] array = new string[5];
        array[0] = "Who was the most interesting person I interacted with today?";
        array[1] = "What was the best part of my day?";
        array[2] = "How did I see the hand of the Lord in my life today?";
        array[3] = "What was the strongest emotion I felt today?";
        array[4] = "If I had one thing I could do over today, what would it be?";

        
        List<string> menu = new List<string>();//Create the list menu
        menu.Add("1.Write");
        menu.Add("2.Display");
        menu.Add("3.Load");
        menu.Add("4.Save");
        menu.Add("5.Quit");
        //Print the whole menu
        //I am going to make the questions here.
        Console.WriteLine("Welcome to the journal Program!");
//Use loop to stop the menu and sking to continue
        int rule = 5;
        while (rule != 10)
         {
            Console.WriteLine("Please select one of the next choices to start: ");
            foreach (string items in menu){
               Console.WriteLine(items);
             }
        
             Console.Write("What would you like to do?:  ");
             rule = int.Parse(Console.ReadLine());
             if (rule == 1){
                Console.WriteLine(array[x]);  
                answer._userResponse = Console.ReadLine();
             }
             else if (rule == 2){
                answer._prompt = array[x];
                answer.DisplayEntries();
             }
             else if (rule == 3){
                Console.WriteLine("not yet...");
             }
             else if (rule == 4){
                Console.WriteLine("Almost. . .");
             }
             else{
                Console.WriteLine("Thanks for waiting! I am not smart and fast.");
                rule = 10;
                
             }
            

         }
    }
}
