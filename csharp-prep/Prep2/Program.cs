using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your score?");
        string score = Console.ReadLine();
        int number = int.Parse(score);

        string letter = "";

        if (number >= 90 || number <= 100) {
            letter = "A";
        }
        else if (number >= 80 || number <= 89) {
            letter = "B";
        }
        else if (number >=70 || number <= 79) {
            letter = "C";
        }
        else if( number >= 60 || number <= 69) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}.");

        if (number > 70) {
            Console.WriteLine("Congratulations! You passed!");
        }
        else {
            Console.WriteLine("That's ok! Try your best next time!");
        }
    }
}