using System;
using System.Collections;
using System.Text; 

class Program
{
    static void Main(string[] args)
    {
        //Recorda agregar las funciones a variables en la principal funcion para que pueda
        //funcionar. Tambien cuando esten en variables recien ponerlo dentro de los parentesis
        
        DisplayWelcome();
        string u = PromptUserName();
        int other = PromptUserNumber();
        int sq = SquareNumber(other);//como aca hiciste.Agregaste other que dentro de ella esta la funcion. 
        DisplayResult(u, sq);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;

    }
    static int PromptUserNumber(){
        Console.Write("Please enter your favourite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int userNumber){//crea nuevas variables y defini el tipo.
        int square = userNumber * userNumber;
        return square;

    }
    static void DisplayResult(string r, int n ){//crea nuevas variables y defini su tipo luego agregala al resultado.
        Console.WriteLine($" {r} , the square of your number is {n}");
    }
}