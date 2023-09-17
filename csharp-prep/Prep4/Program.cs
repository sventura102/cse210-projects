using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0) {
            Console.Write("Enter a number:");

            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            if (userNumber != 0) {
                numbers.Add(userNumber);
            }
        }

        // Summation
        int sum = 0;
        foreach (int number in numbers) {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}.");

        //Average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}.");

        //Max

        int max = numbers [0];

        foreach (int number in numbers) {
            if (number > max) {
                max = number; 
            }
        }
        Console.WriteLine($"The max is {max}.");
    }

        
}