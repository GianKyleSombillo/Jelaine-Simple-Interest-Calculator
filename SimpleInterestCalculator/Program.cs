using System;

class Program
{
    static void Main(string[] args)
    {
        // Introduction
        Console.WriteLine("Welcome to the Simple Interest Calculator!");

        // Get Principal Amount
        Console.Write("Enter the principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        // Get Annual Interest Rate
        Console.Write("Enter the annual interest rate (in %): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        // Get Time Period in Years
        Console.Write("Enter the time period in years: ");
        int time = Convert.ToInt32(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = (principal * rate * time) / 100;

        // Display the result
        Console.WriteLine($"\nSimple Interest = {simpleInterest:F2}");

        // Calculate Total Amount
        double totalAmount = principal + simpleInterest;
        Console.WriteLine($"Total Amount after {time} years = {totalAmount:F2}");

        // End program
        Console.WriteLine("\nThank you for using the Simple Interest Calculator.");
    }
}
