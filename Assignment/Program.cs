using System;

class Program
{
    static int AskForNumber(string text)
    {
        Console.WriteLine(text);
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        return number;
    }

    static int AskForNumberInRange(string text, int min, int max)
    {
        int number;
        do
        {
            number = AskForNumber(text);
        } while (number < min || number > max);

        return number;
    }

    static int[] ReplicateArray(int[] original)
    {
        int[] copiedArray = new int[original.Length];
        Array.Copy(original, copiedArray, original.Length);
        return copiedArray;
    }

    static void Main()
    {
        int size = AskForNumberInRange("Enter the size of the array (0 to 5): ", 0, 5);
        int[] originalArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            originalArray[i] = AskForNumber("Enter an integer: ");
        }

        int[] copiedArray = ReplicateArray(originalArray);

        Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
        Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));
    }
}
