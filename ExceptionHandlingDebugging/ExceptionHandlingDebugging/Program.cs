using System;

namespace ExceptionHandlingDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my game! Let's do some math!");
            StartSequence();
        }

        //StartSequence Method
        static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[userInput];
            Populate(numArray);
        }

        static int[] Populate(int[] populatedArray)
        {
            for (int i = 0; i < populatedArray.Length; i++)
            {
                Console.WriteLine($"Please enter a number: {i + 1} of {populatedArray.Length}");
                string specificNumber = Console.ReadLine();
                populatedArray[i] = Convert.ToInt32(specificNumber); 
            }
            return populatedArray;
           
    }
}

//declare array value as the parsed string