using System;

namespace Assignment
{
    public static class ArrayReplicator
    {
        public static int[] ReplicateArray(int[] original)
        {
            int size = original.Length;
            int[] copiedArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                copiedArray[i] = original[i];
            }
            return copiedArray;
        }

        public static int AskForNumber(string text)
        {
            Console.Write(text);
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);
            return number;
        }

        public static int AskForNumber(string text, int min, int max)
        {
            int userInput = AskForNumber(text);
            while (userInput < min || userInput > max)
            {
                Console.WriteLine("Invalid input. Please enter a number within the specified range.");
                userInput = AskForNumber(text);
            }
            return userInput;
        }
    }

    class Program
    {
        static void Main()
        {
            const int Min = 0;
            const int Max = 5;

            int size = ArrayReplicator.AskForNumber("Enter the size of the array (0-5): ", Min, Max);
            int[] originalArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                originalArray[i] = ArrayReplicator.AskForNumber("Enter an integer: ");
            }

            int[] copiedArray = ArrayReplicator.ReplicateArray(originalArray);
            Console.WriteLine("Copied Array:");
            foreach (int number in copiedArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
