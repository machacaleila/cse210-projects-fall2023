using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey there! Do you wanna know your letter grade? ");
        Console.Write("Please tell me your final results: ");
        string finalResult = Console.ReadLine();
        int number = int.Parse(finalResult);

        string letter = " ";
       

        if (number >= 90)
        {
           letter = "A"; 
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Console.WriteLine($"Your grade is: {letter}");

    
        float lastDigit = number % 10;
        string plus = " + ";
        string minus = "-";
       
           if (lastDigit >=7 && letter == "B"){
               Console.WriteLine($"Your grade is: {letter} {plus}");
            }
           else if (lastDigit < 3 && letter == "A"){
            Console.WriteLine($"Your grade is: {letter} {minus}");

            }
           else 
           {
              Console.WriteLine($"Your grade is: {letter}");
            } 
        if (number >= 70 )
        {
            Console.WriteLine("You passed the course!");
        }
        else {
            Console.WriteLine("You can do it better next time!");
        } 
          

    }
}