using System;

public class Program
{
    public static int AskForNumber(string text)
    {
        Console.WriteLine(text);
        string response = Console.ReadLine();
        int number = int.Parse(response);
        return number;
    }

    public static int AskForNumberInRange(string text, int min, int max)
    {
        int number;
        do
        {
            number = AskForNumber(text);
        } while (number < min || number > max);

        return number;
    }

    public static void Main()
    {
        int number = AskForNumber("Enter a number: ");
        Console.WriteLine("You entered: " + number);

        int numberInRange = AskForNumberInRange("Enter a number between 1 and 10: ", 1, 10);
        Console.WriteLine("You entered a number within the range: " + numberInRange);
    }
}
