using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        Console.Write("Side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        if (IsValidTriangle(side1, side2, side3))
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Equilateral Triangle");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("Isosceles Triangle");
            }
            else
            {
                Console.WriteLine("Scalene Triangle");
            }
        }
        else
        {
            Console.WriteLine("Invalid triangle. The sum of any two sides must be greater than the third side.");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}
