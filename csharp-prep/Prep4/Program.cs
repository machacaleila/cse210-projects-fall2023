using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 
        Console.WriteLine("Hi there! Add any number to this list and type 0 when you finished. ");
        
        int rule = 2; 
        while (rule != 10){

            Console.Write("Enter a number: ");
            rule = int.Parse(Console.ReadLine());
            numbers.Add(rule);//add elements to the list.
           // foreach(int other in numbers){
                //Console.WriteLine(other);
            //}
            if (rule == 0){

                int total = numbers.Sum();
                Console.WriteLine($"The sum is: {total}");
                double average = numbers.Average();
                Console.WriteLine($"The average is: {average}");
                int maxNum = numbers.AsQueryable().Max();
                Console.WriteLine($"The largest number is : {maxNum}");
                int minNum = numbers.AsQueryable().Min();
                int a = -1;
                Console.WriteLine($"The smallest positive number is: {minNum*a}");
                //Sort List
                numbers.Sort();
                Console.WriteLine("The sorted list is: ");
                for (int i = 0; i<numbers.Count; i++){
                    int sort = numbers[i];
                    Console.WriteLine(sort);
                }
                
                break;
            }
            else{
                rule = 5;
            }

        }

        

    }
}