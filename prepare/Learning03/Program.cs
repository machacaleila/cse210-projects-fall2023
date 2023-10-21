using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction f1 = new Fraction(); // Call default for testing.
       Console.WriteLine(f1.GetFraction());//Remember you dont call anyone else just the methods which are alreay connnected with the other constructors, setter getter. 
       Console.WriteLine(f1.GetDecimal());

       Fraction f2 = new Fraction(5); //Call for the whole number.
       Console.WriteLine(f2.GetFraction());
       Console.WriteLine(f2.GetDecimal());

       Fraction f3 = new Fraction(3,4); // Call the usual fraction.
       Console.WriteLine(f3.GetFraction());
       Console.WriteLine(f3.GetDecimal());

    }
}