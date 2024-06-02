using System;

class Program
{
    static char CalculateGrade(double score)
    {
        if (score >= 90)
            return 'A';
        else if (score >= 80)
            return 'B';
        else if (score >= 70)
            return 'C';
        else if (score >= 60)
            return 'D';
        else
            return 'F';
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the numerical grade (0-100): ");
        if (double.TryParse(Console.ReadLine(), out double score))
        {
            if (score >= 0 && score <= 100)
            {
                char letterGrade = CalculateGrade(score);
                Console.WriteLine("Letter grade: " + letterGrade);
            }
            else
            {
                Console.WriteLine("Invalid input. Grade must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical grade.");
        }
    }
}
