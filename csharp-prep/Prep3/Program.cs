using System;
using static System.Console;

class Program
{
    static void Main(string[] args) 
    {
        
        Console.WriteLine("Welcome to the guess game! ");
        

        //Random generator
        Random rand = new Random();
        int number = rand.Next(0, 100);
        int numberguess = 1;
        int numberOfTries = 0;
        while (number != numberguess){
            Console.Write("What is your guess? ");
            //Ask question to the user
            numberguess = int.Parse(Console.ReadLine());
            if (number > numberguess){
                Console.WriteLine("higher");
                numberOfTries++;
                }
            else if (number < numberguess){
                Console.WriteLine("Lower");
                numberOfTries++;
                }
            else{
                Console.WriteLine("Congrats! You guessed it"); 
                Console.WriteLine($"You guessed it in {numberOfTries} times.");
    
                Console.WriteLine("Dou you want to keep playing ?");
                string answer = Console.ReadLine();
                if (answer== "yes"){
                       number = 3;
                    }
                    else{
                        Console.WriteLine("thanks.");
                        break;
                        }
                    }
                }
            
        }   
    }


//