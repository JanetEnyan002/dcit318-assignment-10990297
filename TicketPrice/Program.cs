using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            decimal ticketPrice;

            if (age >= 65 || age <= 12)
            {
                ticketPrice = 7.0m; // Discounted price for seniors and children
            }
            else
            {
                ticketPrice = 10.0m; // Regular price for adults
            }

            Console.WriteLine($"Ticket price: GHC {ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
